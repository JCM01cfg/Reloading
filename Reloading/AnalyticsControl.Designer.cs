// AnalyticsControl.Designer.cs
namespace Reloading
{
    partial class AnalyticsControl
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
            shotDataGrid = new DataGridView();
            Cartridgelbl = new Label();
            CartridgeComboBox = new ComboBox();
            CartridgeSearchTextBox = new TextBox();
            SearchShotDatabtn = new Button();
            ((System.ComponentModel.ISupportInitialize)shotDataGrid).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(12);
            labelTitle.Size = new Size(218, 78);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Analytics";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // shotDataGrid
            // 
            shotDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shotDataGrid.Location = new Point(76, 150);
            shotDataGrid.Name = "shotDataGrid";
            shotDataGrid.RowHeadersWidth = 51;
            shotDataGrid.Size = new Size(1283, 536);
            shotDataGrid.TabIndex = 1;
            // 
            // Cartridgelbl
            // 
            Cartridgelbl.AutoSize = true;
            Cartridgelbl.Location = new Point(76, 88);
            Cartridgelbl.Name = "Cartridgelbl";
            Cartridgelbl.Size = new Size(71, 20);
            Cartridgelbl.TabIndex = 2;
            Cartridgelbl.Text = "Cartridge";
            // 
            // CartridgeComboBox
            // 
            CartridgeComboBox.FormattingEnabled = true;
            CartridgeComboBox.Location = new Point(196, 88);
            CartridgeComboBox.Name = "CartridgeComboBox";
            CartridgeComboBox.Size = new Size(197, 28);
            CartridgeComboBox.TabIndex = 5;
            // 
            // CartridgeSearchTextBox
            // 
            CartridgeSearchTextBox.Location = new Point(493, 4);
            CartridgeSearchTextBox.Name = "CartridgeSearchTextBox";
            CartridgeSearchTextBox.Size = new Size(241, 27);
            CartridgeSearchTextBox.TabIndex = 3;
            CartridgeSearchTextBox.KeyDown += CartridgeSearchTextBox_KeyDown;
            // 
            // SearchShotDatabtn
            // 
            SearchShotDatabtn.Location = new Point(740, 3);
            SearchShotDatabtn.Name = "SearchShotDatabtn";
            SearchShotDatabtn.Size = new Size(94, 29);
            SearchShotDatabtn.TabIndex = 4;
            SearchShotDatabtn.Text = "Search";
            SearchShotDatabtn.UseVisualStyleBackColor = true;
            SearchShotDatabtn.Click += SearchShotDatabtn_Click;
            // 
            // AnalyticsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            Controls.Add(CartridgeComboBox);
            Controls.Add(SearchShotDatabtn);
            Controls.Add(CartridgeSearchTextBox);
            Controls.Add(Cartridgelbl);
            Controls.Add(shotDataGrid);
            Controls.Add(labelTitle);
            Margin = new Padding(2);
            Name = "AnalyticsControl";
            Size = new Size(1421, 788);
            ((System.ComponentModel.ISupportInitialize)shotDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private DataGridView shotDataGrid;
        private Label Cartridgelbl;
        private ComboBox CartridgeComboBox;
        private TextBox CartridgeSearchTextBox;
        private Button SearchShotDatabtn;
    }
}