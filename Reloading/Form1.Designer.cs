
namespace Reloading
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnStats = new Button();
            button1 = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            PnlNav = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRecipes = new Button();
            panelMainView = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnStats);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRecipes);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Nirmala UI", 10.2F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 1322);
            panel1.TabIndex = 0;
            // 
            // btnStats
            // 
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnStats.ForeColor = SystemColors.Control;
            btnStats.Location = new Point(3, 562);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(302, 92);
            btnStats.TabIndex = 5;
            btnStats.Text = "Statistics";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 1236);
            button1.Name = "button1";
            button1.Size = new Size(302, 86);
            button1.TabIndex = 3;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Leave += button1_Leave;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnAnalytics.ForeColor = SystemColors.Control;
            btnAnalytics.Location = new Point(0, 382);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(302, 86);
            btnAnalytics.TabIndex = 2;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            btnAnalytics.Leave += btnAnalytics_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Location = new Point(0, 296);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(302, 86);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(PnlNav);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 296);
            panel2.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.SkyBlue;
            PnlNav.Location = new Point(0, 309);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(5, 160);
            PnlNav.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(58, 216);
            label2.Name = "label2";
            label2.Size = new Size(187, 29);
            label2.TabIndex = 2;
            label2.Text = "Some User Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(75, 168);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRecipes
            // 
            btnRecipes.FlatAppearance.BorderSize = 0;
            btnRecipes.FlatStyle = FlatStyle.Flat;
            btnRecipes.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnRecipes.ForeColor = SystemColors.Control;
            btnRecipes.Location = new Point(3, 464);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(302, 92);
            btnRecipes.TabIndex = 4;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = true;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // panelMainView
            // 
            panelMainView.Dock = DockStyle.Fill;
            panelMainView.Location = new Point(302, 0);
            panelMainView.Name = "panelMainView";
            panelMainView.Size = new Size(2310, 1322);
            panelMainView.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Azure;
            ClientSize = new Size(2612, 1322);
            Controls.Add(panelMainView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel panelMainView;
        private System.Windows.Forms.Button btnRecipes;
        private Button btnStats;
    }
}