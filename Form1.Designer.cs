namespace Factory01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTel = new System.Windows.Forms.Label();
            this.ozellikleriGetir = new System.Windows.Forms.Button();
            this.listBoxTel = new System.Windows.Forms.ListBox();
            this.comboBoxTel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(44, 76);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(167, 21);
            this.labelTel.TabIndex = 0;
            this.labelTel.Text = "Telefon Modeli Secin";
            // 
            // ozellikleriGetir
            // 
            this.ozellikleriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozellikleriGetir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ozellikleriGetir.Location = new System.Drawing.Point(48, 170);
            this.ozellikleriGetir.Name = "ozellikleriGetir";
            this.ozellikleriGetir.Size = new System.Drawing.Size(141, 32);
            this.ozellikleriGetir.TabIndex = 2;
            this.ozellikleriGetir.Text = "Ozellikleri Getir";
            this.ozellikleriGetir.UseVisualStyleBackColor = true;
            this.ozellikleriGetir.Click += new System.EventHandler(this.ozellikleriGetir_Click);
            // 
            // listBoxTel
            // 
            this.listBoxTel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTel.FormattingEnabled = true;
            this.listBoxTel.ItemHeight = 20;
            this.listBoxTel.Location = new System.Drawing.Point(273, 76);
            this.listBoxTel.Name = "listBoxTel";
            this.listBoxTel.Size = new System.Drawing.Size(449, 204);
            this.listBoxTel.TabIndex = 3;
            // 
            // comboBoxTel
            // 
            this.comboBoxTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTel.FormattingEnabled = true;
            this.comboBoxTel.Items.AddRange(new object[] {
            "SamsungJ6",
            "SamsungJ6Plus",
            "Iphone8",
            "Iphone7",
            "Iphone6"});
            this.comboBoxTel.Location = new System.Drawing.Point(48, 115);
            this.comboBoxTel.Name = "comboBoxTel";
            this.comboBoxTel.Size = new System.Drawing.Size(155, 28);
            this.comboBoxTel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 406);
            this.Controls.Add(this.listBoxTel);
            this.Controls.Add(this.ozellikleriGetir);
            this.Controls.Add(this.comboBoxTel);
            this.Controls.Add(this.labelTel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button ozellikleriGetir;
        private System.Windows.Forms.ListBox listBoxTel;
        private System.Windows.Forms.ComboBox comboBoxTel;
    }
}

