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
            this.control_panel = new System.Windows.Forms.Panel();
            this.Previous_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Search_Page_kryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Next_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Items_label = new System.Windows.Forms.Label();
            this.Pages_label = new System.Windows.Forms.Label();
            this.Settings_panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Change_items_per_page_kryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Change_json_path_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings_kryptonButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Json_path_label = new System.Windows.Forms.Label();
            this.Search_panel = new System.Windows.Forms.Panel();
            this.Window_Border_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.control_panel.SuspendLayout();
            this.Settings_panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Search_panel.SuspendLayout();
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
            this.item_Panel.Size = new System.Drawing.Size(595, 386);
            this.item_Panel.TabIndex = 0;
            // 
            // content_Panel
            // 
            this.content_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.content_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.content_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content_Panel.Location = new System.Drawing.Point(0, 70);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(201, 376);
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
            this.Window_Border_panel.Size = new System.Drawing.Size(796, 32);
            this.Window_Border_panel.TabIndex = 0;
            this.Window_Border_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseDown);
            this.Window_Border_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseMove);
            this.Window_Border_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseUp);
            // 
            // minimize_kryptonButton
            // 
            this.minimize_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.minimize_kryptonButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_kryptonButton.Location = new System.Drawing.Point(694, 0);
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
            this.maximize_kryptonButton.Location = new System.Drawing.Point(728, 0);
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
            this.exit_kryptonButton.Location = new System.Drawing.Point(762, 0);
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
            this.main_panel.Controls.Add(this.Settings_panel);
            this.main_panel.Controls.Add(this.control_panel);
            this.main_panel.Controls.Add(this.content_Panel);
            this.main_panel.Controls.Add(this.Window_Border_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(2, 2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(796, 446);
            this.main_panel.TabIndex = 2;
            // 
            // control_panel
            // 
            this.control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.control_panel.Controls.Add(this.Previous_kryptonButton);
            this.control_panel.Controls.Add(this.Search_Page_kryptonTextBox);
            this.control_panel.Controls.Add(this.Next_kryptonButton);
            this.control_panel.Controls.Add(this.Items_label);
            this.control_panel.Controls.Add(this.Pages_label);
            this.control_panel.Location = new System.Drawing.Point(201, 417);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(595, 29);
            this.control_panel.TabIndex = 5;
            // 
            // Previous_kryptonButton
            // 
            this.Previous_kryptonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Previous_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.Previous_kryptonButton.Location = new System.Drawing.Point(175, 2);
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
            // Search_Page_kryptonTextBox
            // 
            this.Search_Page_kryptonTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_Page_kryptonTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Search_Page_kryptonTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_Page_kryptonTextBox.Location = new System.Drawing.Point(253, 1);
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
            // Next_kryptonButton
            // 
            this.Next_kryptonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Next_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.Next_kryptonButton.Location = new System.Drawing.Point(298, 2);
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
            // Items_label
            // 
            this.Items_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Items_label.AutoSize = true;
            this.Items_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Items_label.Location = new System.Drawing.Point(5, 6);
            this.Items_label.Name = "Items_label";
            this.Items_label.Size = new System.Drawing.Size(45, 17);
            this.Items_label.TabIndex = 3;
            this.Items_label.Text = "Items:";
            // 
            // Pages_label
            // 
            this.Pages_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pages_label.AutoSize = true;
            this.Pages_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Pages_label.Location = new System.Drawing.Point(398, 6);
            this.Pages_label.Name = "Pages_label";
            this.Pages_label.Size = new System.Drawing.Size(47, 17);
            this.Pages_label.TabIndex = 2;
            this.Pages_label.Text = "Pages:";
            // 
            // Settings_panel
            // 
            this.Settings_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Settings_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Settings_panel.Controls.Add(this.groupBox2);
            this.Settings_panel.Controls.Add(this.groupBox1);
            this.Settings_panel.Controls.Add(this.label1);
            this.Settings_panel.Controls.Add(this.Settings_kryptonButton);
            this.Settings_panel.Location = new System.Drawing.Point(0, 297);
            this.Settings_panel.Name = "Settings_panel";
            this.Settings_panel.Size = new System.Drawing.Size(201, 149);
            this.Settings_panel.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.Change_items_per_page_kryptonTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Change_items_per_page_kryptonTextBox
            // 
            this.Change_items_per_page_kryptonTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Change_items_per_page_kryptonTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Change_items_per_page_kryptonTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Change_items_per_page_kryptonTextBox.Location = new System.Drawing.Point(115, 16);
            this.Change_items_per_page_kryptonTextBox.Name = "Change_items_per_page_kryptonTextBox";
            this.Change_items_per_page_kryptonTextBox.Size = new System.Drawing.Size(70, 29);
            this.Change_items_per_page_kryptonTextBox.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.Change_items_per_page_kryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Change_items_per_page_kryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Change_items_per_page_kryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Change_items_per_page_kryptonTextBox.StateCommon.Border.Rounding = 2;
            this.Change_items_per_page_kryptonTextBox.StateCommon.Border.Width = 2;
            this.Change_items_per_page_kryptonTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Change_items_per_page_kryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_items_per_page_kryptonTextBox.TabIndex = 6;
            this.Change_items_per_page_kryptonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Items Per Page:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.Json_path_label);
            this.groupBox1.Controls.Add(this.Change_json_path_kryptonButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Change_json_path_kryptonButton
            // 
            this.Change_json_path_kryptonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Change_json_path_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.Change_json_path_kryptonButton.Location = new System.Drawing.Point(87, 13);
            this.Change_json_path_kryptonButton.Name = "Change_json_path_kryptonButton";
            this.Change_json_path_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Change_json_path_kryptonButton.Size = new System.Drawing.Size(98, 20);
            this.Change_json_path_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Change_json_path_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Change_json_path_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Change_json_path_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Change_json_path_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.Change_json_path_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Change_json_path_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Change_json_path_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.Change_json_path_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Change_json_path_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Change_json_path_kryptonButton.TabIndex = 7;
            this.Change_json_path_kryptonButton.Values.Text = "Change...";
            this.Change_json_path_kryptonButton.Click += new System.EventHandler(this.Change_json_path_kryptonButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "JSON path:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(151, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "V 1.0.0";
            // 
            // Settings_kryptonButton
            // 
            this.Settings_kryptonButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Settings_kryptonButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.Settings_kryptonButton.Location = new System.Drawing.Point(-1, 119);
            this.Settings_kryptonButton.Name = "Settings_kryptonButton";
            this.Settings_kryptonButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Settings_kryptonButton.Size = new System.Drawing.Size(69, 27);
            this.Settings_kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Settings_kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Settings_kryptonButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Settings_kryptonButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Settings_kryptonButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Settings_kryptonButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Settings_kryptonButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Settings_kryptonButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Settings_kryptonButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Settings_kryptonButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.Settings_kryptonButton.TabIndex = 2;
            this.Settings_kryptonButton.Values.Text = "Settings";
            this.Settings_kryptonButton.Click += new System.EventHandler(this.Settings_kryptonButton_Click);
            // 
            // Json_path_label
            // 
            this.Json_path_label.AutoEllipsis = true;
            this.Json_path_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Json_path_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Json_path_label.Location = new System.Drawing.Point(3, 36);
            this.Json_path_label.Name = "Json_path_label";
            this.Json_path_label.Size = new System.Drawing.Size(185, 13);
            this.Json_path_label.TabIndex = 8;
            this.Json_path_label.Text = "P:";
            // 
            // Search_panel
            // 
            this.Search_panel.Controls.Add(this.Search_kryptonTextBox);
            this.Search_panel.Location = new System.Drawing.Point(2, 34);
            this.Search_panel.Name = "Search_panel";
            this.Search_panel.Size = new System.Drawing.Size(200, 34);
            this.Search_panel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_panel);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Window_Border_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            this.Settings_panel.ResumeLayout(false);
            this.Settings_panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Search_panel.ResumeLayout(false);
            this.Search_panel.PerformLayout();
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
        private System.Windows.Forms.Panel Settings_panel;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Settings_kryptonButton;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Change_items_per_page_kryptonTextBox;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Change_json_path_kryptonButton;
        private System.Windows.Forms.Label Json_path_label;
        private System.Windows.Forms.Panel Search_panel;
    }
}

