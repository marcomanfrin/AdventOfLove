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
            this.Cit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cit
            // 
            this.Cit.AutoSize = true;
            this.Cit.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cit.Location = new System.Drawing.Point(493, 345);
            this.Cit.Name = "Cit";
            this.Cit.Size = new System.Drawing.Size(75, 42);
            this.Cit.TabIndex = 0;
            this.Cit.Text = "text";
            // 
            // FormCit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventOfLove.Properties.Resources.sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 729);
            this.Controls.Add(this.Cit);
            this.MaximumSize = new System.Drawing.Size(1150, 800);
            this.MinimumSize = new System.Drawing.Size(1150, 800);
            this.Name = "FormCit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventOfLove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cit;
    }
}