using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Reloading
{
    public partial class StatsControl : UserControl
    {

        private Chart chartVelocity;

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

            // Initialize the chartVelocity control
            chartVelocity = new Chart();
            chartVelocity.Dock = DockStyle.Fill;  // Fills the entire panel or form
            this.Controls.Add(chartVelocity);  // Add chartVelocity to the control collection

            // Now, proceed with data fetching and displaying the chart
            var recipeControl = new RecipesControl();
            var allRecipes = recipeControl.GetRecipeList();  // Fetch the list of recipes
            var stats = CalculateStats(allRecipes);  // Calculate stats
            ShowVelocityChart(stats);  // Display chart
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
                Color = Color.DodgerBlue,  // You can change the color if you like
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
            chartVelocity.Titles.Add("Average Velocity per Cartridge");
        }


    }
}
