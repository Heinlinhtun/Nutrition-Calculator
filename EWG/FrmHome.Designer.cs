namespace EWG
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            panel1 = new Panel();
            BtnReceipt = new Button();
            BtnIngred = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            PnlContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnReceipt);
            panel1.Controls.Add(BtnIngred);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 571);
            panel1.TabIndex = 0;
            // 
            // BtnReceipt
            // 
            BtnReceipt.BackColor = SystemColors.Control;
            BtnReceipt.Location = new Point(3, 139);
            BtnReceipt.Name = "BtnReceipt";
            BtnReceipt.Size = new Size(181, 50);
            BtnReceipt.TabIndex = 0;
            BtnReceipt.Text = "Receipts";
            BtnReceipt.UseVisualStyleBackColor = false;
            BtnReceipt.Click += BtnReceipt_Click;
            // 
            // BtnIngred
            // 
            BtnIngred.BackColor = SystemColors.Control;
            BtnIngred.Location = new Point(3, 195);
            BtnIngred.Name = "BtnIngred";
            BtnIngred.Size = new Size(181, 50);
            BtnIngred.TabIndex = 1;
            BtnIngred.Text = "Ingredients";
            BtnIngred.UseVisualStyleBackColor = false;
            BtnIngred.Click += BtnIngred_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(187, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 61);
            panel2.TabIndex = 0;
            // 
            // PnlContainer
            // 
            PnlContainer.Dock = DockStyle.Fill;
            PnlContainer.Location = new Point(187, 61);
            PnlContainer.Name = "PnlContainer";
            PnlContainer.Size = new Size(1009, 510);
            PnlContainer.TabIndex = 1;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 571);
            Controls.Add(PnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += FrmHome_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button BtnReceipt;
        private Button BtnIngred;
        private Panel PnlContainer;
    }
}
