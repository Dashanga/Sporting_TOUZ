namespace Sporting
{
    partial class FormResult
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
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(586, 398);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(172, 20);
            this.buttonEnd.TabIndex = 1;
            this.buttonEnd.Text = "Завершить";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(13, 400);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(118, 26);
            this.buttonGetData.TabIndex = 2;
            this.buttonGetData.Text = "Отобразить";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(773, 394);
            this.listBox1.TabIndex = 3;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 427);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.buttonEnd);
            this.Name = "FormResult";
            this.Text = "FormResult";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.ListBox listBox1;
    }
}