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
            this.Window_Border_panel = new System.Windows.Forms.Panel();
            this.minimize_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.maximize_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.exit_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Next_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Previous_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Pages_label = new System.Windows.Forms.Label();
            this.Items_label = new System.Windows.Forms.Label();
            this.Search_Page_kryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.content_Panel.SuspendLayout();
            this.Window_Border_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_Panel
            // 
            this.item_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_Panel.AutoScroll = true;
            this.item_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.item_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_Panel.Location = new System.Drawing.Point(201, 32);
            this.item_Panel.Name = "item_Panel";
            this.item_Panel.Size = new System.Drawing.Size(589, 380);
            this.item_Panel.TabIndex = 0;
            // 
            // content_Panel
            // 
            this.content_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.content_Panel.Controls.Add(this.Search_kryptonTextBox);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.content_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content_Panel.Location = new System.Drawing.Point(0, 32);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(201, 408);
            this.content_Panel.TabIndex = 1;
            // 
            // Search_kryptonTextBox
            // 
            this.Search_kryptonTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Search_kryptonTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.main_panel.Controls.Add(this.Search_Page_kryptonTextBox);
            this.main_panel.Controls.Add(this.Items_label);
            this.main_panel.Controls.Add(this.Pages_label);
            this.main_panel.Controls.Add(this.Next_kryptonButton);
            this.main_panel.Controls.Add(this.Previous_kryptonButton);
            this.main_panel.Controls.Add(this.item_Panel);
            this.main_panel.Controls.Add(this.content_Panel);
            this.main_panel.Controls.Add(this.Window_Border_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(5, 5);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(790, 440);
            this.main_panel.TabIndex = 2;
            // 
            // Next_kryptonButton
            // 
            this.Next_kryptonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Next_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.Next_kryptonButton.Location = new System.Drawing.Point(500, 412);
            this.Next_kryptonButton.Name = "Next_kryptonButton";
            this.Next_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Next_kryptonButton.Size = new System.Drawing.Size(81, 25);
            this.Next_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Next_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Next_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Next_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Next_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Next_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Next_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Next_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Next_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Next_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Next_kryptonButton.TabIndex = 1;
            this.Next_kryptonButton.Values.Text = "Next";
            this.Next_kryptonButton.Click += new System.EventHandler(this.Next_kryptonButton_Click);
            // 
            // Previous_kryptonButton
            // 
            this.Previous_kryptonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Previous_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.Previous_kryptonButton.Location = new System.Drawing.Point(377, 412);
            this.Previous_kryptonButton.Name = "Previous_kryptonButton";
            this.Previous_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Previous_kryptonButton.Size = new System.Drawing.Size(81, 25);
            this.Previous_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Previous_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Previous_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Previous_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Previous_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Previous_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Previous_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Previous_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Previous_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Previous_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Previous_kryptonButton.TabIndex = 1;
            this.Previous_kryptonButton.Values.Text = "Previous";
            this.Previous_kryptonButton.Click += new System.EventHandler(this.Previous_kryptonButton_Click);
            // 
            // Pages_label
            // 
            this.Pages_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pages_label.AutoSize = true;
            this.Pages_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Pages_label.Location = new System.Drawing.Point(600, 417);
            this.Pages_label.Name = "Pages_label";
            this.Pages_label.Size = new System.Drawing.Size(47, 17);
            this.Pages_label.TabIndex = 2;
            this.Pages_label.Text = "Pages:";
            // 
            // Items_label
            // 
            this.Items_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Items_label.AutoSize = true;
            this.Items_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Items_label.Location = new System.Drawing.Point(207, 417);
            this.Items_label.Name = "Items_label";
            this.Items_label.Size = new System.Drawing.Size(45, 17);
            this.Items_label.TabIndex = 3;
            this.Items_label.Text = "Items:";
            // 
            // Search_Page_kryptonTextBox
            // 
            this.Search_Page_kryptonTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_Page_kryptonTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Search_Page_kryptonTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_Page_kryptonTextBox.Location = new System.Drawing.Point(455, 412);
            this.Search_Page_kryptonTextBox.Name = "Search_Page_kryptonTextBox";
            this.Search_Page_kryptonTextBox.Size = new System.Drawing.Size(45, 29);
            this.Search_Page_kryptonTextBox.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.Search_Page_kryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Search_Page_kryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Search_Page_kryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Search_Page_kryptonTextBox.StateCommon.Border.Rounding = 2;
            this.Search_Page_kryptonTextBox.StateCommon.Border.Width = 2;
            this.Search_Page_kryptonTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Search_Page_kryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Page_kryptonTextBox.TabIndex = 4;
            this.Search_Page_kryptonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_Page_kryptonTextBox.TextChanged += new System.EventHandler(this.Search_Page_kryptonTextBox_TextChanged);
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
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel item_Panel;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
        private System.Windows.Forms.Panel Window_Border_panel;
        private System.Windows.Forms.Panel main_panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exit_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton maximize_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton minimize_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Search_kryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Previous_kryptonButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Next_kryptonButton;
        private System.Windows.Forms.Label Pages_label;
        private System.Windows.Forms.Label Items_label;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Search_Page_kryptonTextBox;
    }
}

