namespace PluginManager
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_disable = new System.Windows.Forms.Button();
            this.btn_enable = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_reset_formatter = new System.Windows.Forms.Button();
            this.btn_rename = new System.Windows.Forms.Button();
            this.txtBox_rename = new System.Windows.Forms.TextBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.txtbox_nameFormat = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_Toggle_SingleSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            this.tc1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(4, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(137, 235);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(50, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // bs1
            // 
            this.bs1.DataSource = typeof(System.IO.Directory);
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectFolder.Location = new System.Drawing.Point(4, 4);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(137, 31);
            this.btn_selectFolder.TabIndex = 1;
            this.btn_selectFolder.Text = "Select Folder";
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.tabPage1);
            this.tc1.Controls.Add(this.tabPage2);
            this.tc1.HotTrack = true;
            this.tc1.Location = new System.Drawing.Point(146, 4);
            this.tc1.Multiline = true;
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(229, 355);
            this.tc1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_disable);
            this.tabPage1.Controls.Add(this.btn_enable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(221, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plugin Toggler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_disable
            // 
            this.btn_disable.Location = new System.Drawing.Point(11, 75);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(200, 50);
            this.btn_disable.TabIndex = 1;
            this.btn_disable.Text = "Disable";
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // btn_enable
            // 
            this.btn_enable.Location = new System.Drawing.Point(11, 19);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(200, 50);
            this.btn_enable.TabIndex = 0;
            this.btn_enable.Text = "Enable";
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_reset_formatter);
            this.tabPage2.Controls.Add(this.btn_rename);
            this.tabPage2.Controls.Add(this.txtBox_rename);
            this.tabPage2.Controls.Add(this.btn_replace);
            this.tabPage2.Controls.Add(this.txtbox_nameFormat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(221, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plugin FileName Changer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reset_formatter
            // 
            this.btn_reset_formatter.Location = new System.Drawing.Point(124, 48);
            this.btn_reset_formatter.Name = "btn_reset_formatter";
            this.btn_reset_formatter.Size = new System.Drawing.Size(91, 40);
            this.btn_reset_formatter.TabIndex = 4;
            this.btn_reset_formatter.Text = "Reset Default";
            this.btn_reset_formatter.UseVisualStyleBackColor = true;
            this.btn_reset_formatter.Click += new System.EventHandler(this.btn_reset_formatter_Click);
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(15, 283);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(200, 40);
            this.btn_rename.TabIndex = 3;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // txtBox_rename
            // 
            this.txtBox_rename.Location = new System.Drawing.Point(15, 257);
            this.txtBox_rename.Name = "txtBox_rename";
            this.txtBox_rename.Size = new System.Drawing.Size(200, 20);
            this.txtBox_rename.TabIndex = 2;
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(15, 48);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(91, 40);
            this.btn_replace.TabIndex = 1;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // txtbox_nameFormat
            // 
            this.txtbox_nameFormat.Location = new System.Drawing.Point(15, 18);
            this.txtbox_nameFormat.Name = "txtbox_nameFormat";
            this.txtbox_nameFormat.Size = new System.Drawing.Size(200, 20);
            this.txtbox_nameFormat.TabIndex = 0;
            this.txtbox_nameFormat.Text = "(?:\\.)?(?:V)?[-.\\d]+(\\.jar|\\.disabled)";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(3, 41);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 31);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_Toggle_SingleSelect
            // 
            this.btn_Toggle_SingleSelect.Location = new System.Drawing.Point(4, 78);
            this.btn_Toggle_SingleSelect.Name = "btn_Toggle_SingleSelect";
            this.btn_Toggle_SingleSelect.Size = new System.Drawing.Size(136, 41);
            this.btn_Toggle_SingleSelect.TabIndex = 4;
            this.btn_Toggle_SingleSelect.Text = "Multi Select";
            this.btn_Toggle_SingleSelect.UseVisualStyleBackColor = true;
            this.btn_Toggle_SingleSelect.Click += new System.EventHandler(this.btn_Toggle_SingleSelect_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 364);
            this.Controls.Add(this.btn_Toggle_SingleSelect);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tc1);
            this.Controls.Add(this.btn_selectFolder);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.Text = "Plugin Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            this.tc1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.BindingSource bs1;
        private System.Windows.Forms.Button btn_selectFolder;
        protected System.Windows.Forms.FolderBrowserDialog fbd1;
        protected System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.Button btn_enable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbox_nameFormat;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.TextBox txtBox_rename;
        private System.Windows.Forms.Button btn_Toggle_SingleSelect;
        private System.Windows.Forms.Button btn_reset_formatter;



    }
}

