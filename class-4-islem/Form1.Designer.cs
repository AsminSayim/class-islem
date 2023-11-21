namespace class_4_islem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCikar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBol = new System.Windows.Forms.Label();
            this.lblCarp = new System.Windows.Forms.Label();
            this.lblTopla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(148, 93);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(148, 136);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(137, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "Hesapla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblCikar
            // 
            this.lblCikar.AutoSize = true;
            this.lblCikar.Location = new System.Drawing.Point(375, 143);
            this.lblCikar.Name = "lblCikar";
            this.lblCikar.Size = new System.Drawing.Size(35, 13);
            this.lblCikar.TabIndex = 13;
            this.lblCikar.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // lblBol
            // 
            this.lblBol.AutoSize = true;
            this.lblBol.Location = new System.Drawing.Point(493, 143);
            this.lblBol.Name = "lblBol";
            this.lblBol.Size = new System.Drawing.Size(35, 13);
            this.lblBol.TabIndex = 15;
            this.lblBol.Text = "label5";
            // 
            // lblCarp
            // 
            this.lblCarp.AutoSize = true;
            this.lblCarp.Location = new System.Drawing.Point(493, 98);
            this.lblCarp.Name = "lblCarp";
            this.lblCarp.Size = new System.Drawing.Size(35, 13);
            this.lblCarp.TabIndex = 16;
            this.lblCarp.Text = "label6";
            // 
            // lblTopla
            // 
            this.lblTopla.AutoSize = true;
            this.lblTopla.Location = new System.Drawing.Point(375, 98);
            this.lblTopla.Name = "lblTopla";
            this.lblTopla.Size = new System.Drawing.Size(35, 13);
            this.lblTopla.TabIndex = 17;
            this.lblTopla.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 302);
            this.Controls.Add(this.lblTopla);
            this.Controls.Add(this.lblCarp);
            this.Controls.Add(this.lblBol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCikar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblCikar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBol;
        private System.Windows.Forms.Label lblCarp;
        private System.Windows.Forms.Label lblTopla;
    }
}

