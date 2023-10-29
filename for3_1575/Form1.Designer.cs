namespace for3_1575
{
    partial class Form1
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
            btnEkle = new Button();
            lbsayi = new ListBox();
            txtSayilar = new TextBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SpringGreen;
            btnEkle.Location = new Point(175, 78);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(116, 42);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lbsayi
            // 
            lbsayi.FormattingEnabled = true;
            lbsayi.ItemHeight = 20;
            lbsayi.Location = new Point(12, 12);
            lbsayi.Name = "lbsayi";
            lbsayi.Size = new Size(150, 364);
            lbsayi.TabIndex = 1;
            // 
            // txtSayilar
            // 
            txtSayilar.Location = new Point(172, 12);
            txtSayilar.Name = "txtSayilar";
            txtSayilar.Size = new Size(125, 27);
            txtSayilar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(309, 399);
            Controls.Add(txtSayilar);
            Controls.Add(lbsayi);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private ListBox lbsayi;
        private TextBox txtSayilar;
    }
}