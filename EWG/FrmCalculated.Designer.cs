namespace EWG
{
    partial class FrmCalculated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculated));
            groupBox1 = new GroupBox();
            DGCalculated = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            BtnClose = new Button();
            BtnExport = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGCalculated).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DGCalculated);
            groupBox1.Location = new Point(7, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 674);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredients";
            // 
            // DGCalculated
            // 
            DGCalculated.AllowUserToAddRows = false;
            DGCalculated.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            DGCalculated.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGCalculated.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGCalculated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGCalculated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGCalculated.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DGCalculated.Dock = DockStyle.Fill;
            DGCalculated.Location = new Point(3, 23);
            DGCalculated.Name = "DGCalculated";
            DGCalculated.ReadOnly = true;
            DGCalculated.RowHeadersVisible = false;
            DGCalculated.Size = new Size(612, 648);
            DGCalculated.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 35;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ration";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cost";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(448, 689);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(177, 43);
            BtnClose.TabIndex = 1;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnExport
            // 
            BtnExport.Location = new Point(254, 689);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(177, 43);
            BtnExport.TabIndex = 1;
            BtnExport.Text = "Export To CSV";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // FrmCalculated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 747);
            Controls.Add(BtnExport);
            Controls.Add(BtnClose);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculated";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculated Result";
            Load += FrmCalculated_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGCalculated).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnClose;
        private Button BtnExport;
        private DataGridView DGCalculated;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}