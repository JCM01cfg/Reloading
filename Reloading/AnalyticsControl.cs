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
            DataAccess db = new DataAccess();
            var cartridgeList = db.GetAllCartridgeNames();
            CartridgeComboBox.DataSource = cartridgeList;
            CartridgeComboBox.SelectedIndexChanged += CartridgeComboBox_SelectedIndexChanged;

            CartridgeSearchTextBox.Visible = false;
            SearchShotDatabtn.Visible = false;




            CartridgeComboBox.Visible = true;
            CartridgeComboBox.BringToFront();
            CartridgeComboBox.BackColor = Color.LightYellow;
            CartridgeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void SearchShotDatabtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            shotDataList = db.loadShotData(CartridgeSearchTextBox.Text);
            shotDataGrid.DataSource = shotDataList;

            foreach (DataGridViewRow row in shotDataGrid.Rows)
            {

                if (row.IsNewRow) continue;

                string note = row.Cells["Notes"].Value?.ToString();
                switch (note)
                {
                    case "Great":
                        row.DefaultCellStyle.BackColor = Color.Green; break;
                    case "Good":
                        row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "OK":
                        row.DefaultCellStyle.BackColor = Color.LightYellow; break;
                    case "Bad":
                        row.DefaultCellStyle.BackColor = Color.LightCoral; break;
                }



            }
        }

        private void CartridgeSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchShotDatabtn.PerformClick();
            }
        }

        private void CartridgeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCartridge = CartridgeComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedCartridge))
                return;

            DataAccess db = new DataAccess();
            shotDataList = db.loadShotData(selectedCartridge);
            shotDataGrid.DataSource = shotDataList;

            // Optional: Highlight rows based on Notes
            foreach (DataGridViewRow row in shotDataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                string note = row.Cells["Notes"].Value?.ToString();
                switch (note)
                {
                    case "Great": row.DefaultCellStyle.BackColor = Color.Green; break;
                    case "Good": row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "OK": row.DefaultCellStyle.BackColor = Color.LightYellow; break;
                    case "Bad": row.DefaultCellStyle.BackColor = Color.LightCoral; break;
                }
            }
        }
    }
}