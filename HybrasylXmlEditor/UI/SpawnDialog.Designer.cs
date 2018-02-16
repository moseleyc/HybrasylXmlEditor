using Hybrasyl.Creatures;

namespace HybrasylXmlEditor.UI
{
    partial class SpawnDialog
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
            this.labelBase = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.numericVariance = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAttributes = new System.Windows.Forms.GroupBox();
            this.groupBoxScript = new System.Windows.Forms.GroupBox();
            this.checkBoxHasScript = new System.Windows.Forms.CheckBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxScriptType = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxScriptValue = new System.Windows.Forms.TextBox();
            this.groupBoxIntents = new System.Windows.Forms.GroupBox();
            this.groupBoxIntentMonster = new System.Windows.Forms.GroupBox();
            this.labelIntentMonsterType = new System.Windows.Forms.Label();
            this.comboBoxIntentMonsterType = new System.Windows.Forms.ComboBox();
            this.labelIntentMonsterValue = new System.Windows.Forms.Label();
            this.textBoxIntentMonsterValue = new System.Windows.Forms.TextBox();
            this.checkBoxIntentHasMonster = new System.Windows.Forms.CheckBox();
            this.groupBoxIntentPlayer = new System.Windows.Forms.GroupBox();
            this.checkBoxIntentHasPlayer = new System.Windows.Forms.CheckBox();
            this.comboBoxIntentPlayerType = new System.Windows.Forms.ComboBox();
            this.textBoxIntentPlayerValue = new System.Windows.Forms.TextBox();
            this.labelIntentPlayerValue = new System.Windows.Forms.Label();
            this.labelIntentPlayerType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIntentHasNpc = new System.Windows.Forms.CheckBox();
            this.comboBoxIntentNpcType = new System.Windows.Forms.ComboBox();
            this.textBoxIntentNpcValue = new System.Windows.Forms.TextBox();
            this.labelIntentNpcValue = new System.Windows.Forms.Label();
            this.labelIntentNpcType = new System.Windows.Forms.Label();
            this.checkBoxHasIntents = new System.Windows.Forms.CheckBox();
            this.groupBoxRespawn = new System.Windows.Forms.GroupBox();
            this.labelRespawnMax = new System.Windows.Forms.Label();
            this.numericRespawnMax = new System.Windows.Forms.NumericUpDown();
            this.labelRespawnMin = new System.Windows.Forms.Label();
            this.numericRespawnMin = new System.Windows.Forms.NumericUpDown();
            this.labelRespawnPercentage = new System.Windows.Forms.Label();
            this.numericRespawnPercentage = new System.Windows.Forms.NumericUpDown();
            this.labelRespawnInterval = new System.Windows.Forms.Label();
            this.numericRespawnInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDamage = new System.Windows.Forms.GroupBox();
            this.labelDamageElements = new System.Windows.Forms.Label();
            this.listBoxDamageElements = new System.Windows.Forms.ListBox();
            this.labelDamageType = new System.Windows.Forms.Label();
            this.comboBoxDamageType = new System.Windows.Forms.ComboBox();
            this.labelDamageHit = new System.Windows.Forms.Label();
            this.numericDamageHit = new System.Windows.Forms.NumericUpDown();
            this.labelDamageDmg = new System.Windows.Forms.Label();
            this.numericDamageDmg = new System.Windows.Forms.NumericUpDown();
            this.labelDamageMin = new System.Windows.Forms.Label();
            this.numericDamageMin = new System.Windows.Forms.NumericUpDown();
            this.labelDamageMax = new System.Windows.Forms.Label();
            this.numericDamageMax = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDefense = new System.Windows.Forms.GroupBox();
            this.labelDefenseRegen = new System.Windows.Forms.Label();
            this.numericDefenseRegen = new System.Windows.Forms.NumericUpDown();
            this.labelDefenseMr = new System.Windows.Forms.Label();
            this.numericDefenseMr = new System.Windows.Forms.NumericUpDown();
            this.labelDefenseAc = new System.Windows.Forms.Label();
            this.numericDefenseAc = new System.Windows.Forms.NumericUpDown();
            this.labelDefenseElements = new System.Windows.Forms.Label();
            this.listBoxDefenseElements = new System.Windows.Forms.ListBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.labelStatsDex = new System.Windows.Forms.Label();
            this.numericStatsDex = new System.Windows.Forms.NumericUpDown();
            this.labelStatsCon = new System.Windows.Forms.Label();
            this.numericStatsCon = new System.Windows.Forms.NumericUpDown();
            this.labelStatsInt = new System.Windows.Forms.Label();
            this.numericStatsInt = new System.Windows.Forms.NumericUpDown();
            this.labelStatsWis = new System.Windows.Forms.Label();
            this.numericStatsWis = new System.Windows.Forms.NumericUpDown();
            this.labelStatsStr = new System.Windows.Forms.Label();
            this.numericStatsStr = new System.Windows.Forms.NumericUpDown();
            this.labelStatsLevel = new System.Windows.Forms.Label();
            this.numericStatsLevel = new System.Windows.Forms.NumericUpDown();
            this.labelStatsHp = new System.Windows.Forms.Label();
            this.numericStatsHp = new System.Windows.Forms.NumericUpDown();
            this.labelStatsMp = new System.Windows.Forms.Label();
            this.numericStatsMp = new System.Windows.Forms.NumericUpDown();
            this.groupBoxLootList = new System.Windows.Forms.GroupBox();
            this.checkBoxHasLootTable = new System.Windows.Forms.CheckBox();
            this.checkBoxHasLootImport = new System.Windows.Forms.CheckBox();
            this.labelLootImport = new System.Windows.Forms.Label();
            this.groupBoxLootGold = new System.Windows.Forms.GroupBox();
            this.labelLootGoldMax = new System.Windows.Forms.Label();
            this.numericLootGoldMax = new System.Windows.Forms.NumericUpDown();
            this.labelLootGoldMin = new System.Windows.Forms.Label();
            this.numericLootGoldMin = new System.Windows.Forms.NumericUpDown();
            this.groupBoxLootXP = new System.Windows.Forms.GroupBox();
            this.labelLootXpMax = new System.Windows.Forms.Label();
            this.numericLootXpMin = new System.Windows.Forms.NumericUpDown();
            this.numericLootXpMax = new System.Windows.Forms.NumericUpDown();
            this.labelLootXpMin = new System.Windows.Forms.Label();
            this.dataGridViewLootImport = new System.Windows.Forms.DataGridView();
            this.groupBoxCastables = new System.Windows.Forms.GroupBox();
            this.checkBoxHasCastables = new System.Windows.Forms.CheckBox();
            this.dataGridViewCastables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericVariance)).BeginInit();
            this.groupBoxAttributes.SuspendLayout();
            this.groupBoxScript.SuspendLayout();
            this.groupBoxIntents.SuspendLayout();
            this.groupBoxIntentMonster.SuspendLayout();
            this.groupBoxIntentPlayer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRespawn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnInterval)).BeginInit();
            this.groupBoxDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageMax)).BeginInit();
            this.groupBoxDefense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefenseRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefenseMr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefenseAc)).BeginInit();
            this.groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsMp)).BeginInit();
            this.groupBoxLootList.SuspendLayout();
            this.groupBoxLootGold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootGoldMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootGoldMin)).BeginInit();
            this.groupBoxLootXP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootXpMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootXpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLootImport)).BeginInit();
            this.groupBoxCastables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCastables)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(6, 22);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(34, 13);
            this.labelBase.TabIndex = 0;
            this.labelBase.Text = "Base:";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(152, 22);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(52, 13);
            this.labelVariance.TabIndex = 1;
            this.labelVariance.Text = "Variance:";
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(46, 19);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxBase.TabIndex = 2;
            // 
            // numericVariance
            // 
            this.numericVariance.DecimalPlaces = 2;
            this.numericVariance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericVariance.Location = new System.Drawing.Point(210, 20);
            this.numericVariance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVariance.Name = "numericVariance";
            this.numericVariance.Size = new System.Drawing.Size(120, 20);
            this.numericVariance.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(688, 752);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(769, 752);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttributes
            // 
            this.groupBoxAttributes.Controls.Add(this.labelBase);
            this.groupBoxAttributes.Controls.Add(this.labelVariance);
            this.groupBoxAttributes.Controls.Add(this.textBoxBase);
            this.groupBoxAttributes.Controls.Add(this.numericVariance);
            this.groupBoxAttributes.Location = new System.Drawing.Point(6, 12);
            this.groupBoxAttributes.Name = "groupBoxAttributes";
            this.groupBoxAttributes.Size = new System.Drawing.Size(431, 55);
            this.groupBoxAttributes.TabIndex = 6;
            this.groupBoxAttributes.TabStop = false;
            this.groupBoxAttributes.Text = "Attributes";
            // 
            // groupBoxScript
            // 
            this.groupBoxScript.Controls.Add(this.checkBoxHasScript);
            this.groupBoxScript.Controls.Add(this.labelType);
            this.groupBoxScript.Controls.Add(this.comboBoxScriptType);
            this.groupBoxScript.Controls.Add(this.labelValue);
            this.groupBoxScript.Controls.Add(this.textBoxScriptValue);
            this.groupBoxScript.Location = new System.Drawing.Point(6, 73);
            this.groupBoxScript.Name = "groupBoxScript";
            this.groupBoxScript.Size = new System.Drawing.Size(431, 74);
            this.groupBoxScript.TabIndex = 7;
            this.groupBoxScript.TabStop = false;
            this.groupBoxScript.Text = "Script";
            // 
            // checkBoxHasScript
            // 
            this.checkBoxHasScript.AutoSize = true;
            this.checkBoxHasScript.Location = new System.Drawing.Point(9, 19);
            this.checkBoxHasScript.Name = "checkBoxHasScript";
            this.checkBoxHasScript.Size = new System.Drawing.Size(81, 17);
            this.checkBoxHasScript.TabIndex = 8;
            this.checkBoxHasScript.Text = "Has Script?";
            this.checkBoxHasScript.UseVisualStyleBackColor = true;
            this.checkBoxHasScript.CheckedChanged += new System.EventHandler(this.checkBoxHasScript_CheckedChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(166, 44);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Type:";
            // 
            // comboBoxScriptType
            // 
            this.comboBoxScriptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScriptType.Enabled = false;
            this.comboBoxScriptType.FormattingEnabled = true;
            this.comboBoxScriptType.Items.AddRange(new object[] {
            Hybrasyl.Creatures.ScriptType.Override,
            Hybrasyl.Creatures.ScriptType.Supplement});
            this.comboBoxScriptType.Location = new System.Drawing.Point(209, 41);
            this.comboBoxScriptType.Name = "comboBoxScriptType";
            this.comboBoxScriptType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScriptType.TabIndex = 6;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(3, 45);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(37, 13);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Value:";
            // 
            // textBoxScriptValue
            // 
            this.textBoxScriptValue.Location = new System.Drawing.Point(46, 42);
            this.textBoxScriptValue.Name = "textBoxScriptValue";
            this.textBoxScriptValue.ReadOnly = true;
            this.textBoxScriptValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxScriptValue.TabIndex = 5;
            // 
            // groupBoxIntents
            // 
            this.groupBoxIntents.Controls.Add(this.groupBoxIntentMonster);
            this.groupBoxIntents.Controls.Add(this.groupBoxIntentPlayer);
            this.groupBoxIntents.Controls.Add(this.groupBox1);
            this.groupBoxIntents.Controls.Add(this.checkBoxHasIntents);
            this.groupBoxIntents.Location = new System.Drawing.Point(6, 153);
            this.groupBoxIntents.Name = "groupBoxIntents";
            this.groupBoxIntents.Size = new System.Drawing.Size(431, 211);
            this.groupBoxIntents.TabIndex = 8;
            this.groupBoxIntents.TabStop = false;
            this.groupBoxIntents.Text = "Intents";
            // 
            // groupBoxIntentMonster
            // 
            this.groupBoxIntentMonster.Controls.Add(this.labelIntentMonsterType);
            this.groupBoxIntentMonster.Controls.Add(this.comboBoxIntentMonsterType);
            this.groupBoxIntentMonster.Controls.Add(this.labelIntentMonsterValue);
            this.groupBoxIntentMonster.Controls.Add(this.textBoxIntentMonsterValue);
            this.groupBoxIntentMonster.Controls.Add(this.checkBoxIntentHasMonster);
            this.groupBoxIntentMonster.Location = new System.Drawing.Point(9, 147);
            this.groupBoxIntentMonster.Name = "groupBoxIntentMonster";
            this.groupBoxIntentMonster.Size = new System.Drawing.Size(411, 55);
            this.groupBoxIntentMonster.TabIndex = 23;
            this.groupBoxIntentMonster.TabStop = false;
            this.groupBoxIntentMonster.Text = "Monster";
            // 
            // labelIntentMonsterType
            // 
            this.labelIntentMonsterType.AutoSize = true;
            this.labelIntentMonsterType.Location = new System.Drawing.Point(239, 20);
            this.labelIntentMonsterType.Name = "labelIntentMonsterType";
            this.labelIntentMonsterType.Size = new System.Drawing.Size(34, 13);
            this.labelIntentMonsterType.TabIndex = 25;
            this.labelIntentMonsterType.Text = "Type:";
            // 
            // comboBoxIntentMonsterType
            // 
            this.comboBoxIntentMonsterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIntentMonsterType.Enabled = false;
            this.comboBoxIntentMonsterType.FormattingEnabled = true;
            this.comboBoxIntentMonsterType.Items.AddRange(new object[] {
            Hybrasyl.Creatures.IntentType.Hostile,
            Hybrasyl.Creatures.IntentType.Passive,
            Hybrasyl.Creatures.IntentType.Neutral});
            this.comboBoxIntentMonsterType.Location = new System.Drawing.Point(282, 17);
            this.comboBoxIntentMonsterType.Name = "comboBoxIntentMonsterType";
            this.comboBoxIntentMonsterType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIntentMonsterType.TabIndex = 24;
            // 
            // labelIntentMonsterValue
            // 
            this.labelIntentMonsterValue.AutoSize = true;
            this.labelIntentMonsterValue.Location = new System.Drawing.Point(76, 21);
            this.labelIntentMonsterValue.Name = "labelIntentMonsterValue";
            this.labelIntentMonsterValue.Size = new System.Drawing.Size(37, 13);
            this.labelIntentMonsterValue.TabIndex = 22;
            this.labelIntentMonsterValue.Text = "Value:";
            // 
            // textBoxIntentMonsterValue
            // 
            this.textBoxIntentMonsterValue.Location = new System.Drawing.Point(119, 18);
            this.textBoxIntentMonsterValue.Name = "textBoxIntentMonsterValue";
            this.textBoxIntentMonsterValue.ReadOnly = true;
            this.textBoxIntentMonsterValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntentMonsterValue.TabIndex = 23;
            // 
            // checkBoxIntentHasMonster
            // 
            this.checkBoxIntentHasMonster.AutoSize = true;
            this.checkBoxIntentHasMonster.Location = new System.Drawing.Point(6, 19);
            this.checkBoxIntentHasMonster.Name = "checkBoxIntentHasMonster";
            this.checkBoxIntentHasMonster.Size = new System.Drawing.Size(70, 17);
            this.checkBoxIntentHasMonster.TabIndex = 21;
            this.checkBoxIntentHasMonster.Text = "Monster?";
            this.checkBoxIntentHasMonster.UseVisualStyleBackColor = true;
            this.checkBoxIntentHasMonster.CheckedChanged += new System.EventHandler(this.checkBoxIntentHasMonster_CheckedChanged);
            // 
            // groupBoxIntentPlayer
            // 
            this.groupBoxIntentPlayer.Controls.Add(this.checkBoxIntentHasPlayer);
            this.groupBoxIntentPlayer.Controls.Add(this.comboBoxIntentPlayerType);
            this.groupBoxIntentPlayer.Controls.Add(this.textBoxIntentPlayerValue);
            this.groupBoxIntentPlayer.Controls.Add(this.labelIntentPlayerValue);
            this.groupBoxIntentPlayer.Controls.Add(this.labelIntentPlayerType);
            this.groupBoxIntentPlayer.Location = new System.Drawing.Point(9, 93);
            this.groupBoxIntentPlayer.Name = "groupBoxIntentPlayer";
            this.groupBoxIntentPlayer.Size = new System.Drawing.Size(411, 48);
            this.groupBoxIntentPlayer.TabIndex = 22;
            this.groupBoxIntentPlayer.TabStop = false;
            this.groupBoxIntentPlayer.Text = "Player";
            // 
            // checkBoxIntentHasPlayer
            // 
            this.checkBoxIntentHasPlayer.AutoSize = true;
            this.checkBoxIntentHasPlayer.Location = new System.Drawing.Point(6, 19);
            this.checkBoxIntentHasPlayer.Name = "checkBoxIntentHasPlayer";
            this.checkBoxIntentHasPlayer.Size = new System.Drawing.Size(61, 17);
            this.checkBoxIntentHasPlayer.TabIndex = 21;
            this.checkBoxIntentHasPlayer.Text = "Player?";
            this.checkBoxIntentHasPlayer.UseVisualStyleBackColor = true;
            this.checkBoxIntentHasPlayer.CheckedChanged += new System.EventHandler(this.checkBoxIntentHasPlayer_CheckedChanged);
            // 
            // comboBoxIntentPlayerType
            // 
            this.comboBoxIntentPlayerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIntentPlayerType.Enabled = false;
            this.comboBoxIntentPlayerType.FormattingEnabled = true;
            this.comboBoxIntentPlayerType.Items.AddRange(new object[] {
            Hybrasyl.Creatures.IntentType.Hostile,
            Hybrasyl.Creatures.IntentType.Passive,
            Hybrasyl.Creatures.IntentType.Neutral});
            this.comboBoxIntentPlayerType.Location = new System.Drawing.Point(282, 17);
            this.comboBoxIntentPlayerType.Name = "comboBoxIntentPlayerType";
            this.comboBoxIntentPlayerType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIntentPlayerType.TabIndex = 14;
            // 
            // textBoxIntentPlayerValue
            // 
            this.textBoxIntentPlayerValue.Location = new System.Drawing.Point(119, 18);
            this.textBoxIntentPlayerValue.Name = "textBoxIntentPlayerValue";
            this.textBoxIntentPlayerValue.ReadOnly = true;
            this.textBoxIntentPlayerValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntentPlayerValue.TabIndex = 13;
            // 
            // labelIntentPlayerValue
            // 
            this.labelIntentPlayerValue.AutoSize = true;
            this.labelIntentPlayerValue.Location = new System.Drawing.Point(76, 21);
            this.labelIntentPlayerValue.Name = "labelIntentPlayerValue";
            this.labelIntentPlayerValue.Size = new System.Drawing.Size(37, 13);
            this.labelIntentPlayerValue.TabIndex = 12;
            this.labelIntentPlayerValue.Text = "Value:";
            // 
            // labelIntentPlayerType
            // 
            this.labelIntentPlayerType.AutoSize = true;
            this.labelIntentPlayerType.Location = new System.Drawing.Point(239, 20);
            this.labelIntentPlayerType.Name = "labelIntentPlayerType";
            this.labelIntentPlayerType.Size = new System.Drawing.Size(34, 13);
            this.labelIntentPlayerType.TabIndex = 15;
            this.labelIntentPlayerType.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIntentHasNpc);
            this.groupBox1.Controls.Add(this.comboBoxIntentNpcType);
            this.groupBox1.Controls.Add(this.textBoxIntentNpcValue);
            this.groupBox1.Controls.Add(this.labelIntentNpcValue);
            this.groupBox1.Controls.Add(this.labelIntentNpcType);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 48);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Npc";
            // 
            // checkBoxIntentHasNpc
            // 
            this.checkBoxIntentHasNpc.AutoSize = true;
            this.checkBoxIntentHasNpc.Location = new System.Drawing.Point(6, 19);
            this.checkBoxIntentHasNpc.Name = "checkBoxIntentHasNpc";
            this.checkBoxIntentHasNpc.Size = new System.Drawing.Size(52, 17);
            this.checkBoxIntentHasNpc.TabIndex = 21;
            this.checkBoxIntentHasNpc.Text = "Npc?";
            this.checkBoxIntentHasNpc.UseVisualStyleBackColor = true;
            this.checkBoxIntentHasNpc.CheckedChanged += new System.EventHandler(this.checkBoxIntentHasNpc_CheckedChanged);
            // 
            // comboBoxIntentNpcType
            // 
            this.comboBoxIntentNpcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIntentNpcType.Enabled = false;
            this.comboBoxIntentNpcType.FormattingEnabled = true;
            this.comboBoxIntentNpcType.Items.AddRange(new object[] {
            Hybrasyl.Creatures.IntentType.Hostile,
            Hybrasyl.Creatures.IntentType.Passive,
            Hybrasyl.Creatures.IntentType.Neutral});
            this.comboBoxIntentNpcType.Location = new System.Drawing.Point(284, 17);
            this.comboBoxIntentNpcType.Name = "comboBoxIntentNpcType";
            this.comboBoxIntentNpcType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIntentNpcType.TabIndex = 10;
            // 
            // textBoxIntentNpcValue
            // 
            this.textBoxIntentNpcValue.Location = new System.Drawing.Point(121, 18);
            this.textBoxIntentNpcValue.Name = "textBoxIntentNpcValue";
            this.textBoxIntentNpcValue.ReadOnly = true;
            this.textBoxIntentNpcValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntentNpcValue.TabIndex = 9;
            // 
            // labelIntentNpcValue
            // 
            this.labelIntentNpcValue.AutoSize = true;
            this.labelIntentNpcValue.Location = new System.Drawing.Point(78, 21);
            this.labelIntentNpcValue.Name = "labelIntentNpcValue";
            this.labelIntentNpcValue.Size = new System.Drawing.Size(37, 13);
            this.labelIntentNpcValue.TabIndex = 8;
            this.labelIntentNpcValue.Text = "Value:";
            // 
            // labelIntentNpcType
            // 
            this.labelIntentNpcType.AutoSize = true;
            this.labelIntentNpcType.Location = new System.Drawing.Point(241, 20);
            this.labelIntentNpcType.Name = "labelIntentNpcType";
            this.labelIntentNpcType.Size = new System.Drawing.Size(34, 13);
            this.labelIntentNpcType.TabIndex = 11;
            this.labelIntentNpcType.Text = "Type:";
            // 
            // checkBoxHasIntents
            // 
            this.checkBoxHasIntents.AutoSize = true;
            this.checkBoxHasIntents.Location = new System.Drawing.Point(9, 19);
            this.checkBoxHasIntents.Name = "checkBoxHasIntents";
            this.checkBoxHasIntents.Size = new System.Drawing.Size(86, 17);
            this.checkBoxHasIntents.TabIndex = 20;
            this.checkBoxHasIntents.Text = "Has Intents?";
            this.checkBoxHasIntents.UseVisualStyleBackColor = true;
            this.checkBoxHasIntents.CheckedChanged += new System.EventHandler(this.checkBoxHasIntents_CheckedChanged);
            // 
            // groupBoxRespawn
            // 
            this.groupBoxRespawn.Controls.Add(this.labelRespawnMax);
            this.groupBoxRespawn.Controls.Add(this.numericRespawnMax);
            this.groupBoxRespawn.Controls.Add(this.labelRespawnMin);
            this.groupBoxRespawn.Controls.Add(this.numericRespawnMin);
            this.groupBoxRespawn.Controls.Add(this.labelRespawnPercentage);
            this.groupBoxRespawn.Controls.Add(this.numericRespawnPercentage);
            this.groupBoxRespawn.Controls.Add(this.labelRespawnInterval);
            this.groupBoxRespawn.Controls.Add(this.numericRespawnInterval);
            this.groupBoxRespawn.Location = new System.Drawing.Point(6, 370);
            this.groupBoxRespawn.Name = "groupBoxRespawn";
            this.groupBoxRespawn.Size = new System.Drawing.Size(431, 100);
            this.groupBoxRespawn.TabIndex = 8;
            this.groupBoxRespawn.TabStop = false;
            this.groupBoxRespawn.Text = "Respawn";
            // 
            // labelRespawnMax
            // 
            this.labelRespawnMax.AutoSize = true;
            this.labelRespawnMax.Location = new System.Drawing.Point(262, 64);
            this.labelRespawnMax.Name = "labelRespawnMax";
            this.labelRespawnMax.Size = new System.Drawing.Size(30, 13);
            this.labelRespawnMax.TabIndex = 10;
            this.labelRespawnMax.Text = "Max:";
            // 
            // numericRespawnMax
            // 
            this.numericRespawnMax.Location = new System.Drawing.Point(298, 62);
            this.numericRespawnMax.Name = "numericRespawnMax";
            this.numericRespawnMax.Size = new System.Drawing.Size(120, 20);
            this.numericRespawnMax.TabIndex = 11;
            // 
            // labelRespawnMin
            // 
            this.labelRespawnMin.AutoSize = true;
            this.labelRespawnMin.Location = new System.Drawing.Point(37, 64);
            this.labelRespawnMin.Name = "labelRespawnMin";
            this.labelRespawnMin.Size = new System.Drawing.Size(27, 13);
            this.labelRespawnMin.TabIndex = 8;
            this.labelRespawnMin.Text = "Min:";
            // 
            // numericRespawnMin
            // 
            this.numericRespawnMin.Location = new System.Drawing.Point(70, 62);
            this.numericRespawnMin.Name = "numericRespawnMin";
            this.numericRespawnMin.Size = new System.Drawing.Size(120, 20);
            this.numericRespawnMin.TabIndex = 9;
            // 
            // labelRespawnPercentage
            // 
            this.labelRespawnPercentage.AutoSize = true;
            this.labelRespawnPercentage.Location = new System.Drawing.Point(227, 29);
            this.labelRespawnPercentage.Name = "labelRespawnPercentage";
            this.labelRespawnPercentage.Size = new System.Drawing.Size(65, 13);
            this.labelRespawnPercentage.TabIndex = 6;
            this.labelRespawnPercentage.Text = "Percentage:";
            // 
            // numericRespawnPercentage
            // 
            this.numericRespawnPercentage.DecimalPlaces = 2;
            this.numericRespawnPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericRespawnPercentage.Location = new System.Drawing.Point(298, 27);
            this.numericRespawnPercentage.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRespawnPercentage.Name = "numericRespawnPercentage";
            this.numericRespawnPercentage.Size = new System.Drawing.Size(120, 20);
            this.numericRespawnPercentage.TabIndex = 7;
            // 
            // labelRespawnInterval
            // 
            this.labelRespawnInterval.AutoSize = true;
            this.labelRespawnInterval.Location = new System.Drawing.Point(19, 29);
            this.labelRespawnInterval.Name = "labelRespawnInterval";
            this.labelRespawnInterval.Size = new System.Drawing.Size(45, 13);
            this.labelRespawnInterval.TabIndex = 4;
            this.labelRespawnInterval.Text = "Interval:";
            // 
            // numericRespawnInterval
            // 
            this.numericRespawnInterval.Location = new System.Drawing.Point(70, 27);
            this.numericRespawnInterval.Name = "numericRespawnInterval";
            this.numericRespawnInterval.Size = new System.Drawing.Size(120, 20);
            this.numericRespawnInterval.TabIndex = 5;
            // 
            // groupBoxDamage
            // 
            this.groupBoxDamage.Controls.Add(this.labelDamageElements);
            this.groupBoxDamage.Controls.Add(this.listBoxDamageElements);
            this.groupBoxDamage.Controls.Add(this.labelDamageType);
            this.groupBoxDamage.Controls.Add(this.comboBoxDamageType);
            this.groupBoxDamage.Controls.Add(this.labelDamageHit);
            this.groupBoxDamage.Controls.Add(this.numericDamageHit);
            this.groupBoxDamage.Controls.Add(this.labelDamageDmg);
            this.groupBoxDamage.Controls.Add(this.numericDamageDmg);
            this.groupBoxDamage.Controls.Add(this.labelDamageMin);
            this.groupBoxDamage.Controls.Add(this.numericDamageMin);
            this.groupBoxDamage.Controls.Add(this.labelDamageMax);
            this.groupBoxDamage.Controls.Add(this.numericDamageMax);
            this.groupBoxDamage.Location = new System.Drawing.Point(6, 476);
            this.groupBoxDamage.Name = "groupBoxDamage";
            this.groupBoxDamage.Size = new System.Drawing.Size(431, 179);
            this.groupBoxDamage.TabIndex = 8;
            this.groupBoxDamage.TabStop = false;
            this.groupBoxDamage.Text = "Damage";
            // 
            // labelDamageElements
            // 
            this.labelDamageElements.AutoSize = true;
            this.labelDamageElements.Location = new System.Drawing.Point(239, 26);
            this.labelDamageElements.Name = "labelDamageElements";
            this.labelDamageElements.Size = new System.Drawing.Size(53, 13);
            this.labelDamageElements.TabIndex = 17;
            this.labelDamageElements.Text = "Elements:";
            // 
            // listBoxDamageElements
            // 
            this.listBoxDamageElements.ColumnWidth = 50;
            this.listBoxDamageElements.FormattingEnabled = true;
            this.listBoxDamageElements.Items.AddRange(new object[] {
            Hybrasyl.Creatures.Element.None,
            Hybrasyl.Creatures.Element.Fire,
            Hybrasyl.Creatures.Element.Water,
            Hybrasyl.Creatures.Element.Wind,
            Hybrasyl.Creatures.Element.Earth,
            Hybrasyl.Creatures.Element.Light,
            Hybrasyl.Creatures.Element.Dark,
            Hybrasyl.Creatures.Element.Wood,
            Hybrasyl.Creatures.Element.Metal,
            Hybrasyl.Creatures.Element.Undead,
            Hybrasyl.Creatures.Element.Random});
            this.listBoxDamageElements.Location = new System.Drawing.Point(298, 26);
            this.listBoxDamageElements.MultiColumn = true;
            this.listBoxDamageElements.Name = "listBoxDamageElements";
            this.listBoxDamageElements.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDamageElements.Size = new System.Drawing.Size(120, 82);
            this.listBoxDamageElements.TabIndex = 16;
            // 
            // labelDamageType
            // 
            this.labelDamageType.AutoSize = true;
            this.labelDamageType.Location = new System.Drawing.Point(30, 131);
            this.labelDamageType.Name = "labelDamageType";
            this.labelDamageType.Size = new System.Drawing.Size(34, 13);
            this.labelDamageType.TabIndex = 15;
            this.labelDamageType.Text = "Type:";
            // 
            // comboBoxDamageType
            // 
            this.comboBoxDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDamageType.FormattingEnabled = true;
            this.comboBoxDamageType.Items.AddRange(new object[] {
            Hybrasyl.Creatures.DamageType.Direct,
            Hybrasyl.Creatures.DamageType.Physical,
            Hybrasyl.Creatures.DamageType.Magical,
            Hybrasyl.Creatures.DamageType.Elemental});
            this.comboBoxDamageType.Location = new System.Drawing.Point(70, 128);
            this.comboBoxDamageType.Name = "comboBoxDamageType";
            this.comboBoxDamageType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDamageType.TabIndex = 14;
            // 
            // labelDamageHit
            // 
            this.labelDamageHit.AutoSize = true;
            this.labelDamageHit.Location = new System.Drawing.Point(41, 104);
            this.labelDamageHit.Name = "labelDamageHit";
            this.labelDamageHit.Size = new System.Drawing.Size(23, 13);
            this.labelDamageHit.TabIndex = 12;
            this.labelDamageHit.Text = "Hit:";
            // 
            // numericDamageHit
            // 
            this.numericDamageHit.Location = new System.Drawing.Point(70, 102);
            this.numericDamageHit.Name = "numericDamageHit";
            this.numericDamageHit.Size = new System.Drawing.Size(120, 20);
            this.numericDamageHit.TabIndex = 13;
            // 
            // labelDamageDmg
            // 
            this.labelDamageDmg.AutoSize = true;
            this.labelDamageDmg.Location = new System.Drawing.Point(32, 78);
            this.labelDamageDmg.Name = "labelDamageDmg";
            this.labelDamageDmg.Size = new System.Drawing.Size(32, 13);
            this.labelDamageDmg.TabIndex = 10;
            this.labelDamageDmg.Text = "Dmg:";
            // 
            // numericDamageDmg
            // 
            this.numericDamageDmg.Location = new System.Drawing.Point(70, 76);
            this.numericDamageDmg.Name = "numericDamageDmg";
            this.numericDamageDmg.Size = new System.Drawing.Size(120, 20);
            this.numericDamageDmg.TabIndex = 11;
            // 
            // labelDamageMin
            // 
            this.labelDamageMin.AutoSize = true;
            this.labelDamageMin.Location = new System.Drawing.Point(37, 26);
            this.labelDamageMin.Name = "labelDamageMin";
            this.labelDamageMin.Size = new System.Drawing.Size(27, 13);
            this.labelDamageMin.TabIndex = 8;
            this.labelDamageMin.Text = "Min:";
            // 
            // numericDamageMin
            // 
            this.numericDamageMin.Location = new System.Drawing.Point(70, 24);
            this.numericDamageMin.Name = "numericDamageMin";
            this.numericDamageMin.Size = new System.Drawing.Size(120, 20);
            this.numericDamageMin.TabIndex = 9;
            // 
            // labelDamageMax
            // 
            this.labelDamageMax.AutoSize = true;
            this.labelDamageMax.Location = new System.Drawing.Point(34, 52);
            this.labelDamageMax.Name = "labelDamageMax";
            this.labelDamageMax.Size = new System.Drawing.Size(30, 13);
            this.labelDamageMax.TabIndex = 6;
            this.labelDamageMax.Text = "Max:";
            // 
            // numericDamageMax
            // 
            this.numericDamageMax.Location = new System.Drawing.Point(70, 50);
            this.numericDamageMax.Name = "numericDamageMax";
            this.numericDamageMax.Size = new System.Drawing.Size(120, 20);
            this.numericDamageMax.TabIndex = 7;
            // 
            // groupBoxDefense
            // 
            this.groupBoxDefense.Controls.Add(this.labelDefenseRegen);
            this.groupBoxDefense.Controls.Add(this.numericDefenseRegen);
            this.groupBoxDefense.Controls.Add(this.labelDefenseMr);
            this.groupBoxDefense.Controls.Add(this.numericDefenseMr);
            this.groupBoxDefense.Controls.Add(this.labelDefenseAc);
            this.groupBoxDefense.Controls.Add(this.numericDefenseAc);
            this.groupBoxDefense.Controls.Add(this.labelDefenseElements);
            this.groupBoxDefense.Controls.Add(this.listBoxDefenseElements);
            this.groupBoxDefense.Location = new System.Drawing.Point(6, 661);
            this.groupBoxDefense.Name = "groupBoxDefense";
            this.groupBoxDefense.Size = new System.Drawing.Size(431, 114);
            this.groupBoxDefense.TabIndex = 8;
            this.groupBoxDefense.TabStop = false;
            this.groupBoxDefense.Text = "Defense";
            // 
            // labelDefenseRegen
            // 
            this.labelDefenseRegen.AutoSize = true;
            this.labelDefenseRegen.Location = new System.Drawing.Point(22, 71);
            this.labelDefenseRegen.Name = "labelDefenseRegen";
            this.labelDefenseRegen.Size = new System.Drawing.Size(42, 13);
            this.labelDefenseRegen.TabIndex = 24;
            this.labelDefenseRegen.Text = "Regen:";
            // 
            // numericDefenseRegen
            // 
            this.numericDefenseRegen.Location = new System.Drawing.Point(70, 69);
            this.numericDefenseRegen.Name = "numericDefenseRegen";
            this.numericDefenseRegen.Size = new System.Drawing.Size(120, 20);
            this.numericDefenseRegen.TabIndex = 25;
            // 
            // labelDefenseMr
            // 
            this.labelDefenseMr.AutoSize = true;
            this.labelDefenseMr.Location = new System.Drawing.Point(42, 19);
            this.labelDefenseMr.Name = "labelDefenseMr";
            this.labelDefenseMr.Size = new System.Drawing.Size(22, 13);
            this.labelDefenseMr.TabIndex = 22;
            this.labelDefenseMr.Text = "Mr:";
            // 
            // numericDefenseMr
            // 
            this.numericDefenseMr.Location = new System.Drawing.Point(70, 17);
            this.numericDefenseMr.Name = "numericDefenseMr";
            this.numericDefenseMr.Size = new System.Drawing.Size(120, 20);
            this.numericDefenseMr.TabIndex = 23;
            // 
            // labelDefenseAc
            // 
            this.labelDefenseAc.AutoSize = true;
            this.labelDefenseAc.Location = new System.Drawing.Point(41, 45);
            this.labelDefenseAc.Name = "labelDefenseAc";
            this.labelDefenseAc.Size = new System.Drawing.Size(23, 13);
            this.labelDefenseAc.TabIndex = 20;
            this.labelDefenseAc.Text = "Ac:";
            // 
            // numericDefenseAc
            // 
            this.numericDefenseAc.Location = new System.Drawing.Point(70, 43);
            this.numericDefenseAc.Name = "numericDefenseAc";
            this.numericDefenseAc.Size = new System.Drawing.Size(120, 20);
            this.numericDefenseAc.TabIndex = 21;
            // 
            // labelDefenseElements
            // 
            this.labelDefenseElements.AutoSize = true;
            this.labelDefenseElements.Location = new System.Drawing.Point(239, 19);
            this.labelDefenseElements.Name = "labelDefenseElements";
            this.labelDefenseElements.Size = new System.Drawing.Size(53, 13);
            this.labelDefenseElements.TabIndex = 19;
            this.labelDefenseElements.Text = "Elements:";
            // 
            // listBoxDefenseElements
            // 
            this.listBoxDefenseElements.ColumnWidth = 50;
            this.listBoxDefenseElements.FormattingEnabled = true;
            this.listBoxDefenseElements.Items.AddRange(new object[] {
            Hybrasyl.Creatures.Element.None,
            Hybrasyl.Creatures.Element.Fire,
            Hybrasyl.Creatures.Element.Water,
            Hybrasyl.Creatures.Element.Wind,
            Hybrasyl.Creatures.Element.Earth,
            Hybrasyl.Creatures.Element.Light,
            Hybrasyl.Creatures.Element.Dark,
            Hybrasyl.Creatures.Element.Wood,
            Hybrasyl.Creatures.Element.Metal,
            Hybrasyl.Creatures.Element.Undead,
            Hybrasyl.Creatures.Element.Random});
            this.listBoxDefenseElements.Location = new System.Drawing.Point(298, 19);
            this.listBoxDefenseElements.MultiColumn = true;
            this.listBoxDefenseElements.Name = "listBoxDefenseElements";
            this.listBoxDefenseElements.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDefenseElements.Size = new System.Drawing.Size(120, 82);
            this.listBoxDefenseElements.TabIndex = 18;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.labelStatsDex);
            this.groupBoxStats.Controls.Add(this.numericStatsDex);
            this.groupBoxStats.Controls.Add(this.labelStatsCon);
            this.groupBoxStats.Controls.Add(this.numericStatsCon);
            this.groupBoxStats.Controls.Add(this.labelStatsInt);
            this.groupBoxStats.Controls.Add(this.numericStatsInt);
            this.groupBoxStats.Controls.Add(this.labelStatsWis);
            this.groupBoxStats.Controls.Add(this.numericStatsWis);
            this.groupBoxStats.Controls.Add(this.labelStatsStr);
            this.groupBoxStats.Controls.Add(this.numericStatsStr);
            this.groupBoxStats.Controls.Add(this.labelStatsLevel);
            this.groupBoxStats.Controls.Add(this.numericStatsLevel);
            this.groupBoxStats.Controls.Add(this.labelStatsHp);
            this.groupBoxStats.Controls.Add(this.numericStatsHp);
            this.groupBoxStats.Controls.Add(this.labelStatsMp);
            this.groupBoxStats.Controls.Add(this.numericStatsMp);
            this.groupBoxStats.Location = new System.Drawing.Point(443, 12);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(386, 135);
            this.groupBoxStats.TabIndex = 8;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stats";
            // 
            // labelStatsDex
            // 
            this.labelStatsDex.AutoSize = true;
            this.labelStatsDex.Location = new System.Drawing.Point(209, 99);
            this.labelStatsDex.Name = "labelStatsDex";
            this.labelStatsDex.Size = new System.Drawing.Size(29, 13);
            this.labelStatsDex.TabIndex = 28;
            this.labelStatsDex.Text = "Dex:";
            // 
            // numericStatsDex
            // 
            this.numericStatsDex.Location = new System.Drawing.Point(244, 97);
            this.numericStatsDex.Name = "numericStatsDex";
            this.numericStatsDex.Size = new System.Drawing.Size(120, 20);
            this.numericStatsDex.TabIndex = 29;
            // 
            // labelStatsCon
            // 
            this.labelStatsCon.AutoSize = true;
            this.labelStatsCon.Location = new System.Drawing.Point(209, 73);
            this.labelStatsCon.Name = "labelStatsCon";
            this.labelStatsCon.Size = new System.Drawing.Size(29, 13);
            this.labelStatsCon.TabIndex = 26;
            this.labelStatsCon.Text = "Con:";
            // 
            // numericStatsCon
            // 
            this.numericStatsCon.Location = new System.Drawing.Point(244, 71);
            this.numericStatsCon.Name = "numericStatsCon";
            this.numericStatsCon.Size = new System.Drawing.Size(120, 20);
            this.numericStatsCon.TabIndex = 27;
            // 
            // labelStatsInt
            // 
            this.labelStatsInt.AutoSize = true;
            this.labelStatsInt.Location = new System.Drawing.Point(216, 21);
            this.labelStatsInt.Name = "labelStatsInt";
            this.labelStatsInt.Size = new System.Drawing.Size(22, 13);
            this.labelStatsInt.TabIndex = 24;
            this.labelStatsInt.Text = "Int:";
            // 
            // numericStatsInt
            // 
            this.numericStatsInt.Location = new System.Drawing.Point(244, 19);
            this.numericStatsInt.Name = "numericStatsInt";
            this.numericStatsInt.Size = new System.Drawing.Size(120, 20);
            this.numericStatsInt.TabIndex = 25;
            // 
            // labelStatsWis
            // 
            this.labelStatsWis.AutoSize = true;
            this.labelStatsWis.Location = new System.Drawing.Point(210, 47);
            this.labelStatsWis.Name = "labelStatsWis";
            this.labelStatsWis.Size = new System.Drawing.Size(28, 13);
            this.labelStatsWis.TabIndex = 22;
            this.labelStatsWis.Text = "Wis:";
            // 
            // numericStatsWis
            // 
            this.numericStatsWis.Location = new System.Drawing.Point(244, 45);
            this.numericStatsWis.Name = "numericStatsWis";
            this.numericStatsWis.Size = new System.Drawing.Size(120, 20);
            this.numericStatsWis.TabIndex = 23;
            // 
            // labelStatsStr
            // 
            this.labelStatsStr.AutoSize = true;
            this.labelStatsStr.Location = new System.Drawing.Point(20, 99);
            this.labelStatsStr.Name = "labelStatsStr";
            this.labelStatsStr.Size = new System.Drawing.Size(23, 13);
            this.labelStatsStr.TabIndex = 20;
            this.labelStatsStr.Text = "Str:";
            // 
            // numericStatsStr
            // 
            this.numericStatsStr.Location = new System.Drawing.Point(49, 97);
            this.numericStatsStr.Name = "numericStatsStr";
            this.numericStatsStr.Size = new System.Drawing.Size(120, 20);
            this.numericStatsStr.TabIndex = 21;
            // 
            // labelStatsLevel
            // 
            this.labelStatsLevel.AutoSize = true;
            this.labelStatsLevel.Location = new System.Drawing.Point(7, 73);
            this.labelStatsLevel.Name = "labelStatsLevel";
            this.labelStatsLevel.Size = new System.Drawing.Size(36, 13);
            this.labelStatsLevel.TabIndex = 18;
            this.labelStatsLevel.Text = "Level:";
            // 
            // numericStatsLevel
            // 
            this.numericStatsLevel.Location = new System.Drawing.Point(49, 71);
            this.numericStatsLevel.Name = "numericStatsLevel";
            this.numericStatsLevel.Size = new System.Drawing.Size(120, 20);
            this.numericStatsLevel.TabIndex = 19;
            // 
            // labelStatsHp
            // 
            this.labelStatsHp.AutoSize = true;
            this.labelStatsHp.Location = new System.Drawing.Point(19, 21);
            this.labelStatsHp.Name = "labelStatsHp";
            this.labelStatsHp.Size = new System.Drawing.Size(24, 13);
            this.labelStatsHp.TabIndex = 16;
            this.labelStatsHp.Text = "Hp:";
            // 
            // numericStatsHp
            // 
            this.numericStatsHp.Location = new System.Drawing.Point(49, 19);
            this.numericStatsHp.Name = "numericStatsHp";
            this.numericStatsHp.Size = new System.Drawing.Size(120, 20);
            this.numericStatsHp.TabIndex = 17;
            // 
            // labelStatsMp
            // 
            this.labelStatsMp.AutoSize = true;
            this.labelStatsMp.Location = new System.Drawing.Point(18, 47);
            this.labelStatsMp.Name = "labelStatsMp";
            this.labelStatsMp.Size = new System.Drawing.Size(25, 13);
            this.labelStatsMp.TabIndex = 14;
            this.labelStatsMp.Text = "Mp:";
            // 
            // numericStatsMp
            // 
            this.numericStatsMp.Location = new System.Drawing.Point(49, 45);
            this.numericStatsMp.Name = "numericStatsMp";
            this.numericStatsMp.Size = new System.Drawing.Size(120, 20);
            this.numericStatsMp.TabIndex = 15;
            // 
            // groupBoxLootList
            // 
            this.groupBoxLootList.Controls.Add(this.checkBoxHasLootTable);
            this.groupBoxLootList.Controls.Add(this.checkBoxHasLootImport);
            this.groupBoxLootList.Controls.Add(this.labelLootImport);
            this.groupBoxLootList.Controls.Add(this.groupBoxLootGold);
            this.groupBoxLootList.Controls.Add(this.groupBoxLootXP);
            this.groupBoxLootList.Controls.Add(this.dataGridViewLootImport);
            this.groupBoxLootList.Location = new System.Drawing.Point(443, 153);
            this.groupBoxLootList.Name = "groupBoxLootList";
            this.groupBoxLootList.Size = new System.Drawing.Size(386, 390);
            this.groupBoxLootList.TabIndex = 8;
            this.groupBoxLootList.TabStop = false;
            this.groupBoxLootList.Text = "Loot List";
            // 
            // checkBoxHasLootTable
            // 
            this.checkBoxHasLootTable.AutoSize = true;
            this.checkBoxHasLootTable.Location = new System.Drawing.Point(6, 246);
            this.checkBoxHasLootTable.Name = "checkBoxHasLootTable";
            this.checkBoxHasLootTable.Size = new System.Drawing.Size(105, 17);
            this.checkBoxHasLootTable.TabIndex = 32;
            this.checkBoxHasLootTable.Text = "Has Loot Table?";
            this.checkBoxHasLootTable.UseVisualStyleBackColor = true;
            this.checkBoxHasLootTable.CheckedChanged += new System.EventHandler(this.checkBoxHasLootTable_CheckedChanged);
            // 
            // checkBoxHasLootImport
            // 
            this.checkBoxHasLootImport.AutoSize = true;
            this.checkBoxHasLootImport.Location = new System.Drawing.Point(6, 124);
            this.checkBoxHasLootImport.Name = "checkBoxHasLootImport";
            this.checkBoxHasLootImport.Size = new System.Drawing.Size(107, 17);
            this.checkBoxHasLootImport.TabIndex = 31;
            this.checkBoxHasLootImport.Text = "Has Loot Import?";
            this.checkBoxHasLootImport.UseVisualStyleBackColor = true;
            this.checkBoxHasLootImport.CheckedChanged += new System.EventHandler(this.checkBoxHasLootImport_CheckedChanged);
            // 
            // labelLootImport
            // 
            this.labelLootImport.AutoSize = true;
            this.labelLootImport.Location = new System.Drawing.Point(6, 144);
            this.labelLootImport.Name = "labelLootImport";
            this.labelLootImport.Size = new System.Drawing.Size(63, 13);
            this.labelLootImport.TabIndex = 30;
            this.labelLootImport.Text = "Loot Import:";
            // 
            // groupBoxLootGold
            // 
            this.groupBoxLootGold.Controls.Add(this.labelLootGoldMax);
            this.groupBoxLootGold.Controls.Add(this.numericLootGoldMax);
            this.groupBoxLootGold.Controls.Add(this.labelLootGoldMin);
            this.groupBoxLootGold.Controls.Add(this.numericLootGoldMin);
            this.groupBoxLootGold.Location = new System.Drawing.Point(7, 72);
            this.groupBoxLootGold.Name = "groupBoxLootGold";
            this.groupBoxLootGold.Size = new System.Drawing.Size(373, 46);
            this.groupBoxLootGold.TabIndex = 2;
            this.groupBoxLootGold.TabStop = false;
            this.groupBoxLootGold.Text = "Gold";
            // 
            // labelLootGoldMax
            // 
            this.labelLootGoldMax.AutoSize = true;
            this.labelLootGoldMax.Location = new System.Drawing.Point(201, 21);
            this.labelLootGoldMax.Name = "labelLootGoldMax";
            this.labelLootGoldMax.Size = new System.Drawing.Size(30, 13);
            this.labelLootGoldMax.TabIndex = 28;
            this.labelLootGoldMax.Text = "Max:";
            // 
            // numericLootGoldMax
            // 
            this.numericLootGoldMax.Location = new System.Drawing.Point(237, 19);
            this.numericLootGoldMax.Name = "numericLootGoldMax";
            this.numericLootGoldMax.Size = new System.Drawing.Size(120, 20);
            this.numericLootGoldMax.TabIndex = 29;
            // 
            // labelLootGoldMin
            // 
            this.labelLootGoldMin.AutoSize = true;
            this.labelLootGoldMin.Location = new System.Drawing.Point(9, 21);
            this.labelLootGoldMin.Name = "labelLootGoldMin";
            this.labelLootGoldMin.Size = new System.Drawing.Size(27, 13);
            this.labelLootGoldMin.TabIndex = 26;
            this.labelLootGoldMin.Text = "Min:";
            // 
            // numericLootGoldMin
            // 
            this.numericLootGoldMin.Location = new System.Drawing.Point(42, 19);
            this.numericLootGoldMin.Name = "numericLootGoldMin";
            this.numericLootGoldMin.Size = new System.Drawing.Size(120, 20);
            this.numericLootGoldMin.TabIndex = 27;
            // 
            // groupBoxLootXP
            // 
            this.groupBoxLootXP.Controls.Add(this.labelLootXpMax);
            this.groupBoxLootXP.Controls.Add(this.numericLootXpMin);
            this.groupBoxLootXP.Controls.Add(this.numericLootXpMax);
            this.groupBoxLootXP.Controls.Add(this.labelLootXpMin);
            this.groupBoxLootXP.Location = new System.Drawing.Point(7, 20);
            this.groupBoxLootXP.Name = "groupBoxLootXP";
            this.groupBoxLootXP.Size = new System.Drawing.Size(373, 46);
            this.groupBoxLootXP.TabIndex = 1;
            this.groupBoxLootXP.TabStop = false;
            this.groupBoxLootXP.Text = "XP";
            // 
            // labelLootXpMax
            // 
            this.labelLootXpMax.AutoSize = true;
            this.labelLootXpMax.Location = new System.Drawing.Point(201, 21);
            this.labelLootXpMax.Name = "labelLootXpMax";
            this.labelLootXpMax.Size = new System.Drawing.Size(30, 13);
            this.labelLootXpMax.TabIndex = 32;
            this.labelLootXpMax.Text = "Max:";
            // 
            // numericLootXpMin
            // 
            this.numericLootXpMin.Location = new System.Drawing.Point(42, 19);
            this.numericLootXpMin.Name = "numericLootXpMin";
            this.numericLootXpMin.Size = new System.Drawing.Size(120, 20);
            this.numericLootXpMin.TabIndex = 31;
            // 
            // numericLootXpMax
            // 
            this.numericLootXpMax.Location = new System.Drawing.Point(237, 19);
            this.numericLootXpMax.Name = "numericLootXpMax";
            this.numericLootXpMax.Size = new System.Drawing.Size(120, 20);
            this.numericLootXpMax.TabIndex = 33;
            // 
            // labelLootXpMin
            // 
            this.labelLootXpMin.AutoSize = true;
            this.labelLootXpMin.Location = new System.Drawing.Point(9, 21);
            this.labelLootXpMin.Name = "labelLootXpMin";
            this.labelLootXpMin.Size = new System.Drawing.Size(27, 13);
            this.labelLootXpMin.TabIndex = 30;
            this.labelLootXpMin.Text = "Min:";
            // 
            // dataGridViewLootImport
            // 
            this.dataGridViewLootImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLootImport.Location = new System.Drawing.Point(6, 160);
            this.dataGridViewLootImport.Name = "dataGridViewLootImport";
            this.dataGridViewLootImport.ReadOnly = true;
            this.dataGridViewLootImport.Size = new System.Drawing.Size(374, 80);
            this.dataGridViewLootImport.TabIndex = 0;
            // 
            // groupBoxCastables
            // 
            this.groupBoxCastables.Controls.Add(this.checkBoxHasCastables);
            this.groupBoxCastables.Controls.Add(this.dataGridViewCastables);
            this.groupBoxCastables.Location = new System.Drawing.Point(443, 549);
            this.groupBoxCastables.Name = "groupBoxCastables";
            this.groupBoxCastables.Size = new System.Drawing.Size(386, 154);
            this.groupBoxCastables.TabIndex = 8;
            this.groupBoxCastables.TabStop = false;
            this.groupBoxCastables.Text = "Castables";
            // 
            // checkBoxHasCastables
            // 
            this.checkBoxHasCastables.AutoSize = true;
            this.checkBoxHasCastables.Location = new System.Drawing.Point(6, 19);
            this.checkBoxHasCastables.Name = "checkBoxHasCastables";
            this.checkBoxHasCastables.Size = new System.Drawing.Size(100, 17);
            this.checkBoxHasCastables.TabIndex = 21;
            this.checkBoxHasCastables.Text = "Has Castables?";
            this.checkBoxHasCastables.UseVisualStyleBackColor = true;
            this.checkBoxHasCastables.CheckedChanged += new System.EventHandler(this.checkBoxHasCastables_CheckedChanged);
            // 
            // dataGridViewCastables
            // 
            this.dataGridViewCastables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCastables.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewCastables.Name = "dataGridViewCastables";
            this.dataGridViewCastables.ReadOnly = true;
            this.dataGridViewCastables.Size = new System.Drawing.Size(373, 84);
            this.dataGridViewCastables.TabIndex = 0;
            // 
            // SpawnDialog
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(856, 787);
            this.Controls.Add(this.groupBoxRespawn);
            this.Controls.Add(this.groupBoxDamage);
            this.Controls.Add(this.groupBoxDefense);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.groupBoxLootList);
            this.Controls.Add(this.groupBoxCastables);
            this.Controls.Add(this.groupBoxIntents);
            this.Controls.Add(this.groupBoxScript);
            this.Controls.Add(this.groupBoxAttributes);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "SpawnDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpawnDialog";
            this.Load += new System.EventHandler(this.SpawnDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericVariance)).EndInit();
            this.groupBoxAttributes.ResumeLayout(false);
            this.groupBoxAttributes.PerformLayout();
            this.groupBoxScript.ResumeLayout(false);
            this.groupBoxScript.PerformLayout();
            this.groupBoxIntents.ResumeLayout(false);
            this.groupBoxIntents.PerformLayout();
            this.groupBoxIntentMonster.ResumeLayout(false);
            this.groupBoxIntentMonster.PerformLayout();
            this.groupBoxIntentPlayer.ResumeLayout(false);
            this.groupBoxIntentPlayer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRespawn.ResumeLayout(false);
            this.groupBoxRespawn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRespawnInterval)).EndInit();
            this.groupBoxDamage.ResumeLayout(false);
            this.groupBoxDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamageMax)).EndInit();
            this.groupBoxDefense.ResumeLayout(false);
            this.groupBoxDefense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefenseRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefenseMr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefenseAc)).EndInit();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStatsMp)).EndInit();
            this.groupBoxLootList.ResumeLayout(false);
            this.groupBoxLootList.PerformLayout();
            this.groupBoxLootGold.ResumeLayout(false);
            this.groupBoxLootGold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootGoldMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootGoldMin)).EndInit();
            this.groupBoxLootXP.ResumeLayout(false);
            this.groupBoxLootXP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootXpMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLootXpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLootImport)).EndInit();
            this.groupBoxCastables.ResumeLayout(false);
            this.groupBoxCastables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCastables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.NumericUpDown numericVariance;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxAttributes;
        private System.Windows.Forms.GroupBox groupBoxScript;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textBoxScriptValue;
        private System.Windows.Forms.GroupBox groupBoxIntents;
        private System.Windows.Forms.GroupBox groupBoxRespawn;
        private System.Windows.Forms.GroupBox groupBoxDamage;
        private System.Windows.Forms.GroupBox groupBoxDefense;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.GroupBox groupBoxLootList;
        private System.Windows.Forms.GroupBox groupBoxCastables;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxScriptType;
        private System.Windows.Forms.CheckBox checkBoxHasScript;
        private System.Windows.Forms.Label labelIntentNpcType;
        private System.Windows.Forms.ComboBox comboBoxIntentNpcType;
        private System.Windows.Forms.Label labelIntentNpcValue;
        private System.Windows.Forms.TextBox textBoxIntentNpcValue;
        private System.Windows.Forms.Label labelIntentPlayerType;
        private System.Windows.Forms.ComboBox comboBoxIntentPlayerType;
        private System.Windows.Forms.Label labelIntentPlayerValue;
        private System.Windows.Forms.TextBox textBoxIntentPlayerValue;
        private System.Windows.Forms.Label labelRespawnMax;
        private System.Windows.Forms.NumericUpDown numericRespawnMax;
        private System.Windows.Forms.Label labelRespawnMin;
        private System.Windows.Forms.NumericUpDown numericRespawnMin;
        private System.Windows.Forms.Label labelRespawnPercentage;
        private System.Windows.Forms.NumericUpDown numericRespawnPercentage;
        private System.Windows.Forms.Label labelRespawnInterval;
        private System.Windows.Forms.NumericUpDown numericRespawnInterval;
        private System.Windows.Forms.ListBox listBoxDamageElements;
        private System.Windows.Forms.Label labelDamageType;
        private System.Windows.Forms.ComboBox comboBoxDamageType;
        private System.Windows.Forms.Label labelDamageHit;
        private System.Windows.Forms.NumericUpDown numericDamageHit;
        private System.Windows.Forms.Label labelDamageDmg;
        private System.Windows.Forms.NumericUpDown numericDamageDmg;
        private System.Windows.Forms.Label labelDamageMin;
        private System.Windows.Forms.NumericUpDown numericDamageMin;
        private System.Windows.Forms.Label labelDamageMax;
        private System.Windows.Forms.NumericUpDown numericDamageMax;
        private System.Windows.Forms.Label labelDamageElements;
        private System.Windows.Forms.Label labelDefenseRegen;
        private System.Windows.Forms.NumericUpDown numericDefenseRegen;
        private System.Windows.Forms.Label labelDefenseMr;
        private System.Windows.Forms.NumericUpDown numericDefenseMr;
        private System.Windows.Forms.Label labelDefenseAc;
        private System.Windows.Forms.NumericUpDown numericDefenseAc;
        private System.Windows.Forms.Label labelDefenseElements;
        private System.Windows.Forms.ListBox listBoxDefenseElements;
        private System.Windows.Forms.Label labelStatsDex;
        private System.Windows.Forms.NumericUpDown numericStatsDex;
        private System.Windows.Forms.Label labelStatsCon;
        private System.Windows.Forms.NumericUpDown numericStatsCon;
        private System.Windows.Forms.Label labelStatsInt;
        private System.Windows.Forms.NumericUpDown numericStatsInt;
        private System.Windows.Forms.Label labelStatsWis;
        private System.Windows.Forms.NumericUpDown numericStatsWis;
        private System.Windows.Forms.Label labelStatsStr;
        private System.Windows.Forms.NumericUpDown numericStatsStr;
        private System.Windows.Forms.Label labelStatsLevel;
        private System.Windows.Forms.NumericUpDown numericStatsLevel;
        private System.Windows.Forms.Label labelStatsHp;
        private System.Windows.Forms.NumericUpDown numericStatsHp;
        private System.Windows.Forms.Label labelStatsMp;
        private System.Windows.Forms.NumericUpDown numericStatsMp;
        private System.Windows.Forms.GroupBox groupBoxLootGold;
        private System.Windows.Forms.Label labelLootGoldMax;
        private System.Windows.Forms.NumericUpDown numericLootGoldMax;
        private System.Windows.Forms.Label labelLootGoldMin;
        private System.Windows.Forms.NumericUpDown numericLootGoldMin;
        private System.Windows.Forms.GroupBox groupBoxLootXP;
        private System.Windows.Forms.Label labelLootXpMax;
        private System.Windows.Forms.NumericUpDown numericLootXpMin;
        private System.Windows.Forms.NumericUpDown numericLootXpMax;
        private System.Windows.Forms.Label labelLootXpMin;
        private System.Windows.Forms.DataGridView dataGridViewLootImport;
        private System.Windows.Forms.DataGridView dataGridViewCastables;
        private System.Windows.Forms.Label labelLootImport;
        private System.Windows.Forms.CheckBox checkBoxHasIntents;
        private System.Windows.Forms.CheckBox checkBoxHasCastables;
        private System.Windows.Forms.CheckBox checkBoxHasLootImport;
        private System.Windows.Forms.CheckBox checkBoxHasLootTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxIntentHasNpc;
        private System.Windows.Forms.GroupBox groupBoxIntentMonster;
        private System.Windows.Forms.Label labelIntentMonsterType;
        private System.Windows.Forms.ComboBox comboBoxIntentMonsterType;
        private System.Windows.Forms.Label labelIntentMonsterValue;
        private System.Windows.Forms.TextBox textBoxIntentMonsterValue;
        private System.Windows.Forms.CheckBox checkBoxIntentHasMonster;
        private System.Windows.Forms.GroupBox groupBoxIntentPlayer;
        private System.Windows.Forms.CheckBox checkBoxIntentHasPlayer;
    }
}