namespace EWG
{
    partial class FrmAddCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCategory));
            DGCategories = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            TxtCatName = new TextBox();
            ComboCatType = new ComboBox();
            BtnSaveCat = new Button();
            groupBox2 = new GroupBox();
            BtnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)DGCategories).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // DGCategories
            // 
            DGCategories.AllowUserToAddRows = false;
            DGCategories.AllowUserToDeleteRows = false;
            DGCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            DGCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGCategories.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGCategories.Columns.AddRange(new DataGridViewColumn[] { Id, name, Type });
            DGCategories.Dock = DockStyle.Fill;
            DGCategories.GridColor = SystemColors.ControlDark;
            DGCategories.Location = new Point(3, 23);
            DGCategories.MultiSelect = false;
            DGCategories.Name = "DGCategories";
            DGCategories.ReadOnly = true;
            DGCategories.RowHeadersVisible = false;
            DGCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGCategories.Size = new Size(401, 272);
            DGCategories.TabIndex = 9;
            DGCategories.TabStop = false;
            DGCategories.CellClick += DGCategories_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 200;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Category Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // TxtCatName
            // 
            TxtCatName.Location = new Point(12, 12);
            TxtCatName.Name = "TxtCatName";
            TxtCatName.PlaceholderText = "Name";
            TxtCatName.Size = new Size(407, 27);
            TxtCatName.TabIndex = 0;
            // 
            // ComboCatType
            // 
            ComboCatType.FormattingEnabled = true;
            ComboCatType.Items.AddRange(new object[] { "Recipes Category", "Ingredients Category" });
            ComboCatType.Location = new Point(12, 45);
            ComboCatType.Name = "ComboCatType";
            ComboCatType.Size = new Size(407, 28);
            ComboCatType.TabIndex = 1;
            ComboCatType.SelectedIndexChanged += ComboCatType_SelectedIndexChanged;
            // 
            // BtnSaveCat
            // 
            BtnSaveCat.Location = new Point(313, 383);
            BtnSaveCat.Name = "BtnSaveCat";
            BtnSaveCat.Size = new Size(106, 37);
            BtnSaveCat.TabIndex = 2;
            BtnSaveCat.Text = "Save";
            BtnSaveCat.UseVisualStyleBackColor = true;
            BtnSaveCat.Click += BtnSaveCat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(DGCategories);
            groupBox2.Location = new Point(12, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 298);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categories";
            // 
            // BtnDel
            // 
            BtnDel.BackColor = Color.FromArgb(221, 87, 70);
            BtnDel.ForeColor = SystemColors.ButtonHighlight;
            BtnDel.Location = new Point(12, 383);
            BtnDel.Name = "BtnDel";
            BtnDel.Size = new Size(106, 37);
            BtnDel.TabIndex = 2;
            BtnDel.Text = "&Delete";
            BtnDel.UseVisualStyleBackColor = false;
            BtnDel.Click += BtnDel_Click;
            // 
            // FrmAddCategory
            // 
            AcceptButton = BtnSaveCat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 432);
            Controls.Add(groupBox2);
            Controls.Add(BtnDel);
            Controls.Add(BtnSaveCat);
            Controls.Add(ComboCatType);
            Controls.Add(TxtCatName);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Category";
            Load += FrmAddCategory_Load;
            ((System.ComponentModel.ISupportInitialize)DGCategories).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCatName;
        private ComboBox ComboCatType;
        private Button BtnSaveCat;
        private GroupBox groupBox2;
        private DataGridView DGCategories;
        private Button BtnDel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Type;
    }
}