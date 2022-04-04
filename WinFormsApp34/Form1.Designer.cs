namespace WinFormsApp34
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
            this.labelinputkalimat = new System.Windows.Forms.Label();
            this.labelinputhuruf = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.labelmenjadi = new System.Windows.Forms.Label();
            this.textBoxoutputkalimat = new System.Windows.Forms.TextBox();
            this.textBoxoutputhuruf = new System.Windows.Forms.TextBox();
            this.textBoxoutputhasil = new System.Windows.Forms.TextBox();
            this.textBoxoutputmenjadi = new System.Windows.Forms.TextBox();
            this.labelkonversi = new System.Windows.Forms.Label();
            this.buttonkonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelinputkalimat
            // 
            this.labelinputkalimat.AutoSize = true;
            this.labelinputkalimat.Location = new System.Drawing.Point(65, 37);
            this.labelinputkalimat.Name = "labelinputkalimat";
            this.labelinputkalimat.Size = new System.Drawing.Size(146, 25);
            this.labelinputkalimat.TabIndex = 0;
            this.labelinputkalimat.Text = "Masukan Kalimat";
            // 
            // labelinputhuruf
            // 
            this.labelinputhuruf.AutoSize = true;
            this.labelinputhuruf.Location = new System.Drawing.Point(65, 108);
            this.labelinputhuruf.Name = "labelinputhuruf";
            this.labelinputhuruf.Size = new System.Drawing.Size(133, 25);
            this.labelinputhuruf.TabIndex = 1;
            this.labelinputhuruf.Text = "Masukan Huruf";
            this.labelinputhuruf.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(74, 248);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(50, 25);
            this.labelhasil.TabIndex = 2;
            this.labelhasil.Text = "Hasil";
            this.labelhasil.Click += new System.EventHandler(this.labelhasil_Click);
            // 
            // labelmenjadi
            // 
            this.labelmenjadi.AutoSize = true;
            this.labelmenjadi.Location = new System.Drawing.Point(443, 108);
            this.labelmenjadi.Name = "labelmenjadi";
            this.labelmenjadi.Size = new System.Drawing.Size(75, 25);
            this.labelmenjadi.TabIndex = 3;
            this.labelmenjadi.Text = "Menjadi";
            // 
            // textBoxoutputkalimat
            // 
            this.textBoxoutputkalimat.Location = new System.Drawing.Point(217, 31);
            this.textBoxoutputkalimat.Name = "textBoxoutputkalimat";
            this.textBoxoutputkalimat.Size = new System.Drawing.Size(444, 31);
            this.textBoxoutputkalimat.TabIndex = 4;
            this.textBoxoutputkalimat.TextChanged += new System.EventHandler(this.textBoxoutputkalimat_TextChanged);
            // 
            // textBoxoutputhuruf
            // 
            this.textBoxoutputhuruf.Location = new System.Drawing.Point(217, 102);
            this.textBoxoutputhuruf.Name = "textBoxoutputhuruf";
            this.textBoxoutputhuruf.Size = new System.Drawing.Size(150, 31);
            this.textBoxoutputhuruf.TabIndex = 5;
            this.textBoxoutputhuruf.TextChanged += new System.EventHandler(this.textBoxoutputhuruf_TextChanged);
            // 
            // textBoxoutputhasil
            // 
            this.textBoxoutputhasil.Location = new System.Drawing.Point(160, 242);
            this.textBoxoutputhasil.Name = "textBoxoutputhasil";
            this.textBoxoutputhasil.Size = new System.Drawing.Size(377, 31);
            this.textBoxoutputhasil.TabIndex = 6;
            this.textBoxoutputhasil.TextChanged += new System.EventHandler(this.textBoxoutputhasil_TextChanged);
            // 
            // textBoxoutputmenjadi
            // 
            this.textBoxoutputmenjadi.Location = new System.Drawing.Point(553, 102);
            this.textBoxoutputmenjadi.Name = "textBoxoutputmenjadi";
            this.textBoxoutputmenjadi.Size = new System.Drawing.Size(150, 31);
            this.textBoxoutputmenjadi.TabIndex = 7;
            this.textBoxoutputmenjadi.TextChanged += new System.EventHandler(this.textBoxoutputmenjadi_TextChanged);
            // 
            // labelkonversi
            // 
            this.labelkonversi.AutoSize = true;
            this.labelkonversi.Location = new System.Drawing.Point(354, 184);
            this.labelkonversi.Name = "labelkonversi";
            this.labelkonversi.Size = new System.Drawing.Size(0, 25);
            this.labelkonversi.TabIndex = 8;
            // 
            // buttonkonversi
            // 
            this.buttonkonversi.Location = new System.Drawing.Point(264, 175);
            this.buttonkonversi.Name = "buttonkonversi";
            this.buttonkonversi.Size = new System.Drawing.Size(353, 34);
            this.buttonkonversi.TabIndex = 9;
            this.buttonkonversi.Text = "Konversi";
            this.buttonkonversi.UseVisualStyleBackColor = true;
            this.buttonkonversi.Click += new System.EventHandler(this.buttonkonversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonkonversi);
            this.Controls.Add(this.labelkonversi);
            this.Controls.Add(this.textBoxoutputmenjadi);
            this.Controls.Add(this.textBoxoutputhasil);
            this.Controls.Add(this.textBoxoutputhuruf);
            this.Controls.Add(this.textBoxoutputkalimat);
            this.Controls.Add(this.labelmenjadi);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.labelinputhuruf);
            this.Controls.Add(this.labelinputkalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinputkalimat;
        private System.Windows.Forms.Label labelinputhuruf;
        private System.Windows.Forms.Label labelhasil;
        private System.Windows.Forms.Label labelmenjadi;
        private System.Windows.Forms.TextBox textBoxoutputkalimat;
        private System.Windows.Forms.TextBox textBoxoutputhuruf;
        private System.Windows.Forms.TextBox textBoxoutputhasil;
        private System.Windows.Forms.TextBox textBoxoutputmenjadi;
        private System.Windows.Forms.Label labelkonversi;
        private System.Windows.Forms.Button buttonkonversi;
    }
}
