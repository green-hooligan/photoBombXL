namespace PhotoBombXL
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
            this.lstProfileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProfileList
            // 
            this.lstProfileList.BackColor = System.Drawing.SystemColors.Window;
            this.lstProfileList.FormattingEnabled = true;
            this.lstProfileList.Location = new System.Drawing.Point(392, 92);
            this.lstProfileList.Name = "lstProfileList";
            this.lstProfileList.Size = new System.Drawing.Size(230, 225);
            this.lstProfileList.TabIndex = 0;
            this.lstProfileList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 458);
            this.Controls.Add(this.lstProfileList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfileList;
    }
}

