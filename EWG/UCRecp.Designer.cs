namespace EWG
{
    partial class UCRecp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRecp));
            BtnAdd = new Button();
            label1 = new Label();
            ComboCat = new ComboBox();
            BtnNew = new Button();
            TxtName = new TextBox();
            TxtPortion = new TextBox();
            Gropubosoadf = new GroupBox();
            DGReceipts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            DGRecpMenu = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addIngredientsToolStripMenuItem = new ToolStripMenuItem();
            BtnClear = new Button();
            BtnContinue = new Button();
            groupBox1 = new GroupBox();
            Gropubosoadf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGReceipts).BeginInit();
            DGRecpMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.Control;
            BtnAdd.Location = new Point(422, 173);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(135, 43);
            BtnAdd.TabIndex = 20;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 114);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 7;
            label1.Text = "g ";
            // 
            // ComboCat
            // 
            ComboCat.FormattingEnabled = true;
            ComboCat.Location = new Point(33, 71);
            ComboCat.Margin = new Padding(4);
            ComboCat.Name = "ComboCat";
            ComboCat.Size = new Size(385, 29);
            ComboCat.TabIndex = 2;
            ComboCat.Text = "Select Categories";
            // 
            // BtnNew
            // 
            BtnNew.BackColor = SystemColors.Control;
            BtnNew.Location = new Point(424, 71);
            BtnNew.Margin = new Padding(4);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(98, 29);
            BtnNew.TabIndex = 6;
            BtnNew.Text = "&New";
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(33, 34);
            TxtName.Margin = new Padding(4);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Name";
            TxtName.Size = new Size(489, 29);
            TxtName.TabIndex = 1;
            // 
            // TxtPortion
            // 
            TxtPortion.Location = new Point(33, 108);
            TxtPortion.Margin = new Padding(4);
            TxtPortion.Name = "TxtPortion";
            TxtPortion.PlaceholderText = "Portion Size";
            TxtPortion.Size = new Size(459, 29);
            TxtPortion.TabIndex = 1;
            // 
            // Gropubosoadf
            // 
            Gropubosoadf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Gropubosoadf.Controls.Add(DGReceipts);
            Gropubosoadf.Location = new Point(565, 4);
            Gropubosoadf.Margin = new Padding(4);
            Gropubosoadf.Name = "Gropubosoadf";
            Gropubosoadf.Padding = new Padding(4);
            Gropubosoadf.Size = new Size(671, 388);
            Gropubosoadf.TabIndex = 23;
            Gropubosoadf.TabStop = false;
            Gropubosoadf.Text = "Receipts";
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGReceipts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DGReceipts.ContextMenuStrip = DGRecpMenu;
            DGReceipts.Dock = DockStyle.Fill;
            DGReceipts.GridColor = SystemColors.ControlDark;
            DGReceipts.Location = new Point(4, 26);
            DGReceipts.Margin = new Padding(4);
            DGReceipts.Name = "DGReceipts";
            DGReceipts.ReadOnly = true;
            DGReceipts.RowHeadersVisible = false;
            DGReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGReceipts.Size = new Size(663, 358);
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
            Column2.HeaderText = "Receipt";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Category";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Portion Size (g)";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
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
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.Control;
            BtnClear.Location = new Point(279, 173);
            BtnClear.Margin = new Padding(4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(135, 43);
            BtnClear.TabIndex = 19;
            BtnClear.Text = "C&lear";
            BtnClear.UseVisualStyleBackColor = false;
            // 
            // BtnContinue
            // 
            BtnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnContinue.BackColor = SystemColors.Control;
            BtnContinue.Location = new Point(1097, 400);
            BtnContinue.Margin = new Padding(4);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.Size = new Size(135, 43);
            BtnContinue.TabIndex = 21;
            BtnContinue.Text = "Conti&nue...";
            BtnContinue.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ComboCat);
            groupBox1.Controls.Add(BtnNew);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(TxtPortion);
            groupBox1.Location = new Point(9, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(548, 161);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receipt Info";
            // 
            // UCRecp
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnAdd);
            Controls.Add(Gropubosoadf);
            Controls.Add(BtnClear);
            Controls.Add(BtnContinue);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UCRecp";
            Size = new Size(1240, 462);
            Load += UCRecp_Load;
            Gropubosoadf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGReceipts).EndInit();
            DGRecpMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Label label1;
        private ComboBox ComboCat;
        private Button BtnNew;
        private TextBox TxtName;
        private TextBox TxtPortion;
        private GroupBox Gropubosoadf;
        private DataGridView DGReceipts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ContextMenuStrip DGRecpMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addIngredientsToolStripMenuItem;
        private Button BtnClear;
        private Button BtnContinue;
        private GroupBox groupBox1;
    }
}
