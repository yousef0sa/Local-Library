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
            this.All_subjects_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.content_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_Panel
            // 
            this.item_Panel.AutoScroll = true;
            this.item_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.item_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_Panel.Location = new System.Drawing.Point(201, 0);
            this.item_Panel.Name = "item_Panel";
            this.item_Panel.Size = new System.Drawing.Size(599, 450);
            this.item_Panel.TabIndex = 0;
            this.item_Panel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.item_Panel_Scroll);
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.content_Panel.Controls.Add(this.All_subjects_button);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.content_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content_Panel.Location = new System.Drawing.Point(0, 0);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(201, 450);
            this.content_Panel.TabIndex = 1;
            // 
            // All_subjects_button
            // 
            this.All_subjects_button.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.All_subjects_button.Location = new System.Drawing.Point(3, 3);
            this.All_subjects_button.Name = "All_subjects_button";
            this.All_subjects_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.All_subjects_button.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.All_subjects_button.Size = new System.Drawing.Size(192, 25);
            this.All_subjects_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.All_subjects_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.All_subjects_button.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.All_subjects_button.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.All_subjects_button.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.All_subjects_button.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.All_subjects_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.All_subjects_button.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.All_subjects_button.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.All_subjects_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.All_subjects_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.All_subjects_button.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.All_subjects_button.TabIndex = 1;
            this.All_subjects_button.Values.Text = "All subjects";
            this.All_subjects_button.Click += new System.EventHandler(this.All_subjects_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.item_Panel);
            this.Controls.Add(this.content_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.content_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel item_Panel;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton All_subjects_button;
    }
}

