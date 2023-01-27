using Case.ReceiptGenerator.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case.ReceiptGenerator
{
    public partial class MainForm : Form
    {
        Dictionary<int, List<Label>> dict = new Dictionary<int, List<Label>>();

        public MainForm()
        {
            InitializeComponent();
        }   

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var directory = openFileDialog.FileName;
                    RunAlgorithm(directory);
                }
                else
                {
                    MessageBox.Show("Dosya seç", "Title");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu");
            }

        }

        private void listboxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in pnlDesigner.Controls)
            {
                if (item is Label)
                {
                    (item as Label).BackColor = Color.White;
                    //(item as Label).ForeColor = Color.Black;
                }
            }


            var selected = listboxResult.SelectedIndex;
            if (selected != -1)
            {
                foreach (var item in dict[selected])
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
                
            }
        }

        private void btnDefaultJson_Click(object sender, EventArgs e)
        {
            var fileDirectory = Application.StartupPath + @"\File\data.json";

            RunAlgorithm(fileDirectory);
        }


        private void RunAlgorithm(string directory)
        {
            try
            {
                dict.Clear();
                pnlDesigner.Controls.Clear();
                listboxResult.Items.Clear();

                var labelList = new List<Label>();
                var data = new List<ResponseModel>();
                int panelMaxHeight = 0, counter = 0, lineNumber = 0;

                try
                {
                    var json = File.ReadAllText(directory);
                    data = JsonConvert.DeserializeObject<List<ResponseModel>>(json);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "JSON Okunamadı.");
                }

                foreach (var item in data)
                {
                    if (string.IsNullOrEmpty(item.locale))
                    {
                        var minX = item.boundingPoly.vertices.Min(i => i.x);
                        var minY = item.boundingPoly.vertices.Min(i => i.y);

                        minY += 3;

                        var maxX = item.boundingPoly.vertices.Max(i => i.x);
                        var maxY = item.boundingPoly.vertices.Max(i => i.y);

                        if (panelMaxHeight < maxY)
                            panelMaxHeight = maxY;

                        var label = new Label()
                        {
                            Text = item.description.Replace("\n", "").ToString(),
                            Location = new Point()
                            {
                                X = minX,
                                Y = minY
                            },
                            Size = new Size()
                            {
                                Height = maxY - minY,
                                Width = (maxX - minX) < 3 ? (maxX - minX + 10) : (maxX - minX),
                            },
                            Name = "lbl" + counter++,
                            Font = new Font(FontFamily.GenericSerif, 9f, FontStyle.Bold),
                            ForeColor = Color.Red,
                    };

                        labelList.Add(label);
                        pnlDesigner.Controls.Add(label);
                    }
                }

                foreach (var item in labelList)
                {

                    var dataList = labelList.Where(i => i.Enabled &&
                        ((i.Location.Y <= item.Location.Y + item.Size.Height &&
                        i.Location.Y >= item.Location.Y) ||
                        (i.Location.Y + i.Size.Height >= item.Location.Y
                        && i.Location.Y <= item.Location.Y))
                    ).ToList();

                    if (dataList.Count > 0)
                    {
                        foreach (var tag in dataList)
                        {
                            tag.Enabled = false;
                        }

                        item.Enabled = false;
                        dict.Add(lineNumber, dataList.ToList());

                        lineNumber++;
                    }
                }

                foreach (var item in dict)
                {
                    var title = string.Join(" ", item.Value.Select(i => i.Text));
                    listboxResult.Items.Add(title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu");
            }

        }
    }
}
