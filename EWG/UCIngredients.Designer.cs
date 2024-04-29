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
            textBox10 = new TextBox();
            TxtSatFat = new TextBox();
            TxtFibre = new TextBox();
            TxtFat = new TextBox();
            Gropubosoadf = new GroupBox();
            DGReceipts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            DGRecpMenu = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addIngredientsToolStripMenuItem = new ToolStripMenuItem();
            TxtPotass = new TextBox();
            groupBox1 = new GroupBox();
            TxtSugar = new TextBox();
            TxtSodium = new TextBox();
            TxtCarbohyd = new TextBox();
            TxtProtein = new TextBox();
            TxtCalories = new TextBox();
            ComboCat = new ComboBox();
            BtnNew = new Button();
            TxtName = new TextBox();
            BtnAdd = new Button();
            BtnClear = new Button();
            TxtSearch = new TextBox();
            Gropubosoadf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGReceipts).BeginInit();
            DGRecpMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox10
            // 
            textBox10.Location = new Point(620, 117);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Price (MMK)";
            textBox10.Size = new Size(144, 27);
            textBox10.TabIndex = 7;
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
            TxtFibre.Location = new Point(467, 117);
            TxtFibre.Name = "TxtFibre";
            TxtFibre.PlaceholderText = "Fibre";
            TxtFibre.Size = new Size(144, 27);
            TxtFibre.TabIndex = 7;
            // 
            // TxtFat
            // 
            TxtFat.Location = new Point(467, 82);
            TxtFat.Name = "TxtFat";
            TxtFat.PlaceholderText = "Fat";
            TxtFat.Size = new Size(144, 27);
            TxtFat.TabIndex = 7;
            // 
            // Gropubosoadf
            // 
            Gropubosoadf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Gropubosoadf.Controls.Add(DGReceipts);
            Gropubosoadf.Location = new Point(4, 266);
            Gropubosoadf.Margin = new Padding(4);
            Gropubosoadf.Name = "Gropubosoadf";
            Gropubosoadf.Padding = new Padding(4);
            Gropubosoadf.Size = new Size(1069, 337);
            Gropubosoadf.TabIndex = 12;
            Gropubosoadf.TabStop = false;
            Gropubosoadf.Text = "Ingredients in details";
            // 
            // DGReceipts
            // 
            DGReceipts.AllowUserToAddRows = false;
            DGReceipts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            DGReceipts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGReceipts.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGReceipts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            DGReceipts.ContextMenuStrip = DGRecpMenu;
            DGReceipts.Dock = DockStyle.Fill;
            DGReceipts.GridColor = SystemColors.ControlDark;
            DGReceipts.Location = new Point(4, 24);
            DGReceipts.Margin = new Padding(4);
            DGReceipts.Name = "DGReceipts";
            DGReceipts.ReadOnly = true;
            DGReceipts.RowHeadersVisible = false;
            DGReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGReceipts.Size = new Size(1061, 309);
            DGReceipts.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "Calories";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
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
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Protein";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
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
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Price";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // DGRecpMenu
            // 
            DGRecpMenu.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, addIngredientsToolStripMenuItem });
            DGRecpMenu.Name = "DGRecpMenu";
            DGRecpMenu.Size = new Size(159, 70);
            DGRecpMenu.Text = "Menu";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(158, 22);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(158, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            // 
            // addIngredientsToolStripMenuItem
            // 
            addIngredientsToolStripMenuItem.Image = (Image)resources.GetObject("addIngredientsToolStripMenuItem.Image");
            addIngredientsToolStripMenuItem.Name = "addIngredientsToolStripMenuItem";
            addIngredientsToolStripMenuItem.Size = new Size(158, 22);
            addIngredientsToolStripMenuItem.Text = "Add Ingredients";
            // 
            // TxtPotass
            // 
            TxtPotass.Location = new Point(314, 117);
            TxtPotass.Name = "TxtPotass";
            TxtPotass.PlaceholderText = "Potassium";
            TxtPotass.Size = new Size(144, 27);
            TxtPotass.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(TxtSatFat);
            groupBox1.Controls.Add(TxtFibre);
            groupBox1.Controls.Add(TxtFat);
            groupBox1.Controls.Add(TxtPotass);
            groupBox1.Controls.Add(TxtSugar);
            groupBox1.Controls.Add(TxtSodium);
            groupBox1.Controls.Add(TxtCarbohyd);
            groupBox1.Controls.Add(TxtProtein);
            groupBox1.Controls.Add(TxtCalories);
            groupBox1.Controls.Add(ComboCat);
            groupBox1.Controls.Add(BtnNew);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1069, 172);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredients (per 100 g)";
            // 
            // TxtSugar
            // 
            TxtSugar.Location = new Point(314, 82);
            TxtSugar.Name = "TxtSugar";
            TxtSugar.PlaceholderText = "Sugar";
            TxtSugar.Size = new Size(144, 27);
            TxtSugar.TabIndex = 7;
            // 
            // TxtSodium
            // 
            TxtSodium.Location = new Point(161, 117);
            TxtSodium.Name = "TxtSodium";
            TxtSodium.PlaceholderText = "Sodium";
            TxtSodium.Size = new Size(144, 27);
            TxtSodium.TabIndex = 7;
            // 
            // TxtCarbohyd
            // 
            TxtCarbohyd.Location = new Point(161, 82);
            TxtCarbohyd.Name = "TxtCarbohyd";
            TxtCarbohyd.PlaceholderText = "Carbohydrates";
            TxtCarbohyd.Size = new Size(144, 27);
            TxtCarbohyd.TabIndex = 7;
            // 
            // TxtProtein
            // 
            TxtProtein.Location = new Point(8, 117);
            TxtProtein.Name = "TxtProtein";
            TxtProtein.PlaceholderText = "Protein";
            TxtProtein.Size = new Size(144, 27);
            TxtProtein.TabIndex = 7;
            // 
            // TxtCalories
            // 
            TxtCalories.Location = new Point(8, 82);
            TxtCalories.Name = "TxtCalories";
            TxtCalories.PlaceholderText = "Calories";
            TxtCalories.Size = new Size(144, 27);
            TxtCalories.TabIndex = 7;
            // 
            // ComboCat
            // 
            ComboCat.FormattingEnabled = true;
            ComboCat.Location = new Point(413, 34);
            ComboCat.Margin = new Padding(4);
            ComboCat.Name = "ComboCat";
            ComboCat.Size = new Size(245, 28);
            ComboCat.TabIndex = 2;
            ComboCat.Text = "Select Categories";
            // 
            // BtnNew
            // 
            BtnNew.BackColor = SystemColors.Control;
            BtnNew.Location = new Point(666, 34);
            BtnNew.Margin = new Padding(4);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(98, 29);
            BtnNew.TabIndex = 6;
            BtnNew.Text = "&New";
            BtnNew.UseVisualStyleBackColor = false;
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
            BtnAdd.Location = new Point(147, 184);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(135, 43);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.Control;
            BtnClear.Location = new Point(4, 184);
            BtnClear.Margin = new Padding(4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(135, 43);
            BtnClear.TabIndex = 10;
            BtnClear.Text = "C&lear";
            BtnClear.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtSearch.Location = new Point(851, 243);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search Ingredients by name";
            TxtSearch.Size = new Size(222, 27);
            TxtSearch.TabIndex = 21;
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
            Size = new Size(1081, 607);
            Gropubosoadf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGReceipts).EndInit();
            DGRecpMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox10;
        private TextBox TxtSatFat;
        private TextBox TxtFibre;
        private TextBox TxtFat;
        private GroupBox Gropubosoadf;
        private DataGridView DGReceipts;
        private ContextMenuStrip DGRecpMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addIngredientsToolStripMenuItem;
        private TextBox TxtPotass;
        private GroupBox groupBox1;
        private TextBox TxtSugar;
        private TextBox TxtSodium;
        private TextBox TxtCarbohyd;
        private TextBox TxtProtein;
        private TextBox TxtCalories;
        private ComboBox ComboCat;
        private Button BtnNew;
        private TextBox TxtName;
        private Button BtnAdd;
        private Button BtnClear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private TextBox TxtSearch;
    }
}
