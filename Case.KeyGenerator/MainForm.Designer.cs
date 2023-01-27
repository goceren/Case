namespace Case.KeyGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.btnControlItems = new System.Windows.Forms.Button();
            this.txtKeyCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThirdway = new System.Windows.Forms.Button();
            this.btnSecondway = new System.Windows.Forms.Button();
            this.txtKeyLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Alfabe = new System.Windows.Forms.Label();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.btnFirstway = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblControl);
            this.panel1.Controls.Add(this.btnControlItems);
            this.panel1.Controls.Add(this.txtKeyCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThirdway);
            this.panel1.Controls.Add(this.btnSecondway);
            this.panel1.Controls.Add(this.txtKeyLength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Alfabe);
            this.panel1.Controls.Add(this.txtAlphabet);
            this.panel1.Controls.Add(this.btnFirstway);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 749);
            this.panel1.TabIndex = 0;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblControl.Location = new System.Drawing.Point(12, 694);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(0, 30);
            this.lblControl.TabIndex = 10;
            // 
            // btnControlItems
            // 
            this.btnControlItems.Location = new System.Drawing.Point(347, 669);
            this.btnControlItems.Name = "btnControlItems";
            this.btnControlItems.Size = new System.Drawing.Size(114, 55);
            this.btnControlItems.TabIndex = 9;
            this.btnControlItems.Text = "Kontrol";
            this.btnControlItems.UseVisualStyleBackColor = true;
            this.btnControlItems.Click += new System.EventHandler(this.btnControlItems_Click);
            // 
            // txtKeyCount
            // 
            this.txtKeyCount.Location = new System.Drawing.Point(160, 109);
            this.txtKeyCount.Name = "txtKeyCount";
            this.txtKeyCount.Size = new System.Drawing.Size(250, 23);
            this.txtKeyCount.TabIndex = 8;
            this.txtKeyCount.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adet";
            // 
            // btnThirdway
            // 
            this.btnThirdway.Location = new System.Drawing.Point(20, 357);
            this.btnThirdway.Name = "btnThirdway";
            this.btnThirdway.Size = new System.Drawing.Size(114, 55);
            this.btnThirdway.TabIndex = 6;
            this.btnThirdway.Text = "Üçüncü Yöntem";
            this.btnThirdway.UseVisualStyleBackColor = true;
            this.btnThirdway.Click += new System.EventHandler(this.btnThirdway_Click);
            // 
            // btnSecondway
            // 
            this.btnSecondway.Location = new System.Drawing.Point(20, 269);
            this.btnSecondway.Name = "btnSecondway";
            this.btnSecondway.Size = new System.Drawing.Size(114, 51);
            this.btnSecondway.TabIndex = 5;
            this.btnSecondway.Text = "İkinci Yöntem";
            this.btnSecondway.UseVisualStyleBackColor = true;
            this.btnSecondway.Click += new System.EventHandler(this.btnSecondway_Click);
            // 
            // txtKeyLength
            // 
            this.txtKeyLength.Location = new System.Drawing.Point(160, 66);
            this.txtKeyLength.Name = "txtKeyLength";
            this.txtKeyLength.Size = new System.Drawing.Size(250, 23);
            this.txtKeyLength.TabIndex = 4;
            this.txtKeyLength.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karakter Sayısı";
            // 
            // Alfabe
            // 
            this.Alfabe.AutoSize = true;
            this.Alfabe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alfabe.Location = new System.Drawing.Point(12, 26);
            this.Alfabe.Name = "Alfabe";
            this.Alfabe.Size = new System.Drawing.Size(60, 21);
            this.Alfabe.TabIndex = 2;
            this.Alfabe.Text = "Alfabe";
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.Location = new System.Drawing.Point(160, 26);
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(250, 23);
            this.txtAlphabet.TabIndex = 1;
            this.txtAlphabet.Text = "ACDEFGHKLMNPRTXYZ234579";
            // 
            // btnFirstway
            // 
            this.btnFirstway.Location = new System.Drawing.Point(20, 184);
            this.btnFirstway.Name = "btnFirstway";
            this.btnFirstway.Size = new System.Drawing.Size(114, 51);
            this.btnFirstway.TabIndex = 0;
            this.btnFirstway.Text = "Birinci Yöntem";
            this.btnFirstway.UseVisualStyleBackColor = true;
            this.btnFirstway.Click += new System.EventHandler(this.btnFirstway_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(477, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 749);
            this.panel2.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(524, 749);
            this.listBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnThirdway;
        private Button btnSecondway;
        private TextBox txtKeyLength;
        private Label label1;
        private Label Alfabe;
        private TextBox txtAlphabet;
        private Button btnFirstway;
        private Panel panel2;
        private TextBox txtKeyCount;
        private Label label2;
        private ListBox listBox;
        private Label lblControl;
        private Button btnControlItems;
    }
}