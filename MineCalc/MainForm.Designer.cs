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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grid_Query = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_Query = new System.Windows.Forms.GroupBox();
            this.group_Recipes = new System.Windows.Forms.GroupBox();
            this.grid_Recipes = new System.Windows.Forms.DataGridView();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_Query = new System.Windows.Forms.TabPage();
            this.group_Calculated = new System.Windows.Forms.GroupBox();
            this.grid_Calculated = new System.Windows.Forms.DataGridView();
            this.group_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.tab_Database = new System.Windows.Forms.TabPage();
            this.group_Items = new System.Windows.Forms.GroupBox();
            this.grid_Items = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Query)).BeginInit();
            this.group_Query.SuspendLayout();
            this.group_Recipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Recipes)).BeginInit();
            this.tabs.SuspendLayout();
            this.tab_Query.SuspendLayout();
            this.group_Calculated.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Calculated)).BeginInit();
            this.group_Controls.SuspendLayout();
            this.tab_Database.SuspendLayout();
            this.group_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Query
            // 
            this.grid_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Query.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Count});
            this.grid_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Query.Location = new System.Drawing.Point(3, 16);
            this.grid_Query.Name = "grid_Query";
            this.grid_Query.Size = new System.Drawing.Size(278, 278);
            this.grid_Query.TabIndex = 0;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 150;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.Width = 50;
            // 
            // group_Query
            // 
            this.group_Query.Controls.Add(this.grid_Query);
            this.group_Query.Dock = System.Windows.Forms.DockStyle.Left;
            this.group_Query.Location = new System.Drawing.Point(0, 0);
            this.group_Query.Name = "group_Query";
            this.group_Query.Size = new System.Drawing.Size(284, 297);
            this.group_Query.TabIndex = 1;
            this.group_Query.TabStop = false;
            this.group_Query.Text = "Desired Result";
            // 
            // group_Recipes
            // 
            this.group_Recipes.Controls.Add(this.grid_Recipes);
            this.group_Recipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_Recipes.Location = new System.Drawing.Point(177, 3);
            this.group_Recipes.Name = "group_Recipes";
            this.group_Recipes.Size = new System.Drawing.Size(965, 322);
            this.group_Recipes.TabIndex = 2;
            this.group_Recipes.TabStop = false;
            this.group_Recipes.Text = "Recipes";
            // 
            // grid_Recipes
            // 
            this.grid_Recipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_Recipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Recipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Recipes.Location = new System.Drawing.Point(3, 16);
            this.grid_Recipes.Name = "grid_Recipes";
            this.grid_Recipes.ReadOnly = true;
            this.grid_Recipes.Size = new System.Drawing.Size(959, 303);
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
            this.tabs.Size = new System.Drawing.Size(1153, 354);
            this.tabs.TabIndex = 4;
            // 
            // tab_Query
            // 
            this.tab_Query.Controls.Add(this.group_Calculated);
            this.tab_Query.Controls.Add(this.group_Query);
            this.tab_Query.Controls.Add(this.group_Controls);
            this.tab_Query.Location = new System.Drawing.Point(4, 22);
            this.tab_Query.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Query.Name = "tab_Query";
            this.tab_Query.Size = new System.Drawing.Size(589, 357);
            this.tab_Query.TabIndex = 0;
            this.tab_Query.Text = "Query";
            this.tab_Query.UseVisualStyleBackColor = true;
            // 
            // group_Calculated
            // 
            this.group_Calculated.Controls.Add(this.grid_Calculated);
            this.group_Calculated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_Calculated.Location = new System.Drawing.Point(284, 0);
            this.group_Calculated.Name = "group_Calculated";
            this.group_Calculated.Size = new System.Drawing.Size(305, 297);
            this.group_Calculated.TabIndex = 2;
            this.group_Calculated.TabStop = false;
            this.group_Calculated.Text = "Calculated Requirements";
            // 
            // grid_Calculated
            // 
            this.grid_Calculated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Calculated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Calculated.Location = new System.Drawing.Point(3, 16);
            this.grid_Calculated.Name = "grid_Calculated";
            this.grid_Calculated.ReadOnly = true;
            this.grid_Calculated.Size = new System.Drawing.Size(299, 278);
            this.grid_Calculated.TabIndex = 1;
            // 
            // group_Controls
            // 
            this.group_Controls.Controls.Add(this.btn_Calculate);
            this.group_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.group_Controls.Location = new System.Drawing.Point(0, 297);
            this.group_Controls.Name = "group_Controls";
            this.group_Controls.Size = new System.Drawing.Size(589, 60);
            this.group_Controls.TabIndex = 4;
            this.group_Controls.TabStop = false;
            this.group_Controls.Text = "Controls";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(248, 19);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 3;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // tab_Database
            // 
            this.tab_Database.Controls.Add(this.group_Recipes);
            this.tab_Database.Controls.Add(this.group_Items);
            this.tab_Database.Location = new System.Drawing.Point(4, 22);
            this.tab_Database.Name = "tab_Database";
            this.tab_Database.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Database.Size = new System.Drawing.Size(1145, 328);
            this.tab_Database.TabIndex = 1;
            this.tab_Database.Text = "Database";
            this.tab_Database.UseVisualStyleBackColor = true;
            // 
            // group_Items
            // 
            this.group_Items.Controls.Add(this.grid_Items);
            this.group_Items.Dock = System.Windows.Forms.DockStyle.Left;
            this.group_Items.Location = new System.Drawing.Point(3, 3);
            this.group_Items.Name = "group_Items";
            this.group_Items.Size = new System.Drawing.Size(174, 322);
            this.group_Items.TabIndex = 4;
            this.group_Items.TabStop = false;
            this.group_Items.Text = "Items";
            // 
            // grid_Items
            // 
            this.grid_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Items.Location = new System.Drawing.Point(3, 16);
            this.grid_Items.Name = "grid_Items";
            this.grid_Items.ReadOnly = true;
            this.grid_Items.Size = new System.Drawing.Size(168, 303);
            this.grid_Items.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 354);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MineCalc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Query)).EndInit();
            this.group_Query.ResumeLayout(false);
            this.group_Recipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Recipes)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tab_Query.ResumeLayout(false);
            this.group_Calculated.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Calculated)).EndInit();
            this.group_Controls.ResumeLayout(false);
            this.tab_Database.ResumeLayout(false);
            this.group_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Query;
        private System.Windows.Forms.GroupBox group_Query;
        private System.Windows.Forms.GroupBox group_Recipes;
        private System.Windows.Forms.DataGridView grid_Recipes;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_Query;
        private System.Windows.Forms.TabPage tab_Database;
        private System.Windows.Forms.GroupBox group_Items;
        private System.Windows.Forms.DataGridView grid_Items;
        private System.Windows.Forms.GroupBox group_Calculated;
        private System.Windows.Forms.DataGridView grid_Calculated;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.GroupBox group_Controls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}