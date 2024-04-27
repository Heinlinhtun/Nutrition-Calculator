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
            BtnCancel = new Button();
            BtnContinue = new Button();
            Gropubosoadf = new GroupBox();
            DGReceipts = new DataGridView();
            groupBox1 = new GroupBox();
            ComboCat = new ComboBox();
            BtnNew = new Button();
            TxtName = new TextBox();
            TxtPortion = new TextBox();
            BtnAdd = new Button();
            BtnClear = new Button();
            Gropubosoadf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGReceipts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.BackColor = SystemColors.Control;
            BtnCancel.Location = new Point(795, 504);
            BtnCancel.Margin = new Padding(4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(135, 43);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnContinue
            // 
            BtnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnContinue.BackColor = SystemColors.Control;
            BtnContinue.Location = new Point(938, 504);
            BtnContinue.Margin = new Padding(4);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.Size = new Size(135, 43);
            BtnContinue.TabIndex = 6;
            BtnContinue.Text = "Conti&nue";
            BtnContinue.UseVisualStyleBackColor = false;
            // 
            // Gropubosoadf
            // 
            Gropubosoadf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Gropubosoadf.Controls.Add(DGReceipts);
            Gropubosoadf.Location = new Point(571, 13);
            Gropubosoadf.Margin = new Padding(4);
            Gropubosoadf.Name = "Gropubosoadf";
            Gropubosoadf.Padding = new Padding(4);
            Gropubosoadf.Size = new Size(506, 483);
            Gropubosoadf.TabIndex = 8;
            Gropubosoadf.TabStop = false;
            Gropubosoadf.Text = "Receipts";
            // 
            // DGReceipts
            // 
            DGReceipts.AllowUserToAddRows = false;
            DGReceipts.AllowUserToDeleteRows = false;
            DGReceipts.BackgroundColor = SystemColors.ButtonHighlight;
            DGReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGReceipts.Dock = DockStyle.Fill;
            DGReceipts.Location = new Point(4, 26);
            DGReceipts.Margin = new Padding(4);
            DGReceipts.Name = "DGReceipts";
            DGReceipts.ReadOnly = true;
            DGReceipts.Size = new Size(498, 453);
            DGReceipts.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboCat);
            groupBox1.Controls.Add(BtnNew);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(TxtPortion);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(548, 161);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receipt Info";
            // 
            // ComboCat
            // 
            ComboCat.FormattingEnabled = true;
            ComboCat.Location = new Point(33, 71);
            ComboCat.Margin = new Padding(4);
            ComboCat.Name = "ComboCat";
            ComboCat.Size = new Size(385, 29);
            ComboCat.TabIndex = 2;
            ComboCat.Text = "Categories";
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
            BtnNew.Click += BtnNew_Click;
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
            TxtPortion.Size = new Size(489, 29);
            TxtPortion.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.Control;
            BtnAdd.Location = new Point(417, 173);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(135, 43);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.Control;
            BtnClear.Location = new Point(274, 173);
            BtnClear.Margin = new Padding(4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(135, 43);
            BtnClear.TabIndex = 6;
            BtnClear.Text = "C&lear";
            BtnClear.UseVisualStyleBackColor = false;
            // 
            // UCRecp
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnCancel);
            Controls.Add(BtnClear);
            Controls.Add(BtnAdd);
            Controls.Add(BtnContinue);
            Controls.Add(Gropubosoadf);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UCRecp";
            Size = new Size(1081, 562);
            Load += UCRecp_Load;
            Gropubosoadf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGReceipts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancel;
        private Button BtnContinue;
        private GroupBox Gropubosoadf;
        private DataGridView DGReceipts;
        private GroupBox groupBox1;
        private ComboBox ComboCat;
        private TextBox TxtName;
        private TextBox TxtPortion;
        private Button BtnAdd;
        private Button BtnNew;
        private Button BtnClear;
    }
}
