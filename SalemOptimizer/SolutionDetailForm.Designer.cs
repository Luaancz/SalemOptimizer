namespace SalemOptimizer
{
    partial class SolutionDetailForm
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
            this.pnlInspirationals = new System.Windows.Forms.Panel();
            this.lblInspirationals = new System.Windows.Forms.Label();
            this.pnlInspirationals.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInspirationals
            // 
            this.pnlInspirationals.AutoScroll = true;
            this.pnlInspirationals.Controls.Add(this.lblInspirationals);
            this.pnlInspirationals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInspirationals.Location = new System.Drawing.Point(0, 0);
            this.pnlInspirationals.Name = "pnlInspirationals";
            this.pnlInspirationals.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInspirationals.Size = new System.Drawing.Size(198, 277);
            this.pnlInspirationals.TabIndex = 1;
            // 
            // lblInspirationals
            // 
            this.lblInspirationals.AutoSize = true;
            this.lblInspirationals.Location = new System.Drawing.Point(10, 10);
            this.lblInspirationals.Name = "lblInspirationals";
            this.lblInspirationals.Padding = new System.Windows.Forms.Padding(2);
            this.lblInspirationals.Size = new System.Drawing.Size(72, 17);
            this.lblInspirationals.TabIndex = 1;
            this.lblInspirationals.Text = "Inspirationals";
            // 
            // SolutionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 277);
            this.Controls.Add(this.pnlInspirationals);
            this.MaximizeBox = false;
            this.Name = "SolutionDetailForm";
            this.Text = "Solution detail";
            this.TopMost = true;
            this.pnlInspirationals.ResumeLayout(false);
            this.pnlInspirationals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInspirationals;
        private System.Windows.Forms.Label lblInspirationals;

    }
}