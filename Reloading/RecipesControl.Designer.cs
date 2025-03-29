namespace Reloading
{
    partial class RecipesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboCartridges = new ComboBox();
            dataGridRecipes = new DataGridView();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRecipes).BeginInit();
            SuspendLayout();
            // 
            // comboCartridges
            // 
            comboCartridges.FormattingEnabled = true;
            comboCartridges.Location = new Point(25, 155);
            comboCartridges.Name = "comboCartridges";
            comboCartridges.Size = new Size(430, 40);
            comboCartridges.TabIndex = 0;
            comboCartridges.SelectedIndexChanged += comboCartridges_SelectedIndexChanged;
            // 
            // dataGridRecipes
            // 
            dataGridRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRecipes.Dock = DockStyle.Bottom;
            dataGridRecipes.Location = new Point(0, 802);
            dataGridRecipes.Name = "dataGridRecipes";
            dataGridRecipes.RowHeadersWidth = 82;
            dataGridRecipes.Size = new Size(2310, 520);
            dataGridRecipes.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.Control;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(243, 78);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Recipes";
            // 
            // RecipesControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            Controls.Add(labelTitle);
            Controls.Add(dataGridRecipes);
            Controls.Add(comboCartridges);
            Name = "RecipesControl";
            Size = new Size(2310, 1322);
            ((System.ComponentModel.ISupportInitialize)dataGridRecipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboCartridges;
        private DataGridView dataGridRecipes;
        private Label labelTitle;
    }
}
