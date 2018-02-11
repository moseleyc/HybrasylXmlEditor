namespace HybrasylXmlEditor.UI
{
    partial class SpawnGroupDialog
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
            this.groupBoxMaps = new System.Windows.Forms.GroupBox();
            this.groupBoxSpawns = new System.Windows.Forms.GroupBox();
            this.dataGridViewMaps = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpawns = new System.Windows.Forms.DataGridView();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.buttonSaveXml = new System.Windows.Forms.Button();
            this.buttonNewXml = new System.Windows.Forms.Button();
            this.buttonAddSpawn = new System.Windows.Forms.Button();
            this.buttonEditSpawn = new System.Windows.Forms.Button();
            this.buttonDeleteSpawn = new System.Windows.Forms.Button();
            this.groupBoxSpawns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpawns)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMaps
            // 
            this.groupBoxMaps.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMaps.Name = "groupBoxMaps";
            this.groupBoxMaps.Size = new System.Drawing.Size(524, 190);
            this.groupBoxMaps.TabIndex = 0;
            this.groupBoxMaps.TabStop = false;
            this.groupBoxMaps.Text = "Maps";
            // 
            // groupBoxSpawns
            // 
            this.groupBoxSpawns.Controls.Add(this.buttonDeleteSpawn);
            this.groupBoxSpawns.Controls.Add(this.buttonEditSpawn);
            this.groupBoxSpawns.Controls.Add(this.buttonAddSpawn);
            this.groupBoxSpawns.Controls.Add(this.dataGridViewSpawns);
            this.groupBoxSpawns.Location = new System.Drawing.Point(12, 208);
            this.groupBoxSpawns.Name = "groupBoxSpawns";
            this.groupBoxSpawns.Size = new System.Drawing.Size(524, 235);
            this.groupBoxSpawns.TabIndex = 1;
            this.groupBoxSpawns.TabStop = false;
            this.groupBoxSpawns.Text = "Spawns";
            // 
            // dataGridViewMaps
            // 
            this.dataGridViewMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaps.Location = new System.Drawing.Point(18, 31);
            this.dataGridViewMaps.Name = "dataGridViewMaps";
            this.dataGridViewMaps.Size = new System.Drawing.Size(512, 150);
            this.dataGridViewMaps.TabIndex = 2;
            // 
            // dataGridViewSpawns
            // 
            this.dataGridViewSpawns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpawns.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewSpawns.Name = "dataGridViewSpawns";
            this.dataGridViewSpawns.Size = new System.Drawing.Size(346, 207);
            this.dataGridViewSpawns.TabIndex = 3;
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(461, 449);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadXml.TabIndex = 16;
            this.buttonLoadXml.Text = "Load XML";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // buttonSaveXml
            // 
            this.buttonSaveXml.Location = new System.Drawing.Point(380, 449);
            this.buttonSaveXml.Name = "buttonSaveXml";
            this.buttonSaveXml.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveXml.TabIndex = 15;
            this.buttonSaveXml.Text = "Save XML";
            this.buttonSaveXml.UseVisualStyleBackColor = true;
            this.buttonSaveXml.Click += new System.EventHandler(this.buttonSaveXml_Click);
            // 
            // buttonNewXml
            // 
            this.buttonNewXml.Location = new System.Drawing.Point(299, 449);
            this.buttonNewXml.Name = "buttonNewXml";
            this.buttonNewXml.Size = new System.Drawing.Size(75, 23);
            this.buttonNewXml.TabIndex = 14;
            this.buttonNewXml.Text = "New XML";
            this.buttonNewXml.UseVisualStyleBackColor = true;
            this.buttonNewXml.Click += new System.EventHandler(this.buttonNewXml_Click);
            // 
            // buttonAddSpawn
            // 
            this.buttonAddSpawn.Location = new System.Drawing.Point(397, 75);
            this.buttonAddSpawn.Name = "buttonAddSpawn";
            this.buttonAddSpawn.Size = new System.Drawing.Size(86, 23);
            this.buttonAddSpawn.TabIndex = 4;
            this.buttonAddSpawn.Text = "Add Spawn";
            this.buttonAddSpawn.UseVisualStyleBackColor = true;
            // 
            // buttonEditSpawn
            // 
            this.buttonEditSpawn.Location = new System.Drawing.Point(397, 104);
            this.buttonEditSpawn.Name = "buttonEditSpawn";
            this.buttonEditSpawn.Size = new System.Drawing.Size(86, 23);
            this.buttonEditSpawn.TabIndex = 5;
            this.buttonEditSpawn.Text = "Edit Spawn";
            this.buttonEditSpawn.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSpawn
            // 
            this.buttonDeleteSpawn.Location = new System.Drawing.Point(397, 133);
            this.buttonDeleteSpawn.Name = "buttonDeleteSpawn";
            this.buttonDeleteSpawn.Size = new System.Drawing.Size(86, 23);
            this.buttonDeleteSpawn.TabIndex = 6;
            this.buttonDeleteSpawn.Text = "Delete Spawn";
            this.buttonDeleteSpawn.UseVisualStyleBackColor = true;
            // 
            // SpawnGroupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 484);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.buttonSaveXml);
            this.Controls.Add(this.buttonNewXml);
            this.Controls.Add(this.dataGridViewMaps);
            this.Controls.Add(this.groupBoxSpawns);
            this.Controls.Add(this.groupBoxMaps);
            this.Name = "SpawnGroupDialog";
            this.Text = "SpawnGroupDialog";
            this.Load += new System.EventHandler(this.SpawnGroupDialog_Load);
            this.groupBoxSpawns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpawns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMaps;
        private System.Windows.Forms.GroupBox groupBoxSpawns;
        private System.Windows.Forms.DataGridView dataGridViewSpawns;
        private System.Windows.Forms.DataGridView dataGridViewMaps;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.Button buttonSaveXml;
        private System.Windows.Forms.Button buttonNewXml;
        private System.Windows.Forms.Button buttonDeleteSpawn;
        private System.Windows.Forms.Button buttonEditSpawn;
        private System.Windows.Forms.Button buttonAddSpawn;
    }
}