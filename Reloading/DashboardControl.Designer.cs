namespace Reloading
{
    partial class DashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelSignOff = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(20);
            labelTitle.Size = new Size(402, 126);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Dashboard";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSignOff
            // 
            labelSignOff.AutoSize = true;
            labelSignOff.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSignOff.Location = new Point(908, 1154);
            labelSignOff.Name = "labelSignOff";
            labelSignOff.Size = new Size(335, 64);
            labelSignOff.TabIndex = 1;
            labelSignOff.Text = "\nEWIZ Reloading Software 2025";
            labelSignOff.Click += label1_Click;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            Controls.Add(labelSignOff);
            Controls.Add(labelTitle);
            Name = "DashboardControl";
            Size = new Size(1243, 1218);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private Label labelSignOff;
    }
}
