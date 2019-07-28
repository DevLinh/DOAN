namespace DOAN
{
    partial class Menu
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
            this.menuVertical = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuVertical.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.Teal;
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.Window;
            this.PanelTitle.Controls.Add(this.btnSlide);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(250, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1050, 55);
            this.PanelTitle.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 55);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1050, 595);
            this.panelContainer.TabIndex = 2;
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::DOAN.Properties.Resources.iconfinder_menu_alt;
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(40, 40);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOAN.Properties.Resources.icons8_book_shelf;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuVertical.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel panelContainer;
    }
}

