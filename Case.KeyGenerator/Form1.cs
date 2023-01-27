using System.Diagnostics.Metrics;
using System.Reflection;

namespace Case.KeyGenerator
{
    public partial class Form1 : Form
    {

        public int keyLength = 0, keyCount = 0;
        public string alphabet = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirstway_Click(object sender, EventArgs e)
        {
            if (TextAreaControl())
            {
                var newAlphabet = "";

                // alfabenin b�y�t�lerek karma��kl��� art�rmak
                for (int i = 0; i < keyLength; i++)
                {
                    newAlphabet += alphabet;
                }

                // Random Order i�leminin yap�lmas� ve 8 tane karakter se�ilmesi
                while (keyCount > 0)
                {
                    var key = string.Join("", newAlphabet.OrderBy(i => Guid.NewGuid()).Take(keyLength));

                    if (ControlMethod(key))
                    {
                        listBox.Items.Add(key);
                        keyCount--;
                    }
                }
            }
            else
            {
                MessageBox.Show("Alfabe veya Karakter say�s� ge�ersiz.", "Hata Olu�tu");
            }
        }
        
        // Bu Y�ntem Random Double de�er ile alfabenin uzunlu�unun �arp�larak
        // random veri �retme amac�yla olu�turulmu�tur.
        private void btnSecondway_Click(object sender, EventArgs e)
        {

            if (TextAreaControl())
            {
                var random = new Random();
                while (keyCount > 0)
                {
                    keyLength = 8;
                    var key = "";
                    while (keyLength > 0)
                    {
                        var randomNumber = (int)(random.NextDouble() * alphabet.Length);

                        key += alphabet[randomNumber];

                        keyLength--;
                    }

                    if (ControlMethod(key))
                    {
                        listBox.Items.Add(key);
                        keyCount--;
                    }
                }

                //Test amac�yla �ift kay�t at�labilir.
                //listBox.Items.Add(listBox.Items[0]);
            }
            else
            {
                MessageBox.Show("Alfabe veya Karakter say�s� ge�ersiz.", "Hata Olu�tu");
            }
        }

        private void btnThirdway_Click(object sender, EventArgs e)
        {
            if (TextAreaControl())
            {
                var random = new Random();
                while (keyCount > 0)
                {
                    var key = "";

                    // Normalde Date Parametresi kullanarak while olmadan istek �zerine �al��t�r�lma durumunda bu �ekilde kullan�labilir.
                    // Fakat 1000 adet istenildi�i i�in while ile date parametresini manuel art�rarak ilerletiyoruz.

                    //var dateParam = DateTime.Now.ToString("yyMMddHHmmssff");

                    var randomDouble = random.NextDouble().ToString();
                    var milisecond = int.Parse(randomDouble.Substring(randomDouble.Length - 3, 3));
                    var second = int.Parse(randomDouble.Substring(2, 1));

                    var dateParam = DateTime.Now.AddMilliseconds(milisecond).AddSeconds(second).ToString("yyMMddHHmmssff");
                    //.ToString("yyMMddHHmmssff");
                    //63-81-04-31-52-07-79-38-11
                    //Metodu H�zland�rmak i�in

                    for (int i = 0; i < dateParam.Length / 2; i += 2)
                    {
                        var first = dateParam.Substring(i, 2);
                        var last = dateParam.Substring(dateParam.Length - (2 + i), 2);

                        key += alphabet[int.Parse(first) % alphabet.Length];

                        if (first != last)
                        {
                            key += alphabet[int.Parse(last) % alphabet.Length];
                        }
                        else
                        {
                            key += alphabet[dateParam.Select(i => int.Parse(i.ToString())).Sum(i => i) % alphabet.Length];
                        }
                    }

                    if (ControlMethod(key))
                    {
                        listBox.Items.Add(key);
                        keyCount--;
                    }
                }

            }
            else
            {
                MessageBox.Show("Alfabe veya Karakter say�s� ge�ersiz.", "Hata Olu�tu");
            }
        }

        private void btnControlItems_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                var list = new List<string>();
                foreach (var item in listBox.Items)
                {
                    list.Add(item.ToString());
                }

                var controlList = list.GroupBy(i => i);
                var control = controlList.Where(i => i.Count() > 1);

                if (control.Count() > 0)
                {
                    lblControl.Text = control.Count() + " Adet �ift Kay�t Bulunmaktad�r.";
                    lblControl.ForeColor = Color.Red;
                }
                else
                {
                    lblControl.Text = "�ift Kay�t Bulunamad�.";
                    lblControl.ForeColor = Color.Green;
                }
            
            }
            
        }

        private bool ControlMethod(string key)
        {
            foreach (var item in key)
                if (!alphabet.Contains(item))
                    return false;

            return true;
        }

        private bool TextAreaControl()
        {
            listBox.Items.Clear();
            lblControl.Text = "";

            var txtKeyLengthStr = txtKeyLength.Text;
            var txtAlphabetStr = txtAlphabet.Text;
            var txtKeyCountStr = txtKeyCount.Text;

            int tempKeyLength = 0, tempKeyCount = 0;

            if (!string.IsNullOrEmpty(txtAlphabetStr) && !string.IsNullOrEmpty(txtKeyLengthStr) && !string.IsNullOrEmpty(txtKeyCountStr))
            {
                if (int.TryParse(txtKeyLengthStr, out tempKeyLength) && int.TryParse(txtKeyCountStr, out tempKeyCount))
                {
                    if (tempKeyLength > 0 && tempKeyCount > 0)
                    {
                        keyLength = tempKeyLength;
                        keyCount = tempKeyCount;
                        alphabet = txtAlphabetStr;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}