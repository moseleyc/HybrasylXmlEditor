namespace HybrasylXmlEditor.UI
{
    partial class LootTableDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxItemList = new System.Windows.Forms.GroupBox();
            this.labelAttributeRolls = new System.Windows.Forms.Label();
            this.labelAttributeChance = new System.Windows.Forms.Label();
            this.labelGoldMax = new System.Windows.Forms.Label();
            this.labelGoldMin = new System.Windows.Forms.Label();
            this.groupBoxItemListAttributes = new System.Windows.Forms.GroupBox();
            this.dataGridViewItemList = new System.Windows.Forms.DataGridView();
            this.labelItemListAttributeChance = new System.Windows.Forms.Label();
            this.labelItemListAttributeRolls = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewItemListItemVariants = new System.Windows.Forms.DataGridView();
            this.labelItemListItemRow = new System.Windows.Forms.Label();
            this.textBoxItemListRowNumber = new System.Windows.Forms.TextBox();
            this.numericAttributeRolls = new System.Windows.Forms.NumericUpDown();
            this.numericAttributeChance = new System.Windows.Forms.NumericUpDown();
            this.numericGoldMax = new System.Windows.Forms.NumericUpDown();
            this.numericGoldMin = new System.Windows.Forms.NumericUpDown();
            this.numericItemListAttributeChance = new System.Windows.Forms.NumericUpDown();
            this.numericItemListAttributeRolls = new System.Windows.Forms.NumericUpDown();
            this.buttonVariantAdd = new System.Windows.Forms.Button();
            this.buttonVariantEdit = new System.Windows.Forms.Button();
            this.buttonVariantRemove = new System.Windows.Forms.Button();
            this.checkBoxHasItemList = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxItemList.SuspendLayout();
            this.groupBoxItemListAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemListItemVariants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAttributeRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAttributeChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoldMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoldMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemListAttributeChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemListAttributeRolls)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericAttributeChance);
            this.groupBox1.Controls.Add(this.numericAttributeRolls);
            this.groupBox1.Controls.Add(this.labelAttributeChance);
            this.groupBox1.Controls.Add(this.labelAttributeRolls);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loot Table Attributes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericGoldMax);
            this.groupBox2.Controls.Add(this.labelGoldMax);
            this.groupBox2.Controls.Add(this.numericGoldMin);
            this.groupBox2.Controls.Add(this.labelGoldMin);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lootable Gold";
            // 
            // groupBoxItemList
            // 
            this.groupBoxItemList.Controls.Add(this.checkBoxHasItemList);
            this.groupBoxItemList.Controls.Add(this.buttonVariantRemove);
            this.groupBoxItemList.Controls.Add(this.buttonVariantEdit);
            this.groupBoxItemList.Controls.Add(this.buttonVariantAdd);
            this.groupBoxItemList.Controls.Add(this.textBoxItemListRowNumber);
            this.groupBoxItemList.Controls.Add(this.labelItemListItemRow);
            this.groupBoxItemList.Controls.Add(this.dataGridViewItemListItemVariants);
            this.groupBoxItemList.Controls.Add(this.dataGridViewItemList);
            this.groupBoxItemList.Controls.Add(this.groupBoxItemListAttributes);
            this.groupBoxItemList.Location = new System.Drawing.Point(12, 127);
            this.groupBoxItemList.Name = "groupBoxItemList";
            this.groupBoxItemList.Size = new System.Drawing.Size(446, 435);
            this.groupBoxItemList.TabIndex = 2;
            this.groupBoxItemList.TabStop = false;
            this.groupBoxItemList.Text = "Item List";
            // 
            // labelAttributeRolls
            // 
            this.labelAttributeRolls.AutoSize = true;
            this.labelAttributeRolls.Location = new System.Drawing.Point(24, 21);
            this.labelAttributeRolls.Name = "labelAttributeRolls";
            this.labelAttributeRolls.Size = new System.Drawing.Size(33, 13);
            this.labelAttributeRolls.TabIndex = 0;
            this.labelAttributeRolls.Text = "Rolls:";
            // 
            // labelAttributeChance
            // 
            this.labelAttributeChance.AutoSize = true;
            this.labelAttributeChance.Location = new System.Drawing.Point(173, 21);
            this.labelAttributeChance.Name = "labelAttributeChance";
            this.labelAttributeChance.Size = new System.Drawing.Size(47, 13);
            this.labelAttributeChance.TabIndex = 1;
            this.labelAttributeChance.Text = "Chance:";
            // 
            // labelGoldMax
            // 
            this.labelGoldMax.AutoSize = true;
            this.labelGoldMax.Location = new System.Drawing.Point(190, 21);
            this.labelGoldMax.Name = "labelGoldMax";
            this.labelGoldMax.Size = new System.Drawing.Size(30, 13);
            this.labelGoldMax.TabIndex = 3;
            this.labelGoldMax.Text = "Max:";
            // 
            // labelGoldMin
            // 
            this.labelGoldMin.AutoSize = true;
            this.labelGoldMin.Location = new System.Drawing.Point(30, 21);
            this.labelGoldMin.Name = "labelGoldMin";
            this.labelGoldMin.Size = new System.Drawing.Size(27, 13);
            this.labelGoldMin.TabIndex = 2;
            this.labelGoldMin.Text = "Min:";
            // 
            // groupBoxItemListAttributes
            // 
            this.groupBoxItemListAttributes.Controls.Add(this.numericItemListAttributeChance);
            this.groupBoxItemListAttributes.Controls.Add(this.labelItemListAttributeChance);
            this.groupBoxItemListAttributes.Controls.Add(this.numericItemListAttributeRolls);
            this.groupBoxItemListAttributes.Controls.Add(this.labelItemListAttributeRolls);
            this.groupBoxItemListAttributes.Location = new System.Drawing.Point(6, 43);
            this.groupBoxItemListAttributes.Name = "groupBoxItemListAttributes";
            this.groupBoxItemListAttributes.Size = new System.Drawing.Size(347, 51);
            this.groupBoxItemListAttributes.TabIndex = 3;
            this.groupBoxItemListAttributes.TabStop = false;
            this.groupBoxItemListAttributes.Text = "Attributes";
            // 
            // dataGridViewItemList
            // 
            this.dataGridViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemList.Location = new System.Drawing.Point(6, 100);
            this.dataGridViewItemList.Name = "dataGridViewItemList";
            this.dataGridViewItemList.Size = new System.Drawing.Size(346, 150);
            this.dataGridViewItemList.TabIndex = 4;
            this.dataGridViewItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemList_CellClick);
            // 
            // labelItemListAttributeChance
            // 
            this.labelItemListAttributeChance.AutoSize = true;
            this.labelItemListAttributeChance.Location = new System.Drawing.Point(167, 21);
            this.labelItemListAttributeChance.Name = "labelItemListAttributeChance";
            this.labelItemListAttributeChance.Size = new System.Drawing.Size(47, 13);
            this.labelItemListAttributeChance.TabIndex = 5;
            this.labelItemListAttributeChance.Text = "Chance:";
            // 
            // labelItemListAttributeRolls
            // 
            this.labelItemListAttributeRolls.AutoSize = true;
            this.labelItemListAttributeRolls.Location = new System.Drawing.Point(18, 21);
            this.labelItemListAttributeRolls.Name = "labelItemListAttributeRolls";
            this.labelItemListAttributeRolls.Size = new System.Drawing.Size(33, 13);
            this.labelItemListAttributeRolls.TabIndex = 4;
            this.labelItemListAttributeRolls.Text = "Rolls:";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(304, 599);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(385, 599);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItemListItemVariants
            // 
            this.dataGridViewItemListItemVariants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemListItemVariants.Location = new System.Drawing.Point(112, 256);
            this.dataGridViewItemListItemVariants.Name = "dataGridViewItemListItemVariants";
            this.dataGridViewItemListItemVariants.ReadOnly = true;
            this.dataGridViewItemListItemVariants.Size = new System.Drawing.Size(240, 109);
            this.dataGridViewItemListItemVariants.TabIndex = 5;
            // 
            // labelItemListItemRow
            // 
            this.labelItemListItemRow.AutoSize = true;
            this.labelItemListItemRow.Location = new System.Drawing.Point(11, 259);
            this.labelItemListItemRow.Name = "labelItemListItemRow";
            this.labelItemListItemRow.Size = new System.Drawing.Size(55, 13);
            this.labelItemListItemRow.TabIndex = 6;
            this.labelItemListItemRow.Text = "Item Row:";
            // 
            // textBoxItemListRowNumber
            // 
            this.textBoxItemListRowNumber.Location = new System.Drawing.Point(72, 256);
            this.textBoxItemListRowNumber.Name = "textBoxItemListRowNumber";
            this.textBoxItemListRowNumber.ReadOnly = true;
            this.textBoxItemListRowNumber.Size = new System.Drawing.Size(34, 20);
            this.textBoxItemListRowNumber.TabIndex = 5;
            // 
            // numericAttributeRolls
            // 
            this.numericAttributeRolls.Location = new System.Drawing.Point(63, 19);
            this.numericAttributeRolls.Name = "numericAttributeRolls";
            this.numericAttributeRolls.Size = new System.Drawing.Size(98, 20);
            this.numericAttributeRolls.TabIndex = 3;
            // 
            // numericAttributeChance
            // 
            this.numericAttributeChance.Location = new System.Drawing.Point(226, 19);
            this.numericAttributeChance.Name = "numericAttributeChance";
            this.numericAttributeChance.Size = new System.Drawing.Size(98, 20);
            this.numericAttributeChance.TabIndex = 4;
            // 
            // numericGoldMax
            // 
            this.numericGoldMax.Location = new System.Drawing.Point(226, 19);
            this.numericGoldMax.Name = "numericGoldMax";
            this.numericGoldMax.Size = new System.Drawing.Size(98, 20);
            this.numericGoldMax.TabIndex = 6;
            // 
            // numericGoldMin
            // 
            this.numericGoldMin.Location = new System.Drawing.Point(63, 19);
            this.numericGoldMin.Name = "numericGoldMin";
            this.numericGoldMin.Size = new System.Drawing.Size(98, 20);
            this.numericGoldMin.TabIndex = 5;
            // 
            // numericItemListAttributeChance
            // 
            this.numericItemListAttributeChance.Location = new System.Drawing.Point(220, 19);
            this.numericItemListAttributeChance.Name = "numericItemListAttributeChance";
            this.numericItemListAttributeChance.Size = new System.Drawing.Size(98, 20);
            this.numericItemListAttributeChance.TabIndex = 8;
            // 
            // numericItemListAttributeRolls
            // 
            this.numericItemListAttributeRolls.Location = new System.Drawing.Point(57, 19);
            this.numericItemListAttributeRolls.Name = "numericItemListAttributeRolls";
            this.numericItemListAttributeRolls.Size = new System.Drawing.Size(98, 20);
            this.numericItemListAttributeRolls.TabIndex = 7;
            // 
            // buttonVariantAdd
            // 
            this.buttonVariantAdd.Enabled = false;
            this.buttonVariantAdd.Location = new System.Drawing.Point(358, 256);
            this.buttonVariantAdd.Name = "buttonVariantAdd";
            this.buttonVariantAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonVariantAdd.TabIndex = 7;
            this.buttonVariantAdd.Text = "Add";
            this.buttonVariantAdd.UseVisualStyleBackColor = true;
            // 
            // buttonVariantEdit
            // 
            this.buttonVariantEdit.Enabled = false;
            this.buttonVariantEdit.Location = new System.Drawing.Point(358, 285);
            this.buttonVariantEdit.Name = "buttonVariantEdit";
            this.buttonVariantEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonVariantEdit.TabIndex = 8;
            this.buttonVariantEdit.Text = "Edit";
            this.buttonVariantEdit.UseVisualStyleBackColor = true;
            // 
            // buttonVariantRemove
            // 
            this.buttonVariantRemove.Enabled = false;
            this.buttonVariantRemove.Location = new System.Drawing.Point(358, 314);
            this.buttonVariantRemove.Name = "buttonVariantRemove";
            this.buttonVariantRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonVariantRemove.TabIndex = 9;
            this.buttonVariantRemove.Text = "Remove";
            this.buttonVariantRemove.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasItemList
            // 
            this.checkBoxHasItemList.AutoSize = true;
            this.checkBoxHasItemList.Location = new System.Drawing.Point(7, 20);
            this.checkBoxHasItemList.Name = "checkBoxHasItemList";
            this.checkBoxHasItemList.Size = new System.Drawing.Size(93, 17);
            this.checkBoxHasItemList.TabIndex = 10;
            this.checkBoxHasItemList.Text = "Has Item List?";
            this.checkBoxHasItemList.UseVisualStyleBackColor = true;
            this.checkBoxHasItemList.CheckedChanged += new System.EventHandler(this.checkBoxHasItemList_CheckedChanged);
            // 
            // LootTableDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(472, 634);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxItemList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "LootTableDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LootTableDialog";
            this.Load += new System.EventHandler(this.LootTableDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxItemList.ResumeLayout(false);
            this.groupBoxItemList.PerformLayout();
            this.groupBoxItemListAttributes.ResumeLayout(false);
            this.groupBoxItemListAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemListItemVariants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAttributeRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAttributeChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoldMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoldMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemListAttributeChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemListAttributeRolls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxItemList;
        private System.Windows.Forms.Label labelAttributeChance;
        private System.Windows.Forms.Label labelAttributeRolls;
        private System.Windows.Forms.Label labelGoldMax;
        private System.Windows.Forms.Label labelGoldMin;
        private System.Windows.Forms.GroupBox groupBoxItemListAttributes;
        private System.Windows.Forms.DataGridView dataGridViewItemList;
        private System.Windows.Forms.Label labelItemListAttributeChance;
        private System.Windows.Forms.Label labelItemListAttributeRolls;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxItemListRowNumber;
        private System.Windows.Forms.Label labelItemListItemRow;
        private System.Windows.Forms.DataGridView dataGridViewItemListItemVariants;
        private System.Windows.Forms.NumericUpDown numericAttributeChance;
        private System.Windows.Forms.NumericUpDown numericAttributeRolls;
        private System.Windows.Forms.NumericUpDown numericGoldMax;
        private System.Windows.Forms.NumericUpDown numericGoldMin;
        private System.Windows.Forms.NumericUpDown numericItemListAttributeChance;
        private System.Windows.Forms.NumericUpDown numericItemListAttributeRolls;
        private System.Windows.Forms.Button buttonVariantRemove;
        private System.Windows.Forms.Button buttonVariantEdit;
        private System.Windows.Forms.Button buttonVariantAdd;
        private System.Windows.Forms.CheckBox checkBoxHasItemList;
    }
}