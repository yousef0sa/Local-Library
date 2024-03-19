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
            this.Window_Border_panel = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.maximize_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
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
            this.content_Panel.Controls.Add(this.All_subjects_button);
            this.content_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.content_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.content_Panel.Location = new System.Drawing.Point(0, 32);
            this.content_Panel.Name = "content_Panel";
            this.content_Panel.Size = new System.Drawing.Size(201, 408);
            this.content_Panel.TabIndex = 1;
            // 
            // All_subjects_button
            // 
            this.All_subjects_button.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.All_subjects_button.Location = new System.Drawing.Point(3, 3);
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
            this.Window_Border_panel.Controls.Add(this.minimize_button);
            this.Window_Border_panel.Controls.Add(this.maximize_button);
            this.Window_Border_panel.Controls.Add(this.exit_button);
            this.Window_Border_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Window_Border_panel.Location = new System.Drawing.Point(0, 0);
            this.Window_Border_panel.Name = "Window_Border_panel";
            this.Window_Border_panel.Size = new System.Drawing.Size(790, 32);
            this.Window_Border_panel.TabIndex = 0;
            this.Window_Border_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseDown);
            this.Window_Border_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseMove);
            this.Window_Border_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_Border_panel_MouseUp);
            // 
            // minimize_button
            // 
            this.minimize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize_button.Location = new System.Drawing.Point(688, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(34, 32);
            this.minimize_button.TabIndex = 5;
            this.minimize_button.Text = "-";
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // maximize_button
            // 
            this.maximize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_button.FlatAppearance.BorderSize = 0;
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_button.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.maximize_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximize_button.Location = new System.Drawing.Point(722, 0);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(34, 32);
            this.maximize_button.TabIndex = 4;
            this.maximize_button.Text = "#";
            this.maximize_button.UseVisualStyleBackColor = true;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_button.Location = new System.Drawing.Point(756, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(34, 32);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
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
            this.Window_Border_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel item_Panel;
        private System.Windows.Forms.FlowLayoutPanel content_Panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton All_subjects_button;
        private System.Windows.Forms.Panel Window_Border_panel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button maximize_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Panel main_panel;
    }
}

