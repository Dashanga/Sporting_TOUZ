namespace Sporting
{
    partial class FormPlace
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
            this.labelChoose = new System.Windows.Forms.Label();
            this.checkBoxLenin = new System.Windows.Forms.CheckBox();
            this.checkBoxZhelezka = new System.Windows.Forms.CheckBox();
            this.checkBoxZasviyazhye = new System.Windows.Forms.CheckBox();
            this.checkBoxZavolga = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(12, 9);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(335, 23);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "Выберите местоположение секции:";
            // 
            // checkBoxLenin
            // 
            this.checkBoxLenin.AutoSize = true;
            this.checkBoxLenin.Location = new System.Drawing.Point(180, 72);
            this.checkBoxLenin.Name = "checkBoxLenin";
            this.checkBoxLenin.Size = new System.Drawing.Size(115, 17);
            this.checkBoxLenin.TabIndex = 2;
            this.checkBoxLenin.Text = "Ленинский район";
            this.checkBoxLenin.UseVisualStyleBackColor = true;
            // 
            // checkBoxZhelezka
            // 
            this.checkBoxZhelezka.AutoSize = true;
            this.checkBoxZhelezka.Location = new System.Drawing.Point(16, 72);
            this.checkBoxZhelezka.Name = "checkBoxZhelezka";
            this.checkBoxZhelezka.Size = new System.Drawing.Size(158, 17);
            this.checkBoxZhelezka.TabIndex = 3;
            this.checkBoxZhelezka.Text = "Железнодорожный район";
            this.checkBoxZhelezka.UseVisualStyleBackColor = true;
            // 
            // checkBoxZasviyazhye
            // 
            this.checkBoxZasviyazhye.AutoSize = true;
            this.checkBoxZasviyazhye.Location = new System.Drawing.Point(180, 49);
            this.checkBoxZasviyazhye.Name = "checkBoxZasviyazhye";
            this.checkBoxZasviyazhye.Size = new System.Drawing.Size(128, 17);
            this.checkBoxZasviyazhye.TabIndex = 4;
            this.checkBoxZasviyazhye.Text = "Засвияжский район";
            this.checkBoxZasviyazhye.UseVisualStyleBackColor = true;
            // 
            // checkBoxZavolga
            // 
            this.checkBoxZavolga.AutoSize = true;
            this.checkBoxZavolga.Location = new System.Drawing.Point(16, 49);
            this.checkBoxZavolga.Name = "checkBoxZavolga";
            this.checkBoxZavolga.Size = new System.Drawing.Size(122, 17);
            this.checkBoxZavolga.TabIndex = 5;
            this.checkBoxZavolga.Text = "Заволжский район";
            this.checkBoxZavolga.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(63, 95);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(180, 95);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // FormPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 120);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.checkBoxZavolga);
            this.Controls.Add(this.checkBoxZasviyazhye);
            this.Controls.Add(this.checkBoxZhelezka);
            this.Controls.Add(this.checkBoxLenin);
            this.Controls.Add(this.labelChoose);
            this.Name = "FormPlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.CheckBox checkBoxLenin;
        private System.Windows.Forms.CheckBox checkBoxZhelezka;
        private System.Windows.Forms.CheckBox checkBoxZasviyazhye;
        private System.Windows.Forms.CheckBox checkBoxZavolga;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
    }
}