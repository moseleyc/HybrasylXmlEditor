namespace HybrasylXmlEditor.UI
{
    partial class StatusesDialog
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
            this.labelStatusIcon = new System.Windows.Forms.Label();
            this.buttonLoadStatusXML = new System.Windows.Forms.Button();
            this.textBoxStatusName = new System.Windows.Forms.TextBox();
            this.labelStatusName = new System.Windows.Forms.Label();
            this.labelStatusDuration = new System.Windows.Forms.Label();
            this.labelStatusTick = new System.Windows.Forms.Label();
            this.textBoxStatusScript = new System.Windows.Forms.TextBox();
            this.labelStatusScript = new System.Windows.Forms.Label();
            this.labelStatusProhibitedMsg = new System.Windows.Forms.Label();
            this.textBoxStatusProhibitedMsg = new System.Windows.Forms.TextBox();
            this.labelStatusCategory = new System.Windows.Forms.Label();
            this.textBoxStatusCategory = new System.Windows.Forms.TextBox();
            this.groupBoxStatusAttributes = new System.Windows.Forms.GroupBox();
            this.textBoxStatusTick = new System.Windows.Forms.TextBox();
            this.textBoxStatusDuration = new System.Windows.Forms.TextBox();
            this.textBoxStatusIcon = new System.Windows.Forms.TextBox();
            this.groupBoxEffects = new System.Windows.Forms.GroupBox();
            this.buttonOnRemove = new System.Windows.Forms.Button();
            this.buttonOnTick = new System.Windows.Forms.Button();
            this.buttonOnApply = new System.Windows.Forms.Button();
            this.groupBoxCastRestriction = new System.Windows.Forms.GroupBox();
            this.buttonNewXML = new System.Windows.Forms.Button();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.textBoxCastRestUse = new System.Windows.Forms.TextBox();
            this.textBoxCastRestReceive = new System.Windows.Forms.TextBox();
            this.labelCastRestUse = new System.Windows.Forms.Label();
            this.labelCastRestReceive = new System.Windows.Forms.Label();
            this.groupBoxStatusAttributes.SuspendLayout();
            this.groupBoxEffects.SuspendLayout();
            this.groupBoxCastRestriction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatusIcon
            // 
            this.labelStatusIcon.AutoSize = true;
            this.labelStatusIcon.Location = new System.Drawing.Point(26, 51);
            this.labelStatusIcon.Name = "labelStatusIcon";
            this.labelStatusIcon.Size = new System.Drawing.Size(31, 13);
            this.labelStatusIcon.TabIndex = 7;
            this.labelStatusIcon.Text = "Icon:";
            // 
            // buttonLoadStatusXML
            // 
            this.buttonLoadStatusXML.Location = new System.Drawing.Point(262, 370);
            this.buttonLoadStatusXML.Name = "buttonLoadStatusXML";
            this.buttonLoadStatusXML.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadStatusXML.TabIndex = 8;
            this.buttonLoadStatusXML.Text = "Load XML";
            this.buttonLoadStatusXML.UseVisualStyleBackColor = true;
            this.buttonLoadStatusXML.Click += new System.EventHandler(this.buttonLoadStatusXML_Click);
            // 
            // textBoxStatusName
            // 
            this.textBoxStatusName.Location = new System.Drawing.Point(63, 23);
            this.textBoxStatusName.Name = "textBoxStatusName";
            this.textBoxStatusName.Size = new System.Drawing.Size(215, 20);
            this.textBoxStatusName.TabIndex = 10;
            // 
            // labelStatusName
            // 
            this.labelStatusName.AutoSize = true;
            this.labelStatusName.Location = new System.Drawing.Point(19, 26);
            this.labelStatusName.Name = "labelStatusName";
            this.labelStatusName.Size = new System.Drawing.Size(38, 13);
            this.labelStatusName.TabIndex = 9;
            this.labelStatusName.Text = "Name:";
            // 
            // labelStatusDuration
            // 
            this.labelStatusDuration.AutoSize = true;
            this.labelStatusDuration.Location = new System.Drawing.Point(7, 77);
            this.labelStatusDuration.Name = "labelStatusDuration";
            this.labelStatusDuration.Size = new System.Drawing.Size(50, 13);
            this.labelStatusDuration.TabIndex = 12;
            this.labelStatusDuration.Text = "Duration:";
            // 
            // labelStatusTick
            // 
            this.labelStatusTick.AutoSize = true;
            this.labelStatusTick.Location = new System.Drawing.Point(26, 103);
            this.labelStatusTick.Name = "labelStatusTick";
            this.labelStatusTick.Size = new System.Drawing.Size(31, 13);
            this.labelStatusTick.TabIndex = 14;
            this.labelStatusTick.Text = "Tick:";
            // 
            // textBoxStatusScript
            // 
            this.textBoxStatusScript.Location = new System.Drawing.Point(118, 206);
            this.textBoxStatusScript.Name = "textBoxStatusScript";
            this.textBoxStatusScript.Size = new System.Drawing.Size(215, 20);
            this.textBoxStatusScript.TabIndex = 5;
            // 
            // labelStatusScript
            // 
            this.labelStatusScript.AutoSize = true;
            this.labelStatusScript.Location = new System.Drawing.Point(75, 209);
            this.labelStatusScript.Name = "labelStatusScript";
            this.labelStatusScript.Size = new System.Drawing.Size(37, 13);
            this.labelStatusScript.TabIndex = 4;
            this.labelStatusScript.Text = "Script:";
            // 
            // labelStatusProhibitedMsg
            // 
            this.labelStatusProhibitedMsg.AutoSize = true;
            this.labelStatusProhibitedMsg.Location = new System.Drawing.Point(9, 183);
            this.labelStatusProhibitedMsg.Name = "labelStatusProhibitedMsg";
            this.labelStatusProhibitedMsg.Size = new System.Drawing.Size(103, 13);
            this.labelStatusProhibitedMsg.TabIndex = 2;
            this.labelStatusProhibitedMsg.Text = "Prohibited Message:";
            // 
            // textBoxStatusProhibitedMsg
            // 
            this.textBoxStatusProhibitedMsg.Location = new System.Drawing.Point(118, 180);
            this.textBoxStatusProhibitedMsg.Name = "textBoxStatusProhibitedMsg";
            this.textBoxStatusProhibitedMsg.Size = new System.Drawing.Size(215, 20);
            this.textBoxStatusProhibitedMsg.TabIndex = 3;
            // 
            // labelStatusCategory
            // 
            this.labelStatusCategory.AutoSize = true;
            this.labelStatusCategory.Location = new System.Drawing.Point(60, 157);
            this.labelStatusCategory.Name = "labelStatusCategory";
            this.labelStatusCategory.Size = new System.Drawing.Size(52, 13);
            this.labelStatusCategory.TabIndex = 0;
            this.labelStatusCategory.Text = "Category:";
            // 
            // textBoxStatusCategory
            // 
            this.textBoxStatusCategory.Location = new System.Drawing.Point(118, 154);
            this.textBoxStatusCategory.Name = "textBoxStatusCategory";
            this.textBoxStatusCategory.Size = new System.Drawing.Size(215, 20);
            this.textBoxStatusCategory.TabIndex = 1;
            // 
            // groupBoxStatusAttributes
            // 
            this.groupBoxStatusAttributes.Controls.Add(this.textBoxStatusTick);
            this.groupBoxStatusAttributes.Controls.Add(this.textBoxStatusDuration);
            this.groupBoxStatusAttributes.Controls.Add(this.textBoxStatusIcon);
            this.groupBoxStatusAttributes.Controls.Add(this.labelStatusName);
            this.groupBoxStatusAttributes.Controls.Add(this.labelStatusIcon);
            this.groupBoxStatusAttributes.Controls.Add(this.labelStatusTick);
            this.groupBoxStatusAttributes.Controls.Add(this.textBoxStatusName);
            this.groupBoxStatusAttributes.Controls.Add(this.labelStatusDuration);
            this.groupBoxStatusAttributes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStatusAttributes.Name = "groupBoxStatusAttributes";
            this.groupBoxStatusAttributes.Size = new System.Drawing.Size(321, 136);
            this.groupBoxStatusAttributes.TabIndex = 15;
            this.groupBoxStatusAttributes.TabStop = false;
            this.groupBoxStatusAttributes.Text = "Attributes";
            // 
            // textBoxStatusTick
            // 
            this.textBoxStatusTick.Location = new System.Drawing.Point(63, 100);
            this.textBoxStatusTick.Name = "textBoxStatusTick";
            this.textBoxStatusTick.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatusTick.TabIndex = 17;
            this.textBoxStatusTick.Leave += new System.EventHandler(this.textBoxIntValidation_Leave);
            // 
            // textBoxStatusDuration
            // 
            this.textBoxStatusDuration.Location = new System.Drawing.Point(63, 74);
            this.textBoxStatusDuration.Name = "textBoxStatusDuration";
            this.textBoxStatusDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatusDuration.TabIndex = 16;
            this.textBoxStatusDuration.Leave += new System.EventHandler(this.textBoxIntValidation_Leave);
            // 
            // textBoxStatusIcon
            // 
            this.textBoxStatusIcon.Location = new System.Drawing.Point(63, 48);
            this.textBoxStatusIcon.Name = "textBoxStatusIcon";
            this.textBoxStatusIcon.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatusIcon.TabIndex = 15;
            this.textBoxStatusIcon.Leave += new System.EventHandler(this.textBoxUShortValidation_Leave);
            // 
            // groupBoxEffects
            // 
            this.groupBoxEffects.Controls.Add(this.buttonOnRemove);
            this.groupBoxEffects.Controls.Add(this.buttonOnTick);
            this.groupBoxEffects.Controls.Add(this.buttonOnApply);
            this.groupBoxEffects.Location = new System.Drawing.Point(12, 232);
            this.groupBoxEffects.Name = "groupBoxEffects";
            this.groupBoxEffects.Size = new System.Drawing.Size(321, 48);
            this.groupBoxEffects.TabIndex = 18;
            this.groupBoxEffects.TabStop = false;
            this.groupBoxEffects.Text = "Effects";
            // 
            // buttonOnRemove
            // 
            this.buttonOnRemove.Location = new System.Drawing.Point(238, 19);
            this.buttonOnRemove.Name = "buttonOnRemove";
            this.buttonOnRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonOnRemove.TabIndex = 19;
            this.buttonOnRemove.Text = "OnRemove";
            this.buttonOnRemove.UseVisualStyleBackColor = true;
            this.buttonOnRemove.Click += new System.EventHandler(this.buttonOnRemove_Click);
            // 
            // buttonOnTick
            // 
            this.buttonOnTick.Location = new System.Drawing.Point(121, 19);
            this.buttonOnTick.Name = "buttonOnTick";
            this.buttonOnTick.Size = new System.Drawing.Size(75, 23);
            this.buttonOnTick.TabIndex = 18;
            this.buttonOnTick.Text = "OnTick";
            this.buttonOnTick.UseVisualStyleBackColor = true;
            this.buttonOnTick.Click += new System.EventHandler(this.buttonOnTick_Click);
            // 
            // buttonOnApply
            // 
            this.buttonOnApply.Location = new System.Drawing.Point(4, 19);
            this.buttonOnApply.Name = "buttonOnApply";
            this.buttonOnApply.Size = new System.Drawing.Size(75, 23);
            this.buttonOnApply.TabIndex = 17;
            this.buttonOnApply.Text = "OnApply";
            this.buttonOnApply.UseVisualStyleBackColor = true;
            this.buttonOnApply.Click += new System.EventHandler(this.buttonOnApply_Click);
            // 
            // groupBoxCastRestriction
            // 
            this.groupBoxCastRestriction.Controls.Add(this.labelCastRestReceive);
            this.groupBoxCastRestriction.Controls.Add(this.labelCastRestUse);
            this.groupBoxCastRestriction.Controls.Add(this.textBoxCastRestReceive);
            this.groupBoxCastRestriction.Controls.Add(this.textBoxCastRestUse);
            this.groupBoxCastRestriction.Location = new System.Drawing.Point(16, 286);
            this.groupBoxCastRestriction.Name = "groupBoxCastRestriction";
            this.groupBoxCastRestriction.Size = new System.Drawing.Size(321, 78);
            this.groupBoxCastRestriction.TabIndex = 19;
            this.groupBoxCastRestriction.TabStop = false;
            this.groupBoxCastRestriction.Text = "Cast Restriction";
            // 
            // buttonNewXML
            // 
            this.buttonNewXML.Location = new System.Drawing.Point(100, 370);
            this.buttonNewXML.Name = "buttonNewXML";
            this.buttonNewXML.Size = new System.Drawing.Size(75, 23);
            this.buttonNewXML.TabIndex = 20;
            this.buttonNewXML.Text = "New XML";
            this.buttonNewXML.UseVisualStyleBackColor = true;
            this.buttonNewXML.Click += new System.EventHandler(this.buttonNewXML_Click);
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(181, 370);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveXML.TabIndex = 21;
            this.buttonSaveXML.Text = "Save XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // textBoxCastRestUse
            // 
            this.textBoxCastRestUse.Location = new System.Drawing.Point(62, 19);
            this.textBoxCastRestUse.Name = "textBoxCastRestUse";
            this.textBoxCastRestUse.Size = new System.Drawing.Size(215, 20);
            this.textBoxCastRestUse.TabIndex = 6;
            // 
            // textBoxCastRestReceive
            // 
            this.textBoxCastRestReceive.Location = new System.Drawing.Point(62, 45);
            this.textBoxCastRestReceive.Name = "textBoxCastRestReceive";
            this.textBoxCastRestReceive.Size = new System.Drawing.Size(215, 20);
            this.textBoxCastRestReceive.TabIndex = 7;
            // 
            // labelCastRestUse
            // 
            this.labelCastRestUse.AutoSize = true;
            this.labelCastRestUse.Location = new System.Drawing.Point(27, 22);
            this.labelCastRestUse.Name = "labelCastRestUse";
            this.labelCastRestUse.Size = new System.Drawing.Size(29, 13);
            this.labelCastRestUse.TabIndex = 22;
            this.labelCastRestUse.Text = "Use:";
            // 
            // labelCastRestReceive
            // 
            this.labelCastRestReceive.AutoSize = true;
            this.labelCastRestReceive.Location = new System.Drawing.Point(6, 48);
            this.labelCastRestReceive.Name = "labelCastRestReceive";
            this.labelCastRestReceive.Size = new System.Drawing.Size(50, 13);
            this.labelCastRestReceive.TabIndex = 23;
            this.labelCastRestReceive.Text = "Receive:";
            // 
            // StatusesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 417);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.buttonNewXML);
            this.Controls.Add(this.groupBoxCastRestriction);
            this.Controls.Add(this.groupBoxEffects);
            this.Controls.Add(this.groupBoxStatusAttributes);
            this.Controls.Add(this.buttonLoadStatusXML);
            this.Controls.Add(this.textBoxStatusCategory);
            this.Controls.Add(this.labelStatusCategory);
            this.Controls.Add(this.textBoxStatusProhibitedMsg);
            this.Controls.Add(this.labelStatusProhibitedMsg);
            this.Controls.Add(this.textBoxStatusScript);
            this.Controls.Add(this.labelStatusScript);
            this.Name = "StatusesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statuses Form";
            this.Load += new System.EventHandler(this.StatusesDialog_Load);
            this.groupBoxStatusAttributes.ResumeLayout(false);
            this.groupBoxStatusAttributes.PerformLayout();
            this.groupBoxEffects.ResumeLayout(false);
            this.groupBoxCastRestriction.ResumeLayout(false);
            this.groupBoxCastRestriction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStatusIcon;
        private System.Windows.Forms.Button buttonLoadStatusXML;
        private System.Windows.Forms.TextBox textBoxStatusName;
        private System.Windows.Forms.Label labelStatusName;
        private System.Windows.Forms.Label labelStatusDuration;
        private System.Windows.Forms.Label labelStatusTick;
        private System.Windows.Forms.TextBox textBoxStatusScript;
        private System.Windows.Forms.Label labelStatusScript;
        private System.Windows.Forms.Label labelStatusProhibitedMsg;
        private System.Windows.Forms.TextBox textBoxStatusProhibitedMsg;
        private System.Windows.Forms.Label labelStatusCategory;
        private System.Windows.Forms.TextBox textBoxStatusCategory;
        private System.Windows.Forms.GroupBox groupBoxStatusAttributes;
        private System.Windows.Forms.GroupBox groupBoxEffects;
        private System.Windows.Forms.Button buttonOnApply;
        private System.Windows.Forms.GroupBox groupBoxCastRestriction;
        private System.Windows.Forms.Button buttonOnRemove;
        private System.Windows.Forms.Button buttonOnTick;
        private System.Windows.Forms.Button buttonNewXML;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.TextBox textBoxStatusIcon;
        private System.Windows.Forms.TextBox textBoxStatusTick;
        private System.Windows.Forms.TextBox textBoxStatusDuration;
        private System.Windows.Forms.Label labelCastRestReceive;
        private System.Windows.Forms.Label labelCastRestUse;
        private System.Windows.Forms.TextBox textBoxCastRestReceive;
        private System.Windows.Forms.TextBox textBoxCastRestUse;
    }
}