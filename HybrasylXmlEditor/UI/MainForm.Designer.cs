namespace HybrasylXmlEditor.UI
{
    partial class MainForm
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
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogPreferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileDialogAutoPopulateFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlXmlEditor = new System.Windows.Forms.TabControl();
            this.tabPageStatus = new System.Windows.Forms.TabPage();
            this.tabPageNpc = new System.Windows.Forms.TabPage();
            this.tabPageMonster = new System.Windows.Forms.TabPage();
            this.tabPageSpawnGroup = new System.Windows.Forms.TabPage();
            this.tabPageLootImport = new System.Windows.Forms.TabPage();
            this.MainFormMenuStrip.SuspendLayout();
            this.tabControlXmlEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(902, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDialogPreferenceToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fileDialogPreferenceToolStripMenuItem
            // 
            this.fileDialogPreferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileDialogAutoPopulateFormat});
            this.fileDialogPreferenceToolStripMenuItem.Name = "fileDialogPreferenceToolStripMenuItem";
            this.fileDialogPreferenceToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fileDialogPreferenceToolStripMenuItem.Text = "File Dialog Preference";
            // 
            // toolStripMenuItemFileDialogAutoPopulateFormat
            // 
            this.toolStripMenuItemFileDialogAutoPopulateFormat.Checked = true;
            this.toolStripMenuItemFileDialogAutoPopulateFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFileDialogAutoPopulateFormat.Name = "toolStripMenuItemFileDialogAutoPopulateFormat";
            this.toolStripMenuItemFileDialogAutoPopulateFormat.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemFileDialogAutoPopulateFormat.Text = "Underscore";
            this.toolStripMenuItemFileDialogAutoPopulateFormat.Click += new System.EventHandler(this.toolStripMenuItemFileDialogAutoPopulateFormat_Click);
            // 
            // tabControlXmlEditor
            // 
            this.tabControlXmlEditor.Controls.Add(this.tabPageStatus);
            this.tabControlXmlEditor.Controls.Add(this.tabPageNpc);
            this.tabControlXmlEditor.Controls.Add(this.tabPageMonster);
            this.tabControlXmlEditor.Controls.Add(this.tabPageSpawnGroup);
            this.tabControlXmlEditor.Controls.Add(this.tabPageLootImport);
            this.tabControlXmlEditor.Location = new System.Drawing.Point(0, 28);
            this.tabControlXmlEditor.Name = "tabControlXmlEditor";
            this.tabControlXmlEditor.SelectedIndex = 0;
            this.tabControlXmlEditor.Size = new System.Drawing.Size(900, 930);
            this.tabControlXmlEditor.TabIndex = 1;
            // 
            // tabPageStatus
            // 
            this.tabPageStatus.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatus.Name = "tabPageStatus";
            this.tabPageStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatus.Size = new System.Drawing.Size(892, 904);
            this.tabPageStatus.TabIndex = 0;
            this.tabPageStatus.Text = "Status";
            this.tabPageStatus.UseVisualStyleBackColor = true;
            // 
            // tabPageNpc
            // 
            this.tabPageNpc.Location = new System.Drawing.Point(4, 22);
            this.tabPageNpc.Name = "tabPageNpc";
            this.tabPageNpc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNpc.Size = new System.Drawing.Size(892, 904);
            this.tabPageNpc.TabIndex = 1;
            this.tabPageNpc.Text = "NPC";
            this.tabPageNpc.UseVisualStyleBackColor = true;
            // 
            // tabPageMonster
            // 
            this.tabPageMonster.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonster.Name = "tabPageMonster";
            this.tabPageMonster.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonster.Size = new System.Drawing.Size(892, 904);
            this.tabPageMonster.TabIndex = 2;
            this.tabPageMonster.Text = "Monster";
            this.tabPageMonster.UseVisualStyleBackColor = true;
            // 
            // tabPageSpawnGroup
            // 
            this.tabPageSpawnGroup.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpawnGroup.Name = "tabPageSpawnGroup";
            this.tabPageSpawnGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpawnGroup.Size = new System.Drawing.Size(892, 904);
            this.tabPageSpawnGroup.TabIndex = 3;
            this.tabPageSpawnGroup.Text = "SpawnGroup";
            this.tabPageSpawnGroup.UseVisualStyleBackColor = true;
            // 
            // tabPageLootImport
            // 
            this.tabPageLootImport.Location = new System.Drawing.Point(4, 22);
            this.tabPageLootImport.Name = "tabPageLootImport";
            this.tabPageLootImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLootImport.Size = new System.Drawing.Size(892, 904);
            this.tabPageLootImport.TabIndex = 4;
            this.tabPageLootImport.Text = "Loot Import";
            this.tabPageLootImport.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 959);
            this.Controls.Add(this.tabControlXmlEditor);
            this.Controls.Add(this.MainFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hybrasyl Xml Editor";
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.tabControlXmlEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlXmlEditor;
        private System.Windows.Forms.TabPage tabPageStatus;
        private System.Windows.Forms.TabPage tabPageNpc;
        private System.Windows.Forms.TabPage tabPageMonster;
        private System.Windows.Forms.TabPage tabPageSpawnGroup;
        private System.Windows.Forms.TabPage tabPageLootImport;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDialogPreferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileDialogAutoPopulateFormat;
    }
}

