namespace Reloading
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            PnlNav = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelDashboard = new Panel();
            panelAnalytics = new Panel();
            dataGridView1 = new DataGridView();
            panelSettings = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            panelAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 761);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 707);
            button1.Name = "button1";
            button1.Size = new Size(186, 54);
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
            btnAnalytics.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalytics.ForeColor = SystemColors.Control;
            btnAnalytics.Location = new Point(0, 239);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(186, 54);
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
            btnDashboard.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Location = new Point(0, 185);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 54);
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
            panel2.Size = new Size(186, 185);
            panel2.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.SkyBlue;
            PnlNav.Location = new Point(0, 193);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 100);
            PnlNav.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(36, 135);
            label2.Name = "label2";
            label2.Size = new Size(116, 18);
            label2.TabIndex = 2;
            label2.Text = "Some User Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(46, 105);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.LightSlateGray;
            panelDashboard.Controls.Add(panelAnalytics);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(186, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(765, 761);
            panelDashboard.TabIndex = 1;
            // 
            // panelAnalytics
            // 
            panelAnalytics.Controls.Add(dataGridView1);
            panelAnalytics.Controls.Add(panelSettings);
            panelAnalytics.Dock = DockStyle.Fill;
            panelAnalytics.Location = new Point(0, 0);
            panelAnalytics.Name = "panelAnalytics";
            panelAnalytics.Size = new Size(765, 761);
            panelAnalytics.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(765, 761);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelSettings
            // 
            panelSettings.Dock = DockStyle.Fill;
            panelSettings.Location = new Point(0, 0);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(765, 761);
            panelSettings.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Azure;
            ClientSize = new Size(951, 761);
            Controls.Add(panelDashboard);
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
            panelDashboard.ResumeLayout(false);
            panelAnalytics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashboard;
        private Label label2;
        private Button btnAnalytics;
        private Button button1;
        private Panel PnlNav;
        private Panel panelDashboard;
        private Panel panelAnalytics;
        private Panel panelSettings;
        private DataGridView dataGridView1;
    }
}
