namespace AdventOfLove
{
    partial class FormCit
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
            this.lblCit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCit
            // 
            this.lblCit.AutoSize = true;
            this.lblCit.Location = new System.Drawing.Point(281, 193);
            this.lblCit.Name = "lblCit";
            this.lblCit.Size = new System.Drawing.Size(35, 13);
            this.lblCit.TabIndex = 0;
            this.lblCit.Text = "lblCit";
            // 
            // FormCit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventOfLove.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 396);
            this.Controls.Add(this.lblCit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(583, 435);
            this.MinimumSize = new System.Drawing.Size(583, 435);
            this.Name = "FormCit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventOfLove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCit;
    }
}