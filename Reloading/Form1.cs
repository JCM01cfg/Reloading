using OfficeOpenXml;
using System.IO;    
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;




namespace Reloading
{
    public partial class Form1 : Form
    {

        private void ShowPanel(Panel panelToShow)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel panel && panel.Dock == DockStyle.Fill)
                {
                    panel.Visible = false;
                }
            }

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void ResetNavButtonColors()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn &&
                    (btn.Name.StartsWith("btn") || btn.Name.StartsWith("button")))
                {
                    // Only reset buttons that are NOT the current one
                    if (btn != currentNavButton)
                    {
                        btn.BackColor = Color.DodgerBlue;
                    }
                }
            }
        }
        

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPanel(panelDashboard);
            btnDashboard_Click(btnDashboard, EventArgs.Empty);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            currentNavButton = btnDashboard;

            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            ShowPanel(panelDashboard);

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            currentNavButton = btnDashboard;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
            ShowPanel(panelAnalytics);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetNavButtonColors();
            currentNavButton = btnDashboard;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            PnlNav.Height = button1.Height;
            PnlNav.Top = button1.Top;
            PnlNav.Left = button1.Left;
            ShowPanel(panelSettings);

        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            if (currentNavButton != btnDashboard)
                btnDashboard.BackColor = Color.DodgerBlue;
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            if (currentNavButton != btnAnalytics)
                btnAnalytics.BackColor = Color.DodgerBlue;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            if (currentNavButton != button1)
                button1.BackColor = Color.DodgerBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
