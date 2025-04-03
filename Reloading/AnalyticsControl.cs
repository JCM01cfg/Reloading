using System.Windows.Forms;

namespace Reloading
{
    public partial class AnalyticsControl : UserControl
    {

        List<shotData> shotDataList = new List<shotData>();
        public AnalyticsControl()
        {
            InitializeComponent();

            shotDataGrid.DataSource = shotDataList;
            shotDataGrid.AutoGenerateColumns = true;
            shotDataGrid.ReadOnly = true;

        }

        private void SearchShotDatabtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            shotDataList = db.loadShotData(CartridgeSearchTextBox.Text);
            shotDataGrid.DataSource = shotDataList;


        }

        private void CartridgeSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchShotDatabtn.PerformClick();
            }
        }
    }
}