namespace Sporting
{
    partial class FormTipe
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
            this.checkBoxTeam = new System.Windows.Forms.CheckBox();
            this.checkBoxAlong = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(25, 9);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(217, 23);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "Выберите тип спорта:";
            // 
            // checkBoxTeam
            // 
            this.checkBoxTeam.AutoSize = true;
            this.checkBoxTeam.Location = new System.Drawing.Point(29, 49);
            this.checkBoxTeam.Name = "checkBoxTeam";
            this.checkBoxTeam.Size = new System.Drawing.Size(85, 17);
            this.checkBoxTeam.TabIndex = 2;
            this.checkBoxTeam.Text = "Командный";
            this.checkBoxTeam.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlong
            // 
            this.checkBoxAlong.AutoSize = true;
            this.checkBoxAlong.Location = new System.Drawing.Point(144, 49);
            this.checkBoxAlong.Name = "checkBoxAlong";
            this.checkBoxAlong.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAlong.TabIndex = 3;
            this.checkBoxAlong.Text = "Одиночный";
            this.checkBoxAlong.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(39, 76);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(152, 76);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // FormTipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.checkBoxAlong);
            this.Controls.Add(this.checkBoxTeam);
            this.Controls.Add(this.labelChoose);
            this.Name = "FormTipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.CheckBox checkBoxTeam;
        private System.Windows.Forms.CheckBox checkBoxAlong;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
    }
}