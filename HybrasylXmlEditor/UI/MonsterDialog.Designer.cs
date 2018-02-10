namespace HybrasylXmlEditor.UI
{
    partial class MonsterDialog
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSprite = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericSprite = new System.Windows.Forms.NumericUpDown();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.buttonSaveXml = new System.Windows.Forms.Button();
            this.buttonNewXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(35, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(10, 72);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description:";
            // 
            // labelSprite
            // 
            this.labelSprite.AutoSize = true;
            this.labelSprite.Location = new System.Drawing.Point(36, 97);
            this.labelSprite.Name = "labelSprite";
            this.labelSprite.Size = new System.Drawing.Size(37, 13);
            this.labelSprite.TabIndex = 2;
            this.labelSprite.Text = "Sprite:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(79, 69);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(218, 20);
            this.textBoxDescription.TabIndex = 4;
            // 
            // numericSprite
            // 
            this.numericSprite.Location = new System.Drawing.Point(79, 95);
            this.numericSprite.Name = "numericSprite";
            this.numericSprite.Size = new System.Drawing.Size(120, 20);
            this.numericSprite.TabIndex = 5;
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(285, 334);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadXml.TabIndex = 16;
            this.buttonLoadXml.Text = "Load XML";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // buttonSaveXml
            // 
            this.buttonSaveXml.Location = new System.Drawing.Point(204, 334);
            this.buttonSaveXml.Name = "buttonSaveXml";
            this.buttonSaveXml.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveXml.TabIndex = 15;
            this.buttonSaveXml.Text = "Save XML";
            this.buttonSaveXml.UseVisualStyleBackColor = true;
            this.buttonSaveXml.Click += new System.EventHandler(this.buttonSaveXml_Click);
            // 
            // buttonNewXml
            // 
            this.buttonNewXml.Location = new System.Drawing.Point(123, 334);
            this.buttonNewXml.Name = "buttonNewXml";
            this.buttonNewXml.Size = new System.Drawing.Size(75, 23);
            this.buttonNewXml.TabIndex = 14;
            this.buttonNewXml.Text = "New XML";
            this.buttonNewXml.UseVisualStyleBackColor = true;
            this.buttonNewXml.Click += new System.EventHandler(this.buttonNewXml_Click);
            // 
            // MonsterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 369);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.buttonSaveXml);
            this.Controls.Add(this.buttonNewXml);
            this.Controls.Add(this.numericSprite);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSprite);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Name = "MonsterDialog";
            this.Text = "MonsterDialog";
            this.Load += new System.EventHandler(this.MonsterDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSprite;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericSprite;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.Button buttonSaveXml;
        private System.Windows.Forms.Button buttonNewXml;
    }
}