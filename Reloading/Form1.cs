
using OfficeOpenXml;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Reloading
{
    public partial class Form1 : Form
    {
        private Button currentNavButton;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Rounded corners
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Set initial nav style
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            // Load initial view
            LoadView(new DashboardControl());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: if you want to do additional setup
        }

        private void ResetNavButtonColors()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button btn &&
                    (btn.Name.StartsWith("btn") || btn.Name.StartsWith("button")) &&
                    btn != currentNavButton)
                {
                    btn.BackColor = Color.SlateBlue;
                }
            }
        }

        private void LoadView(UserControl view)
        {
            panelMainView.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelMainView.Controls.Add(view);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            currentNavButton = btnDashboard;

            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;

            LoadView(new DashboardControl());
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
            currentNavButton = btnAnalytics;

            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;

            LoadView(new AnalyticsControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            button1.BackColor = Color.FromArgb(46, 51, 73);
            currentNavButton = button1;

            PnlNav.Height = button1.Height;
            PnlNav.Top = button1.Top;
            PnlNav.Left = button1.Left;

            LoadView(new SettingsControl());
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            if (currentNavButton != btnDashboard)
                btnDashboard.BackColor = Color.SlateBlue;
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            if (currentNavButton != btnAnalytics)
                btnAnalytics.BackColor = Color.SlateBlue;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            if (currentNavButton != button1)
                button1.BackColor = Color.SlateBlue;
        }
        private void btnRecipes_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            btnRecipes.BackColor = Color.FromArgb(46, 51, 73);
            currentNavButton = btnRecipes;

            PnlNav.Height = btnRecipes.Height;
            PnlNav.Top = btnRecipes.Top;
            PnlNav.Left = btnRecipes.Left;

            LoadView(new RecipesControl());
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            btnStats.BackColor = Color.FromArgb(46, 51, 73);


            PnlNav.Height = btnStats.Height;
            PnlNav.Top = btnStats.Top;
            PnlNav.Left = btnStats.Left;

            LoadView(new StatsControl());
        }
    }
}
