namespace Local_library.UI
{
    partial class ItemsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.Info_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::Local_library.Properties.Resources.no_image_available;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title_label
            // 
            this.Title_label.AutoEllipsis = true;
            this.Title_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Title_label.Location = new System.Drawing.Point(0, 243);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(178, 17);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Title";
            // 
            // Info_label
            // 
            this.Info_label.AutoEllipsis = true;
            this.Info_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Info_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Info_label.Location = new System.Drawing.Point(0, 260);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(178, 13);
            this.Info_label.TabIndex = 2;
            this.Info_label.Text = "Info";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ItemsForm";
            this.Size = new System.Drawing.Size(178, 281);
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.Click += new System.EventHandler(this.ItemsForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Title_label;
        internal System.Windows.Forms.Label Info_label;
    }
}
