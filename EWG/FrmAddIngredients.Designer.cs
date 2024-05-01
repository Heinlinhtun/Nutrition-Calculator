namespace EWG
{
    partial class FrmAddIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddIngredients));
            TxtRecpName = new TextBox();
            ComboIngre = new ComboBox();
            TxtProp = new TextBox();
            label1 = new Label();
            BtnAdd = new Button();
            BtnCalculate = new Button();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            PnlIngre = new FlowLayoutPanel();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtRecpName
            // 
            TxtRecpName.BackColor = Color.White;
            TxtRecpName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRecpName.Location = new Point(12, 12);
            TxtRecpName.Multiline = true;
            TxtRecpName.Name = "TxtRecpName";
            TxtRecpName.ReadOnly = true;
            TxtRecpName.Size = new Size(862, 68);
            TxtRecpName.TabIndex = 0;
            TxtRecpName.TabStop = false;
            // 
            // ComboIngre
            // 
            ComboIngre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboIngre.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboIngre.FormattingEnabled = true;
            ComboIngre.Location = new Point(13, 95);
            ComboIngre.Name = "ComboIngre";
            ComboIngre.Size = new Size(316, 28);
            ComboIngre.TabIndex = 1;
            ComboIngre.Text = "Choose Ingredients";
            // 
            // TxtProp
            // 
            TxtProp.Location = new Point(348, 96);
            TxtProp.Name = "TxtProp";
            TxtProp.PlaceholderText = "Proportion";
            TxtProp.Size = new Size(130, 27);
            TxtProp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 99);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 3;
            label1.Text = "g";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(508, 95);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(120, 28);
            BtnAdd.TabIndex = 4;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(725, 342);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(149, 35);
            BtnCalculate.TabIndex = 6;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(575, 348);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Save to Database";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PnlIngre);
            groupBox1.Location = new Point(12, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 207);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Included Ingredients";
            // 
            // PnlIngre
            // 
            PnlIngre.Dock = DockStyle.Fill;
            PnlIngre.Location = new Point(3, 23);
            PnlIngre.Name = "PnlIngre";
            PnlIngre.Size = new Size(862, 181);
            PnlIngre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(13, 342);
            label2.Name = "label2";
            label2.Size = new Size(273, 20);
            label2.TabIndex = 9;
            label2.Text = "Click to REMOVE the added ingredients.";
            // 
            // FrmAddIngredients
            // 
            AcceptButton = BtnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 393);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(checkBox1);
            Controls.Add(BtnCalculate);
            Controls.Add(BtnAdd);
            Controls.Add(label1);
            Controls.Add(TxtProp);
            Controls.Add(ComboIngre);
            Controls.Add(TxtRecpName);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddIngredients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Ingredients";
            Load += FrmAddIngredients_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtRecpName;
        private ComboBox ComboIngre;
        private TextBox TxtProp;
        private Label label1;
        private Button BtnAdd;
        private Button BtnCalculate;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private FlowLayoutPanel PnlIngre;
        private Label label2;
    }
}