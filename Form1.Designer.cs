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
            this.Search_kryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.All_subjects_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Window_Border_panel = new System.Windows.Forms.Panel();
            this.minimize_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.maximize_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.exit_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.content_Panel.SuspendLayout();
            this.Window_Border_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_Panel
            // 
            this.item_Panel.AutoScroll = true;
            this.item_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.item_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_Panel.Location = new System.Drawing.Point(201, 32);
            this.item_Panel.Name = "item_Panel";
            this.item_Panel.Size = new System.Drawing.Size(589, 408);
            this.item_Panel.TabIndex = 0;
            this.item_Panel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.item_Panel_Scroll);
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.content_Panel.Controls.Add(this.Search_kryptonTextBox);
            this.content_Panel.Controls.Add(this.All_subjects_button);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.content_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content_Panel.Location = new System.Drawing.Point(0, 32);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(201, 408);
            this.content_Panel.TabIndex = 1;
            // 
            // Search_kryptonTextBox
            // 
            this.Search_kryptonTextBox.Location = new System.Drawing.Point(3, 3);
            this.Search_kryptonTextBox.Name = "Search_kryptonTextBox";
            this.Search_kryptonTextBox.Size = new System.Drawing.Size(192, 29);
            this.Search_kryptonTextBox.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.Search_kryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Search_kryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Search_kryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Search_kryptonTextBox.StateCommon.Border.Rounding = 2;
            this.Search_kryptonTextBox.StateCommon.Border.Width = 2;
            this.Search_kryptonTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Search_kryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_kryptonTextBox.TabIndex = 2;
            this.Search_kryptonTextBox.TextChanged += new System.EventHandler(this.Search_kryptonTextBox_TextChanged);
            // 
            // All_subjects_button
            // 
            this.All_subjects_button.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.All_subjects_button.Location = new System.Drawing.Point(3, 38);
            this.All_subjects_button.Name = "All_subjects_button";
            this.All_subjects_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.All_subjects_button.Size = new System.Drawing.Size(192, 25);
            this.All_subjects_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.All_subjects_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.All_subjects_button.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.All_subjects_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.All_subjects_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.All_subjects_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.All_subjects_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.All_subjects_button.TabIndex = 1;
            this.All_subjects_button.Values.Text = "All subjects";
            this.All_subjects_button.Click += new System.EventHandler(this.All_subjects_button_Click);
            // 
            // Window_Border_panel
            // 
            this.Window_Border_panel.BackColor = System.Drawing.Color.Transparent;
            this.Window_Border_panel.Controls.Add(this.minimize_kryptonButton);
            this.Window_Border_panel.Controls.Add(this.maximize_kryptonButton);
            this.Window_Border_panel.Controls.Add(this.exit_kryptonButton);
            this.Window_Border_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Window_Border_panel.Location = new System.Drawing.Point(0, 0);
            this.Window_Border_panel.Name = "Window_Border_panel";
            this.Window_Border_panel.Size = new System.Drawing.Size(790, 32);
            this.Window_Border_panel.TabIndex = 0;
            this.Window_Border_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseDown);
            this.Window_Border_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseMove);
            this.Window_Border_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseUp);
            // 
            // minimize_kryptonButton
            // 
            this.minimize_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.minimize_kryptonButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_kryptonButton.Location = new System.Drawing.Point(688, 0);
            this.minimize_kryptonButton.Name = "minimize_kryptonButton";
            this.minimize_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.minimize_kryptonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimize_kryptonButton.Size = new System.Drawing.Size(34, 32);
            this.minimize_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.minimize_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.minimize_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.minimize_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.minimize_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.minimize_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.minimize_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.minimize_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.minimize_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.minimize_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.minimize_kryptonButton.TabIndex = 8;
            this.minimize_kryptonButton.Values.Text = "-";
            this.minimize_kryptonButton.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // maximize_kryptonButton
            // 
            this.maximize_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.maximize_kryptonButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_kryptonButton.Location = new System.Drawing.Point(722, 0);
            this.maximize_kryptonButton.Name = "maximize_kryptonButton";
            this.maximize_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.maximize_kryptonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maximize_kryptonButton.Size = new System.Drawing.Size(34, 32);
            this.maximize_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.maximize_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.maximize_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.maximize_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.maximize_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.maximize_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.maximize_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.maximize_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.maximize_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.maximize_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.maximize_kryptonButton.TabIndex = 7;
            this.maximize_kryptonButton.Values.Text = "#";
            this.maximize_kryptonButton.Click += new System.EventHandler(this.maximize_button_Click);
            // 
            // exit_kryptonButton
            // 
            this.exit_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.exit_kryptonButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_kryptonButton.Location = new System.Drawing.Point(756, 0);
            this.exit_kryptonButton.Name = "exit_kryptonButton";
            this.exit_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.exit_kryptonButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit_kryptonButton.Size = new System.Drawing.Size(34, 32);
            this.exit_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.exit_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.exit_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.exit_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.exit_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.exit_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.exit_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.exit_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.exit_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.exit_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.exit_kryptonButton.TabIndex = 6;
            this.exit_kryptonButton.Values.Text = "X";
            this.exit_kryptonButton.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.item_Panel);
            this.main_panel.Controls.Add(this.content_Panel);
            this.main_panel.Controls.Add(this.Window_Border_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(5, 5);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(790, 440);
            this.main_panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.content_Panel.ResumeLayout(false);
            this.content_Panel.PerformLayout();
            this.Window_Border_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel item_Panel;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton All_subjects_button;
        private System.Windows.Forms.Panel Window_Border_panel;
        private System.Windows.Forms.Panel main_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exit_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton maximize_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton minimize_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Search_kryptonTextBox;
    }
}

