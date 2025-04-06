using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Reloading
{
    public partial class StatsControl : UserControl
    {

        private readonly Chart chartVelocity;
        private readonly Chart chartES;
        private readonly Chart chartSD;
        private readonly List<CartridgeStats> stats;

        private List<CartridgeStats> CalculateStats(List<Recipe> recipes)
        {
            return recipes
                .GroupBy(r => r.Cartridge)  // Group by cartridge
                .Select(g => new CartridgeStats
                {
                    Cartridge = g.Key,
                    AvgVelocity = Math.Round(g.Average(r => r.Velocity), 1),  // Calculate the average velocity for each cartridge
                    AvgES = Math.Round(g.Average(r => r.ES), 1),
                    AvgSD = Math.Round(g.Average(r => r.SD), 1),
                    RecipeCount = g.Count()
                })
                .OrderByDescending(s => s.RecipeCount)  // Sort by recipe count (optional)
                .ToList();

        }

        public StatsControl()
        {
            InitializeComponent();  // Make sure InitializeComponent is called

            // Initialize the ComboBox for cartridge selection
            cartridgeDropDown = new ComboBox();
            cartridgeDropDown.Size = new Size(200, 30);  // Set the size of the ComboBox
            cartridgeDropDown.Location = new Point(750, 10);  // Set its position on the form
            cartridgeDropDown.DropDownStyle = ComboBoxStyle.DropDownList;  // Prevent user from typing in the ComboBox
            this.Controls.Add(cartridgeDropDown);  // Add ComboBox to the form

            // Add event handler for ComboBox selection change
            cartridgeDropDown.SelectedIndexChanged += cartridgeDropDown_SelectedIndexChanged;

            // Initialize the chartVelocity control (First chart in first row)
            chartVelocity = new Chart();
            chartVelocity.Size = new Size(475, 300);  // Set the size of the chart (adjust width for side-by-side)
            chartVelocity.Location = new Point(10, 50);  // Set the position on the form
            this.Controls.Add(chartVelocity);  // Add chartVelocity to the control collection

            // Initialize the chartES control (Second chart in first row)
            chartES = new Chart();
            chartES.Size = new Size(475, 300);  // Same width to align
            chartES.Location = new Point(500, 50);  // Position it beside chartVelocity
            this.Controls.Add(chartES);

            // Initialize the chartSD control (First chart in second row)
            chartSD = new Chart();
            chartSD.Size = new Size(475, 300);  // Same width for alignment
            chartSD.Location = new Point(10, 360);  // Below the first row of charts
            this.Controls.Add(chartSD);

            // Add another chart if needed, in case you want 4 char
            Chart chart4 = new Chart();
            chart4.Size = new Size(475, 300);
            chart4.Location = new Point(500, 360);
            this.Controls.Add(chart4);



            // Now, proceed with data fetching and displaying the charts
            var recipeControl = new RecipesControl();
            var allRecipes = recipeControl.GetRecipeList();  // Fetch the list of recipes
            stats = CalculateStats(allRecipes);  // Calculate stats

            // Populate the ComboBox with available cartridges after stats are initialized
            cartridgeDropDown.Items.Add("All Cartridges");  // Option for all cartridges
            foreach (var stat in stats)
            {
                cartridgeDropDown.Items.Add(stat.Cartridge);  // Add each cartridge to the dropdown
            }
            cartridgeDropDown.SelectedIndex = 0;  // Select the default option ("All Cartridges")

            // Display charts based on the selected cartridge
            UpdateCharts(stats);  // Initially display all stats on the charts
        }


        private void UpdateCharts(List<CartridgeStats> filteredStats)
        {
            // When "All Cartridges" is selected, combine stats
            if (cartridgeDropDown.SelectedItem.ToString() == "All Cartridges")
            {
                var allStats = new CartridgeStats
                {
                    Cartridge = "All Cartridges",  // Label it as "All Cartridges"
                    AvgVelocity = filteredStats.Average(s => s.AvgVelocity),
                    AvgES = filteredStats.Average(s => s.AvgES),
                    AvgSD = filteredStats.Average(s => s.AvgSD),
                    RecipeCount = filteredStats.Sum(s => s.RecipeCount)
                };

                // Display combined stats for all cartridges
                ShowVelocityChart(new List<CartridgeStats> { allStats });
                ShowAvgESChart(new List<CartridgeStats> { allStats });
                ShowAvgSDChart(new List<CartridgeStats> { allStats });
            }
            else
            {
                // Display stats for the selected cartridge
                ShowVelocityChart(filteredStats);
                ShowAvgESChart(filteredStats);
                ShowAvgSDChart(filteredStats);
            }
        }



        private void ShowVelocityChart(List<CartridgeStats> stats)
        {
            chartVelocity.Series.Clear();  // Clear existing chart data
            chartVelocity.ChartAreas.Clear();  // Clear chart areas
            chartVelocity.Titles.Clear();  // Clear chart title

            // Add a new chart area
            chartVelocity.ChartAreas.Add("Main");

            // Create a series for the chart (Bar Chart)
            var series = new Series
            {
                Name = "Velocity",
                ChartType = SeriesChartType.Bar,
                Color = SystemColors.ActiveCaption,  // You can change the color if you like
                Font = new Font("Segoe UI", 10)
            };

            // Add data points for each cartridge to the series
            foreach (var stat in stats)
            {
                series.Points.AddXY(stat.Cartridge, stat.AvgVelocity);  // Add each cartridge and its average velocity
            }

            // Add the series to the chart
            chartVelocity.Series.Add(series);

            // Set the title for the chart
            var title = new Title("Average Velocity per Cartridge")
            {
                Font = new Font("Segoe UI", 14, FontStyle.Bold)  // Set font size to 14 and make it bold
            };
            chartVelocity.Titles.Add(title);
        }

        private void ShowAvgESChart(List<CartridgeStats> stats)
        {
            chartES.Series.Clear();
            chartES.ChartAreas.Clear();
            chartES.Titles.Clear();

            chartES.ChartAreas.Add("Main");

            var series = new Series
            {
                Name = "Average ES",
                ChartType = SeriesChartType.Bar,
                Color = SystemColors.ActiveCaption,
                Font = new Font("Segoe UI", 10)
            };
            foreach (var stat in stats)
            {
                series.Points.AddXY(stat.Cartridge, stat.AvgES);
            }
            chartES.Series.Add(series);

            var title = new Title("Average ES per Cartridge")
            {
                Font = new Font("Segoe UI", 14, FontStyle.Bold)  // Set font size to 14 and make it bold
            };
            chartES.Titles.Add(title);
        }
        private void ShowAvgSDChart(List<CartridgeStats> stats) // Method to show the Average SD chart
        {
            chartSD.Series.Clear();
            chartSD.ChartAreas.Clear();
            chartSD.Titles.Clear();

            chartSD.ChartAreas.Add("Main");

            var series = new Series
            {
                Name = "Average SD",
                ChartType = SeriesChartType.Bar,
                Color = SystemColors.ActiveCaption,
                Font = new Font("Segoe UI", 10)
            };
            foreach (var stat in stats)
            {
                series.Points.AddXY(stat.Cartridge, stat.AvgSD);
            }
            chartSD.Series.Add(series);

            var title = new Title("Average SD per Cartridge")
            {
                Font = new Font("Segoe UI", 14, FontStyle.Bold)  // Set font size to 14 and make it bold
            };
            chartSD.Titles.Add(title);
        }

        private void cartridgeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected cartridge
            string selectedCartridge = cartridgeDropDown.SelectedItem.ToString();

            // Filter the stats based on selected cartridge
            List<CartridgeStats> filteredStats;

            if (selectedCartridge == "All Cartridges")
            {
                filteredStats = stats;  // Show stats for all cartridges
            }
            else
            {
                filteredStats = stats.Where(s => s.Cartridge == selectedCartridge).ToList();  // Filter by selected cartridge
            }

            // Update the charts with the filtered data
            UpdateCharts(filteredStats);
        }

    }
}

