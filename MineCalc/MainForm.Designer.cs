namespace MineCalc
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_Recipe = new System.Windows.Forms.DataGridView();
            this.group_Recipe = new System.Windows.Forms.GroupBox();
            this.group_Recipes = new System.Windows.Forms.GroupBox();
            this.grid_Recipes = new System.Windows.Forms.DataGridView();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_Query = new System.Windows.Forms.TabPage();
            this.tab_Database = new System.Windows.Forms.TabPage();
            this.group_Blocks = new System.Windows.Forms.GroupBox();
            this.grid_Blocks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Recipe)).BeginInit();
            this.group_Recipe.SuspendLayout();
            this.group_Recipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Recipes)).BeginInit();
            this.tabs.SuspendLayout();
            this.tab_Query.SuspendLayout();
            this.tab_Database.SuspendLayout();
            this.group_Blocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Blocks)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Recipe
            // 
            this.grid_Recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Recipe.Location = new System.Drawing.Point(3, 16);
            this.grid_Recipe.Name = "grid_Recipe";
            this.grid_Recipe.Size = new System.Drawing.Size(277, 338);
            this.grid_Recipe.TabIndex = 0;
            // 
            // group_Recipe
            // 
            this.group_Recipe.Controls.Add(this.grid_Recipe);
            this.group_Recipe.Dock = System.Windows.Forms.DockStyle.Left;
            this.group_Recipe.Location = new System.Drawing.Point(0, 0);
            this.group_Recipe.Name = "group_Recipe";
            this.group_Recipe.Size = new System.Drawing.Size(283, 357);
            this.group_Recipe.TabIndex = 1;
            this.group_Recipe.TabStop = false;
            this.group_Recipe.Text = "Recipe";
            // 
            // group_Recipes
            // 
            this.group_Recipes.Controls.Add(this.grid_Recipes);
            this.group_Recipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_Recipes.Location = new System.Drawing.Point(177, 3);
            this.group_Recipes.Name = "group_Recipes";
            this.group_Recipes.Size = new System.Drawing.Size(409, 351);
            this.group_Recipes.TabIndex = 2;
            this.group_Recipes.TabStop = false;
            this.group_Recipes.Text = "Recipes";
            // 
            // grid_Recipes
            // 
            this.grid_Recipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_Recipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Recipes.Location = new System.Drawing.Point(3, 16);
            this.grid_Recipes.Name = "grid_Recipes";
            this.grid_Recipes.ReadOnly = true;
            this.grid_Recipes.Size = new System.Drawing.Size(577, 332);
            this.grid_Recipes.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab_Query);
            this.tabs.Controls.Add(this.tab_Database);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(597, 383);
            this.tabs.TabIndex = 4;
            // 
            // tab_Query
            // 
            this.tab_Query.Controls.Add(this.group_Recipe);
            this.tab_Query.Location = new System.Drawing.Point(4, 22);
            this.tab_Query.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Query.Name = "tab_Query";
            this.tab_Query.Size = new System.Drawing.Size(589, 357);
            this.tab_Query.TabIndex = 0;
            this.tab_Query.Text = "Query";
            this.tab_Query.UseVisualStyleBackColor = true;
            // 
            // tab_Database
            // 
            this.tab_Database.Controls.Add(this.group_Recipes);
            this.tab_Database.Controls.Add(this.group_Blocks);
            this.tab_Database.Location = new System.Drawing.Point(4, 22);
            this.tab_Database.Name = "tab_Database";
            this.tab_Database.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Database.Size = new System.Drawing.Size(589, 357);
            this.tab_Database.TabIndex = 1;
            this.tab_Database.Text = "Database";
            this.tab_Database.UseVisualStyleBackColor = true;
            // 
            // group_Blocks
            // 
            this.group_Blocks.Controls.Add(this.grid_Blocks);
            this.group_Blocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.group_Blocks.Location = new System.Drawing.Point(3, 3);
            this.group_Blocks.Name = "group_Blocks";
            this.group_Blocks.Size = new System.Drawing.Size(174, 351);
            this.group_Blocks.TabIndex = 4;
            this.group_Blocks.TabStop = false;
            this.group_Blocks.Text = "Blocks";
            // 
            // grid_Blocks
            // 
            this.grid_Blocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_Blocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Blocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Blocks.Location = new System.Drawing.Point(3, 16);
            this.grid_Blocks.Name = "grid_Blocks";
            this.grid_Blocks.ReadOnly = true;
            this.grid_Blocks.Size = new System.Drawing.Size(168, 332);
            this.grid_Blocks.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 383);
            this.Controls.Add(this.tabs);
            this.Name = "MainForm";
            this.Text = "MineCalc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Recipe)).EndInit();
            this.group_Recipe.ResumeLayout(false);
            this.group_Recipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Recipes)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tab_Query.ResumeLayout(false);
            this.tab_Database.ResumeLayout(false);
            this.group_Blocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Blocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Recipe;
        private System.Windows.Forms.GroupBox group_Recipe;
        private System.Windows.Forms.GroupBox group_Recipes;
        private System.Windows.Forms.DataGridView grid_Recipes;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_Query;
        private System.Windows.Forms.TabPage tab_Database;
        private System.Windows.Forms.GroupBox group_Blocks;
        private System.Windows.Forms.DataGridView grid_Blocks;
    }
}