namespace EWG
{
    partial class UCIngredients
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIngredients));
            TxtPrice = new TextBox();
            TxtSatFat = new TextBox();
            TxtFibre = new TextBox();
            TxtFat = new TextBox();
            Gropubosoadf = new GroupBox();
            DGIngredients = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            DGRecpMenu = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            TxtPotass = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TxtCholes = new TextBox();
            TxtSugar = new TextBox();
            TxtSodium = new TextBox();
            TxtCarbohyd = new TextBox();
            TxtProtein = new TextBox();
            TxtCalories = new TextBox();
            ComboCat = new ComboBox();
            TxtName = new TextBox();
            BtnAdd = new Button();
            BtnClear = new Button();
            TxtSearch = new TextBox();
            Gropubosoadf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGIngredients).BeginInit();
            DGRecpMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(770, 117);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.PlaceholderText = "Price (MMK)";
            TxtPrice.Size = new Size(144, 27);
            TxtPrice.TabIndex = 13;
            // 
            // TxtSatFat
            // 
            TxtSatFat.Location = new Point(620, 82);
            TxtSatFat.Name = "TxtSatFat";
            TxtSatFat.PlaceholderText = "Saturated Fat";
            TxtSatFat.Size = new Size(144, 27);
            TxtSatFat.TabIndex = 7;
            // 
            // TxtFibre
            // 
            TxtFibre.Location = new Point(620, 117);
            TxtFibre.Name = "TxtFibre";
            TxtFibre.PlaceholderText = "Fibre";
            TxtFibre.Size = new Size(144, 27);
            TxtFibre.TabIndex = 12;
            // 
            // TxtFat
            // 
            TxtFat.Location = new Point(467, 82);
            TxtFat.Name = "TxtFat";
            TxtFat.PlaceholderText = "Fat";
            TxtFat.Size = new Size(144, 27);
            TxtFat.TabIndex = 6;
            // 
            // Gropubosoadf
            // 
            Gropubosoadf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Gropubosoadf.Controls.Add(DGIngredients);
            Gropubosoadf.Location = new Point(4, 251);
            Gropubosoadf.Margin = new Padding(4);
            Gropubosoadf.Name = "Gropubosoadf";
            Gropubosoadf.Padding = new Padding(4);
            Gropubosoadf.Size = new Size(1069, 419);
            Gropubosoadf.TabIndex = 12;
            Gropubosoadf.TabStop = false;
            Gropubosoadf.Text = "Ingredients References";
            // 
            // DGIngredients
            // 
            DGIngredients.AllowUserToAddRows = false;
            DGIngredients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            DGIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGIngredients.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGIngredients.Columns.AddRange(new DataGridViewColumn[] { Column1, Column12, Column11, Column2, Column13, Column3, Column4, Column5, Column6, Column14, Column7, Column8, Column9, Column10 });
            DGIngredients.ContextMenuStrip = DGRecpMenu;
            DGIngredients.Dock = DockStyle.Fill;
            DGIngredients.GridColor = SystemColors.ControlDark;
            DGIngredients.Location = new Point(4, 24);
            DGIngredients.Margin = new Padding(4);
            DGIngredients.Name = "DGIngredients";
            DGIngredients.ReadOnly = true;
            DGIngredients.RowHeadersVisible = false;
            DGIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGIngredients.Size = new Size(1061, 391);
            DGIngredients.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 30;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column12.HeaderText = "Name";
            Column12.MinimumWidth = 200;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Category";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Calories";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Carbohydrates";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 110;
            // 
            // Column3
            // 
            Column3.HeaderText = "Sugar";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.HeaderText = "Fat";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Saturated Fat";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.HeaderText = "Protein";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Cholesterol";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 130;
            // 
            // Column7
            // 
            Column7.HeaderText = "Sodium";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Potassium";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Fiber";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Price";
            Column10.MinimumWidth = 100;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // DGRecpMenu
            // 
            DGRecpMenu.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            DGRecpMenu.Name = "DGRecpMenu";
            DGRecpMenu.Size = new Size(108, 48);
            DGRecpMenu.Text = "Menu";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // TxtPotass
            // 
            TxtPotass.Location = new Point(467, 117);
            TxtPotass.Name = "TxtPotass";
            TxtPotass.PlaceholderText = "Potassium";
            TxtPotass.Size = new Size(144, 27);
            TxtPotass.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(TxtSatFat);
            groupBox1.Controls.Add(TxtFibre);
            groupBox1.Controls.Add(TxtFat);
            groupBox1.Controls.Add(TxtCholes);
            groupBox1.Controls.Add(TxtPotass);
            groupBox1.Controls.Add(TxtSugar);
            groupBox1.Controls.Add(TxtSodium);
            groupBox1.Controls.Add(TxtCarbohyd);
            groupBox1.Controls.Add(TxtProtein);
            groupBox1.Controls.Add(TxtCalories);
            groupBox1.Controls.Add(ComboCat);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1069, 189);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredients (per 100 g)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(7, 159);
            label1.Name = "label1";
            label1.Size = new Size(257, 20);
            label1.TabIndex = 8;
            label1.Text = "Default value of all Ingredients is 0.0 .";
            // 
            // TxtCholes
            // 
            TxtCholes.Location = new Point(161, 117);
            TxtCholes.Name = "TxtCholes";
            TxtCholes.PlaceholderText = "Cholesterol";
            TxtCholes.Size = new Size(144, 27);
            TxtCholes.TabIndex = 9;
            // 
            // TxtSugar
            // 
            TxtSugar.Location = new Point(314, 82);
            TxtSugar.Name = "TxtSugar";
            TxtSugar.PlaceholderText = "Sugar";
            TxtSugar.Size = new Size(144, 27);
            TxtSugar.TabIndex = 5;
            // 
            // TxtSodium
            // 
            TxtSodium.Location = new Point(314, 117);
            TxtSodium.Name = "TxtSodium";
            TxtSodium.PlaceholderText = "Sodium";
            TxtSodium.Size = new Size(144, 27);
            TxtSodium.TabIndex = 10;
            // 
            // TxtCarbohyd
            // 
            TxtCarbohyd.Location = new Point(161, 82);
            TxtCarbohyd.Name = "TxtCarbohyd";
            TxtCarbohyd.PlaceholderText = "Carbohydrates";
            TxtCarbohyd.Size = new Size(144, 27);
            TxtCarbohyd.TabIndex = 4;
            // 
            // TxtProtein
            // 
            TxtProtein.Location = new Point(8, 117);
            TxtProtein.Name = "TxtProtein";
            TxtProtein.PlaceholderText = "Protein";
            TxtProtein.Size = new Size(144, 27);
            TxtProtein.TabIndex = 8;
            // 
            // TxtCalories
            // 
            TxtCalories.Location = new Point(8, 82);
            TxtCalories.Name = "TxtCalories";
            TxtCalories.PlaceholderText = "Calories";
            TxtCalories.Size = new Size(144, 27);
            TxtCalories.TabIndex = 3;
            // 
            // ComboCat
            // 
            ComboCat.FormattingEnabled = true;
            ComboCat.Location = new Point(413, 34);
            ComboCat.Margin = new Padding(4);
            ComboCat.Name = "ComboCat";
            ComboCat.Size = new Size(351, 28);
            ComboCat.TabIndex = 2;
            ComboCat.Text = "Select Categories";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(8, 34);
            TxtName.Margin = new Padding(4);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Name";
            TxtName.Size = new Size(397, 27);
            TxtName.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.Control;
            BtnAdd.Location = new Point(151, 201);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(135, 43);
            BtnAdd.TabIndex = 15;
            BtnAdd.Text = "&Save";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.Control;
            BtnClear.Location = new Point(8, 201);
            BtnClear.Margin = new Padding(4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(135, 43);
            BtnClear.TabIndex = 14;
            BtnClear.Text = "C&lear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtSearch.Location = new Point(847, 217);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search Ingredients by name";
            TxtSearch.Size = new Size(222, 27);
            TxtSearch.TabIndex = 16;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // UCIngredients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TxtSearch);
            Controls.Add(Gropubosoadf);
            Controls.Add(groupBox1);
            Controls.Add(BtnAdd);
            Controls.Add(BtnClear);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCIngredients";
            Size = new Size(1081, 674);
            Load += UCIngredients_Load;
            Gropubosoadf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGIngredients).EndInit();
            DGRecpMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtPrice;
        private TextBox TxtSatFat;
        private TextBox TxtFibre;
        private TextBox TxtFat;
        private GroupBox Gropubosoadf;
        private DataGridView DGIngredients;
        private ContextMenuStrip DGRecpMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox TxtPotass;
        private GroupBox groupBox1;
        private TextBox TxtSugar;
        private TextBox TxtSodium;
        private TextBox TxtCarbohyd;
        private TextBox TxtProtein;
        private TextBox TxtCalories;
        private ComboBox ComboCat;
        private TextBox TxtName;
        private Button BtnAdd;
        private Button BtnClear;
        private TextBox TxtSearch;
        private Label label1;
        private TextBox TxtCholes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
