namespace Sporting
{
    partial class FormVidSporta
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
            this.comboBoxVid = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите вид спорта:";
            // 
            // comboBoxVid
            // 
            this.comboBoxVid.FormattingEnabled = true;
            this.comboBoxVid.Location = new System.Drawing.Point(76, 48);
            this.comboBoxVid.Name = "comboBoxVid";
            this.comboBoxVid.Size = new System.Drawing.Size(167, 21);
            this.comboBoxVid.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(181, 110);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(134, 25);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Продолжить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Location = new System.Drawing.Point(10, 112);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(118, 22);
            this.buttonNazad.TabIndex = 3;
            this.buttonNazad.Text = "Вернуться";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // FormVidSporta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 156);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxVid);
            this.Controls.Add(this.label1);
            this.Name = "FormVidSporta";
            this.Text = "FormVidSporta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVid;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonNazad;
    }
}