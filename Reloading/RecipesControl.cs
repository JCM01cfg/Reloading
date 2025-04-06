namespace Reloading
{
    public partial class RecipesControl : UserControl
    {
        public List<Recipe> allRecipes;

        public RecipesControl()
        {
            InitializeComponent();
            LoadSampleData();
            LoadCartridgeList();

        }
        public List<Recipe> GetRecipeList()
        {
            return allRecipes;
        }

        private void LoadSampleData()
        {
            allRecipes = new List<Recipe>
            {
                new Recipe { Cartridge = "6.5 PRC", Date = "12/31/2023", LoadID = "65PRC1561", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "EOL", BulletWeight = 156, Powder = "N570", PowderWeight = 60.0, Primer = "CCI200", CBTO = 2.3800, COL = 3.0600, Velocity = 2824.8, ES = 26.0, SD = 8.1, Rifle = "Tikka T3X", BarrelLength = "24\"", Suppressor = "Banish 30", Group = "Great", BookRefPage = 65, Notes = "Killed elk bull @ 210 yds (1 shot) and mule deer @ 315 (2 shots but 1st was fatal) in 2023 in Mesa, CO." },
                new Recipe { Cartridge = "300 WinMag", Date = "12/3/2023", LoadID = "300WM180SST1", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "SST", BulletWeight = 180, Powder = "H4831SC", PowderWeight = 74.0, Primer = "Rem 9.5", CBTO = 2.8635, COL = 3.4890, Velocity = 2900.8, ES = 49.4, SD = 14.8, Rifle = "Seekins Havak Element", BarrelLength = "22\"", Suppressor = "Banish 30", Group = "Great", BookRefPage = 54 },
                new Recipe { Cartridge = "270 Win", Date = "12/2/2023", LoadID = "270WIN130SST1", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "SST", BulletWeight = 130, Powder = "IMR4831", PowderWeight = 56.1, Primer = "WLR", CBTO = 2.6100, COL = 3.2150, Velocity = 3069.8, ES = 68.3, SD = 21.9, Rifle = "Tikka T3 - Joshua", BarrelLength = "24\"", Suppressor = "None", Group = "Great", BookRefPage = 52 },
                new Recipe { Cartridge = "270 Win", Date = "3/18/2023", LoadID = "270WIN130SPBTSP1", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "SST", BulletWeight = 130, Powder = "H4350", PowderWeight = 54.0, Primer = "CCI200", CBTO = 2.8200, COL = 3.3050, Velocity = 2869.0, ES = 35.0, SD = 16.0, Rifle = "Tikka T3 - Misty", BarrelLength = "24\"", Suppressor = "None", Group = "Great", BookRefPage = 6, Notes = "Below SAAMI Spec COL so should be good in any rifle" },
                new Recipe { Cartridge = "6.5 CM", Date = "11/18/2023", LoadID = "65CM120CX1", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "CX", BulletWeight = 120, Powder = "Staball 6.5", PowderWeight = 44.7, Primer = "WLP", CBTO = 2.0340, COL = 2.6600, Rifle = "Browning Xbolt", BarrelLength = "22\"", Suppressor = "None", Group = "Good", BookRefPage = 46, Notes = "Need to velo this round" },
                new Recipe { Cartridge = "30-06", Date = "3/18/2023", LoadID = "3006SI150SBT1", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "SBT", BulletWeight = 150, Powder = "IMR4350", PowderWeight = 58.5, Primer = "CCI200", CBTO = 2.7050, COL = 3.2450, Velocity = 2855.0, ES = 31.0, SD = 11.0, Rifle = "Sako A7", BarrelLength = "24\"", Suppressor = "None", Group = "Great", BookRefPage = 5 },
                new Recipe { Cartridge = "7 mm PRC", Date = "9/27/2024", LoadID = "7PRC180VLD1", Temp = 88, Type = "Recipe", Brand = "Custom", Bullet = "VLD", BulletWeight = 180, Powder = "N565", PowderWeight = 68, Primer = "Rem 9.5", CBTO = 2.6615, COL = 3.3770, Velocity = 2885.1, ES = 29.2, SD = 12.1, Rifle = "Seekins Havak Element", BarrelLength = "22\"", Suppressor = "Banish 30", Group = "Great", BookRefPage = 72, Notes = "0.8 x 5" },
                new Recipe { Cartridge = "7 mm PRC", Date = "9/27/2024", LoadID = "7PRC180VLD2", Temp = 88, Type = "Recipe", Brand = "Custom", Bullet = "VLD", BulletWeight = 180, Powder = "N570", PowderWeight = 73.5, Primer = "Rem 9.5", CBTO = 2.6615, COL = 3.3770, Velocity = 3001.2, ES = 14.9, SD = 4.9, Rifle = "Seekins Havak Element", BarrelLength = "22\"", Suppressor = "Banish 30", Group = "Great", BookRefPage = 72, Notes = ".996 x 5" },
                new Recipe { Cartridge = "7 mm PRC", Date = "9/27/2024", LoadID = "7PRC180VLD3", Temp = 88, Type = "Recipe", Brand = "Custom", Bullet = "VLD", BulletWeight = 180, Powder = "H4831", PowderWeight = 63, Primer = "Rem 9.5", CBTO = 2.6615, COL = 3.3770, Velocity = 2774.4, ES = 29.2, SD = 10.6, Rifle = "Seekins Havak Element", BarrelLength = "22\"", Suppressor = "Banish 30", Group = "Good", BookRefPage = 72, Notes = "1.1 x 5" },
                new Recipe { Cartridge = "300 WinMag", Date = "9/29/2024", LoadID = "300WM200ELDX1", Temp = 70, Type = "Recipe", Brand = "Custom", Bullet = "ELDX", BulletWeight = 200, Powder = "H1000", PowderWeight = 74.5, Primer = "Rem 9.5", CBTO = 2.8700, COL = 3.5200, Velocity = 2765.0, ES = 27.1, SD = 8.2, Rifle = "Seekins Havak Element", BarrelLength = "22\"", Suppressor = "Banish 30", Group = "Great", BookRefPage = 71, Notes = "1 X 10" }
            };
        }

        private void LoadCartridgeList()
        {
            var cartridgeList = allRecipes
                .Select(r => r.Cartridge)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            comboCartridges.Items.Clear();
            comboCartridges.Items.AddRange(cartridgeList.ToArray());
            if (comboCartridges.Items.Count > 0)
                comboCartridges.SelectedIndex = 0;
        }

        private void comboCartridges_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboCartridges.SelectedItem.ToString();

            var filtered = allRecipes
                .Where(r => r.Cartridge == selected)
                .ToList();

            dataGridRecipes.DataSource = filtered;
            dataGridRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridRecipes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridRecipes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Optional visual polish
            dataGridRecipes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridRecipes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridRecipes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridRecipes.RowTemplate.Height = 50;  // Increase default row height
            dataGridRecipes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

        }
    }
}
