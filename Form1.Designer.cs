namespace Local_library
{
    partial class Form1
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
            this.item_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.content_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // item_Panel
            // 
            this.item_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.item_Panel.Location = new System.Drawing.Point(201, 0);
            this.item_Panel.Name = "item_Panel";
            this.item_Panel.Size = new System.Drawing.Size(599, 450);
            this.item_Panel.TabIndex = 0;
            // 
            // content_Panel
            // 
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_Panel.Location = new System.Drawing.Point(0, 0);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(201, 450);
            this.content_Panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content_Panel);
            this.Controls.Add(this.item_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel item_Panel;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
    }
}

