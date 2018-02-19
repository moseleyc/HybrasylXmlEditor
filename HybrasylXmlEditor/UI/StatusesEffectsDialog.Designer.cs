using Hybrasyl.Statuses;

namespace HybrasylXmlEditor.UI
{
    partial class StatusesEffectsDialog
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
            this.groupBoxStatusEffects = new System.Windows.Forms.GroupBox();
            this.labelTitleValue = new System.Windows.Forms.Label();
            this.groupBoxConditions = new System.Windows.Forms.GroupBox();
            this.listBoxCondUnset = new System.Windows.Forms.ListBox();
            this.listBoxCondSet = new System.Windows.Forms.ListBox();
            this.labelConUnset = new System.Windows.Forms.Label();
            this.labelConSet = new System.Windows.Forms.Label();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.textBoxMessagesSource = new System.Windows.Forms.TextBox();
            this.labelMessagesSource = new System.Windows.Forms.Label();
            this.textBoxMessagesGroup = new System.Windows.Forms.TextBox();
            this.labelMessagesGroup = new System.Windows.Forms.Label();
            this.textBoxMessagesSay = new System.Windows.Forms.TextBox();
            this.labelMessagesSay = new System.Windows.Forms.Label();
            this.textBoxMessagesShout = new System.Windows.Forms.TextBox();
            this.labelMessagesShout = new System.Windows.Forms.Label();
            this.textBoxMessagesTarget = new System.Windows.Forms.TextBox();
            this.labelMessagesTarget = new System.Windows.Forms.Label();
            this.groupBoxSound = new System.Windows.Forms.GroupBox();
            this.textBoxSound_Id = new System.Windows.Forms.TextBox();
            this.labelSound_Id = new System.Windows.Forms.Label();
            this.groupBoxHeal = new System.Windows.Forms.GroupBox();
            this.groupBoxHealSimple = new System.Windows.Forms.GroupBox();
            this.textBoxHealSimpleMax = new System.Windows.Forms.TextBox();
            this.textBoxHealSimpleMin = new System.Windows.Forms.TextBox();
            this.labelHealSimpleMax = new System.Windows.Forms.Label();
            this.labelHealSimpleMin = new System.Windows.Forms.Label();
            this.textBoxHealFormula = new System.Windows.Forms.TextBox();
            this.labelHealFormula = new System.Windows.Forms.Label();
            this.groupBoxDamage = new System.Windows.Forms.GroupBox();
            this.labelDamageType = new System.Windows.Forms.Label();
            this.comboBoxDamageType = new System.Windows.Forms.ComboBox();
            this.textBoxDamageFormula = new System.Windows.Forms.TextBox();
            this.labelDamageFormula = new System.Windows.Forms.Label();
            this.groupBoxDamageSimple = new System.Windows.Forms.GroupBox();
            this.textBoxDamageSimpleMax = new System.Windows.Forms.TextBox();
            this.textBoxDamageSimpleMin = new System.Windows.Forms.TextBox();
            this.labelDamageSimpleMax = new System.Windows.Forms.Label();
            this.labelDamageSimpleMin = new System.Windows.Forms.Label();
            this.labelDamageFlags = new System.Windows.Forms.Label();
            this.comboBoxDamageFlags = new System.Windows.Forms.ComboBox();
            this.groupBoxStatModifiers = new System.Windows.Forms.GroupBox();
            this.labelStatModDmgType = new System.Windows.Forms.Label();
            this.comboBoxStatModDmgType = new System.Windows.Forms.ComboBox();
            this.textBoxStatModDmg = new System.Windows.Forms.TextBox();
            this.textBoxStatModStr = new System.Windows.Forms.TextBox();
            this.textBoxStatModReflectIntensity = new System.Windows.Forms.TextBox();
            this.textBoxStatModReflectChance = new System.Windows.Forms.TextBox();
            this.textBoxStatModHealMod = new System.Windows.Forms.TextBox();
            this.textBoxStatModDmgMod = new System.Windows.Forms.TextBox();
            this.textBoxStatModMr = new System.Windows.Forms.TextBox();
            this.textBoxStatModRegen = new System.Windows.Forms.TextBox();
            this.textBoxStatModAc = new System.Windows.Forms.TextBox();
            this.textBoxStatModHit = new System.Windows.Forms.TextBox();
            this.textBoxStatModMp = new System.Windows.Forms.TextBox();
            this.textBoxStatModHp = new System.Windows.Forms.TextBox();
            this.textBoxStatModDex = new System.Windows.Forms.TextBox();
            this.textBoxStatModCon = new System.Windows.Forms.TextBox();
            this.textBoxStatModWis = new System.Windows.Forms.TextBox();
            this.textBoxStatModInt = new System.Windows.Forms.TextBox();
            this.comboBoxStatModOffElement = new System.Windows.Forms.ComboBox();
            this.comboBoxStatModDefElement = new System.Windows.Forms.ComboBox();
            this.labelStatModDefElement = new System.Windows.Forms.Label();
            this.labelStatModOffElement = new System.Windows.Forms.Label();
            this.ReflectIntensity = new System.Windows.Forms.Label();
            this.labelStatModReflectChance = new System.Windows.Forms.Label();
            this.labelStatModHealMod = new System.Windows.Forms.Label();
            this.labelStatModDmgMod = new System.Windows.Forms.Label();
            this.labelStatModMr = new System.Windows.Forms.Label();
            this.labelStatModRegen = new System.Windows.Forms.Label();
            this.labelStatModAc = new System.Windows.Forms.Label();
            this.labelStatModDmg = new System.Windows.Forms.Label();
            this.labelStatModHit = new System.Windows.Forms.Label();
            this.labelStatModMp = new System.Windows.Forms.Label();
            this.labelStatModHp = new System.Windows.Forms.Label();
            this.labelStatModDex = new System.Windows.Forms.Label();
            this.labelStatModCon = new System.Windows.Forms.Label();
            this.labelStatModWis = new System.Windows.Forms.Label();
            this.labelStatModInt = new System.Windows.Forms.Label();
            this.labelStatModStr = new System.Windows.Forms.Label();
            this.groupBoxAnimations = new System.Windows.Forms.GroupBox();
            this.groupBoxAnimationSpellEffects = new System.Windows.Forms.GroupBox();
            this.textBoxAnimationSpellEffect_Speed = new System.Windows.Forms.TextBox();
            this.textBoxAnimationSpellEffect_Id = new System.Windows.Forms.TextBox();
            this.labelAnimationSpellEffect_Id = new System.Windows.Forms.Label();
            this.labelAnimationSpellEffect_Speed = new System.Windows.Forms.Label();
            this.groupBoxAnimationTarget = new System.Windows.Forms.GroupBox();
            this.textBoxAnimationTarget_Speed = new System.Windows.Forms.TextBox();
            this.textBoxAnimationTarget_Id = new System.Windows.Forms.TextBox();
            this.labelAnimationTarget_Id = new System.Windows.Forms.Label();
            this.labelAnimationTarget_Speed = new System.Windows.Forms.Label();
            this.buttonCloseReturn = new System.Windows.Forms.Button();
            this.groupBoxStatusEffects.SuspendLayout();
            this.groupBoxConditions.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            this.groupBoxSound.SuspendLayout();
            this.groupBoxHeal.SuspendLayout();
            this.groupBoxHealSimple.SuspendLayout();
            this.groupBoxDamage.SuspendLayout();
            this.groupBoxDamageSimple.SuspendLayout();
            this.groupBoxStatModifiers.SuspendLayout();
            this.groupBoxAnimations.SuspendLayout();
            this.groupBoxAnimationSpellEffects.SuspendLayout();
            this.groupBoxAnimationTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStatusEffects
            // 
            this.groupBoxStatusEffects.Controls.Add(this.labelTitleValue);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxConditions);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxMessages);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxSound);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxHeal);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxDamage);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxStatModifiers);
            this.groupBoxStatusEffects.Controls.Add(this.groupBoxAnimations);
            this.groupBoxStatusEffects.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStatusEffects.Name = "groupBoxStatusEffects";
            this.groupBoxStatusEffects.Size = new System.Drawing.Size(561, 665);
            this.groupBoxStatusEffects.TabIndex = 0;
            this.groupBoxStatusEffects.TabStop = false;
            this.groupBoxStatusEffects.Text = "Effects";
            // 
            // labelTitleValue
            // 
            this.labelTitleValue.AutoSize = true;
            this.labelTitleValue.Location = new System.Drawing.Point(227, 27);
            this.labelTitleValue.Name = "labelTitleValue";
            this.labelTitleValue.Size = new System.Drawing.Size(42, 13);
            this.labelTitleValue.TabIndex = 0;
            this.labelTitleValue.Text = "VALUE";
            // 
            // groupBoxConditions
            // 
            this.groupBoxConditions.Controls.Add(this.listBoxCondUnset);
            this.groupBoxConditions.Controls.Add(this.listBoxCondSet);
            this.groupBoxConditions.Controls.Add(this.labelConUnset);
            this.groupBoxConditions.Controls.Add(this.labelConSet);
            this.groupBoxConditions.Location = new System.Drawing.Point(258, 398);
            this.groupBoxConditions.Name = "groupBoxConditions";
            this.groupBoxConditions.Size = new System.Drawing.Size(288, 260);
            this.groupBoxConditions.TabIndex = 7;
            this.groupBoxConditions.TabStop = false;
            this.groupBoxConditions.Text = "Conditions";
            // 
            // listBoxCondUnset
            // 
            this.listBoxCondUnset.FormattingEnabled = true;
            this.listBoxCondUnset.Items.AddRange(new object[] {
            Hybrasyl.Statuses.CreatureCondition.Freeze,
            Hybrasyl.Statuses.CreatureCondition.Sleep,
            Hybrasyl.Statuses.CreatureCondition.Paralyze,
            Hybrasyl.Statuses.CreatureCondition.Blind,
            Hybrasyl.Statuses.CreatureCondition.Coma,
            Hybrasyl.Statuses.CreatureCondition.Poison,
            Hybrasyl.Statuses.CreatureCondition.Mist,
            Hybrasyl.Statuses.CreatureCondition.Regen,
            Hybrasyl.Statuses.CreatureCondition.Sight,
            Hybrasyl.Statuses.CreatureCondition.Invisible,
            Hybrasyl.Statuses.CreatureCondition.Mute,
            Hybrasyl.Statuses.CreatureCondition.ReflectPhysical,
            Hybrasyl.Statuses.CreatureCondition.ReflectMagical,
            Hybrasyl.Statuses.CreatureCondition.Invulnerable,
            Hybrasyl.Statuses.CreatureCondition.Charm,
            Hybrasyl.Statuses.CreatureCondition.IncreaseDamage,
            Hybrasyl.Statuses.CreatureCondition.ReduceDamage,
            Hybrasyl.Statuses.CreatureCondition.AbsorbSpell,
            Hybrasyl.Statuses.CreatureCondition.ProhibitItemUse,
            Hybrasyl.Statuses.CreatureCondition.ProhibitEquipChange,
            Hybrasyl.Statuses.CreatureCondition.ProhibitSpeech,
            Hybrasyl.Statuses.CreatureCondition.ProhibitWhisper,
            Hybrasyl.Statuses.CreatureCondition.ProhibitShout});
            this.listBoxCondUnset.Location = new System.Drawing.Point(6, 154);
            this.listBoxCondUnset.MultiColumn = true;
            this.listBoxCondUnset.Name = "listBoxCondUnset";
            this.listBoxCondUnset.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCondUnset.Size = new System.Drawing.Size(273, 95);
            this.listBoxCondUnset.TabIndex = 3;
            // 
            // listBoxCondSet
            // 
            this.listBoxCondSet.FormattingEnabled = true;
            this.listBoxCondSet.Items.AddRange(new object[] {
            Hybrasyl.Statuses.CreatureCondition.Freeze,
            Hybrasyl.Statuses.CreatureCondition.Sleep,
            Hybrasyl.Statuses.CreatureCondition.Paralyze,
            Hybrasyl.Statuses.CreatureCondition.Blind,
            Hybrasyl.Statuses.CreatureCondition.Coma,
            Hybrasyl.Statuses.CreatureCondition.Poison,
            Hybrasyl.Statuses.CreatureCondition.Mist,
            Hybrasyl.Statuses.CreatureCondition.Regen,
            Hybrasyl.Statuses.CreatureCondition.Sight,
            Hybrasyl.Statuses.CreatureCondition.Invisible,
            Hybrasyl.Statuses.CreatureCondition.Mute,
            Hybrasyl.Statuses.CreatureCondition.ReflectPhysical,
            Hybrasyl.Statuses.CreatureCondition.ReflectMagical,
            Hybrasyl.Statuses.CreatureCondition.Invulnerable,
            Hybrasyl.Statuses.CreatureCondition.Charm,
            Hybrasyl.Statuses.CreatureCondition.IncreaseDamage,
            Hybrasyl.Statuses.CreatureCondition.ReduceDamage,
            Hybrasyl.Statuses.CreatureCondition.AbsorbSpell,
            Hybrasyl.Statuses.CreatureCondition.ProhibitItemUse,
            Hybrasyl.Statuses.CreatureCondition.ProhibitEquipChange,
            Hybrasyl.Statuses.CreatureCondition.ProhibitSpeech,
            Hybrasyl.Statuses.CreatureCondition.ProhibitWhisper,
            Hybrasyl.Statuses.CreatureCondition.ProhibitShout});
            this.listBoxCondSet.Location = new System.Drawing.Point(9, 32);
            this.listBoxCondSet.MultiColumn = true;
            this.listBoxCondSet.Name = "listBoxCondSet";
            this.listBoxCondSet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCondSet.Size = new System.Drawing.Size(273, 95);
            this.listBoxCondSet.TabIndex = 1;
            // 
            // labelConUnset
            // 
            this.labelConUnset.AutoSize = true;
            this.labelConUnset.Location = new System.Drawing.Point(6, 138);
            this.labelConUnset.Name = "labelConUnset";
            this.labelConUnset.Size = new System.Drawing.Size(38, 13);
            this.labelConUnset.TabIndex = 2;
            this.labelConUnset.Text = "Unset:";
            // 
            // labelConSet
            // 
            this.labelConSet.AutoSize = true;
            this.labelConSet.Location = new System.Drawing.Point(6, 16);
            this.labelConSet.Name = "labelConSet";
            this.labelConSet.Size = new System.Drawing.Size(26, 13);
            this.labelConSet.TabIndex = 0;
            this.labelConSet.Text = "Set:";
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.textBoxMessagesSource);
            this.groupBoxMessages.Controls.Add(this.labelMessagesSource);
            this.groupBoxMessages.Controls.Add(this.textBoxMessagesGroup);
            this.groupBoxMessages.Controls.Add(this.labelMessagesGroup);
            this.groupBoxMessages.Controls.Add(this.textBoxMessagesSay);
            this.groupBoxMessages.Controls.Add(this.labelMessagesSay);
            this.groupBoxMessages.Controls.Add(this.textBoxMessagesShout);
            this.groupBoxMessages.Controls.Add(this.labelMessagesShout);
            this.groupBoxMessages.Controls.Add(this.textBoxMessagesTarget);
            this.groupBoxMessages.Controls.Add(this.labelMessagesTarget);
            this.groupBoxMessages.Location = new System.Drawing.Point(6, 234);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(246, 148);
            this.groupBoxMessages.TabIndex = 3;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // textBoxMessagesSource
            // 
            this.textBoxMessagesSource.Location = new System.Drawing.Point(53, 42);
            this.textBoxMessagesSource.Name = "textBoxMessagesSource";
            this.textBoxMessagesSource.Size = new System.Drawing.Size(183, 20);
            this.textBoxMessagesSource.TabIndex = 3;
            // 
            // labelMessagesSource
            // 
            this.labelMessagesSource.AutoSize = true;
            this.labelMessagesSource.Location = new System.Drawing.Point(6, 45);
            this.labelMessagesSource.Name = "labelMessagesSource";
            this.labelMessagesSource.Size = new System.Drawing.Size(44, 13);
            this.labelMessagesSource.TabIndex = 2;
            this.labelMessagesSource.Text = "Source:";
            // 
            // textBoxMessagesGroup
            // 
            this.textBoxMessagesGroup.Location = new System.Drawing.Point(53, 68);
            this.textBoxMessagesGroup.Name = "textBoxMessagesGroup";
            this.textBoxMessagesGroup.Size = new System.Drawing.Size(183, 20);
            this.textBoxMessagesGroup.TabIndex = 5;
            // 
            // labelMessagesGroup
            // 
            this.labelMessagesGroup.AutoSize = true;
            this.labelMessagesGroup.Location = new System.Drawing.Point(6, 71);
            this.labelMessagesGroup.Name = "labelMessagesGroup";
            this.labelMessagesGroup.Size = new System.Drawing.Size(39, 13);
            this.labelMessagesGroup.TabIndex = 4;
            this.labelMessagesGroup.Text = "Group:";
            // 
            // textBoxMessagesSay
            // 
            this.textBoxMessagesSay.Location = new System.Drawing.Point(53, 94);
            this.textBoxMessagesSay.Name = "textBoxMessagesSay";
            this.textBoxMessagesSay.Size = new System.Drawing.Size(183, 20);
            this.textBoxMessagesSay.TabIndex = 7;
            // 
            // labelMessagesSay
            // 
            this.labelMessagesSay.AutoSize = true;
            this.labelMessagesSay.Location = new System.Drawing.Point(6, 97);
            this.labelMessagesSay.Name = "labelMessagesSay";
            this.labelMessagesSay.Size = new System.Drawing.Size(28, 13);
            this.labelMessagesSay.TabIndex = 6;
            this.labelMessagesSay.Text = "Say:";
            // 
            // textBoxMessagesShout
            // 
            this.textBoxMessagesShout.Location = new System.Drawing.Point(53, 120);
            this.textBoxMessagesShout.Name = "textBoxMessagesShout";
            this.textBoxMessagesShout.Size = new System.Drawing.Size(183, 20);
            this.textBoxMessagesShout.TabIndex = 9;
            // 
            // labelMessagesShout
            // 
            this.labelMessagesShout.AutoSize = true;
            this.labelMessagesShout.Location = new System.Drawing.Point(6, 123);
            this.labelMessagesShout.Name = "labelMessagesShout";
            this.labelMessagesShout.Size = new System.Drawing.Size(38, 13);
            this.labelMessagesShout.TabIndex = 8;
            this.labelMessagesShout.Text = "Shout:";
            // 
            // textBoxMessagesTarget
            // 
            this.textBoxMessagesTarget.Location = new System.Drawing.Point(53, 16);
            this.textBoxMessagesTarget.Name = "textBoxMessagesTarget";
            this.textBoxMessagesTarget.Size = new System.Drawing.Size(183, 20);
            this.textBoxMessagesTarget.TabIndex = 1;
            // 
            // labelMessagesTarget
            // 
            this.labelMessagesTarget.AutoSize = true;
            this.labelMessagesTarget.Location = new System.Drawing.Point(6, 19);
            this.labelMessagesTarget.Name = "labelMessagesTarget";
            this.labelMessagesTarget.Size = new System.Drawing.Size(41, 13);
            this.labelMessagesTarget.TabIndex = 0;
            this.labelMessagesTarget.Text = "Target:";
            // 
            // groupBoxSound
            // 
            this.groupBoxSound.Controls.Add(this.textBoxSound_Id);
            this.groupBoxSound.Controls.Add(this.labelSound_Id);
            this.groupBoxSound.Location = new System.Drawing.Point(6, 186);
            this.groupBoxSound.Name = "groupBoxSound";
            this.groupBoxSound.Size = new System.Drawing.Size(246, 42);
            this.groupBoxSound.TabIndex = 2;
            this.groupBoxSound.TabStop = false;
            this.groupBoxSound.Text = "Sound";
            // 
            // textBoxSound_Id
            // 
            this.textBoxSound_Id.Location = new System.Drawing.Point(31, 13);
            this.textBoxSound_Id.Name = "textBoxSound_Id";
            this.textBoxSound_Id.Size = new System.Drawing.Size(64, 20);
            this.textBoxSound_Id.TabIndex = 1;
            this.textBoxSound_Id.Leave += new System.EventHandler(this.textBoxByteValidation_Leave);
            // 
            // labelSound_Id
            // 
            this.labelSound_Id.AutoSize = true;
            this.labelSound_Id.Location = new System.Drawing.Point(6, 16);
            this.labelSound_Id.Name = "labelSound_Id";
            this.labelSound_Id.Size = new System.Drawing.Size(19, 13);
            this.labelSound_Id.TabIndex = 0;
            this.labelSound_Id.Text = "Id:";
            // 
            // groupBoxHeal
            // 
            this.groupBoxHeal.Controls.Add(this.groupBoxHealSimple);
            this.groupBoxHeal.Controls.Add(this.textBoxHealFormula);
            this.groupBoxHeal.Controls.Add(this.labelHealFormula);
            this.groupBoxHeal.Location = new System.Drawing.Point(6, 388);
            this.groupBoxHeal.Name = "groupBoxHeal";
            this.groupBoxHeal.Size = new System.Drawing.Size(246, 100);
            this.groupBoxHeal.TabIndex = 4;
            this.groupBoxHeal.TabStop = false;
            this.groupBoxHeal.Text = "Heal";
            // 
            // groupBoxHealSimple
            // 
            this.groupBoxHealSimple.Controls.Add(this.textBoxHealSimpleMax);
            this.groupBoxHealSimple.Controls.Add(this.textBoxHealSimpleMin);
            this.groupBoxHealSimple.Controls.Add(this.labelHealSimpleMax);
            this.groupBoxHealSimple.Controls.Add(this.labelHealSimpleMin);
            this.groupBoxHealSimple.Location = new System.Drawing.Point(6, 19);
            this.groupBoxHealSimple.Name = "groupBoxHealSimple";
            this.groupBoxHealSimple.Size = new System.Drawing.Size(230, 42);
            this.groupBoxHealSimple.TabIndex = 0;
            this.groupBoxHealSimple.TabStop = false;
            this.groupBoxHealSimple.Text = "Simple";
            // 
            // textBoxHealSimpleMax
            // 
            this.textBoxHealSimpleMax.Location = new System.Drawing.Point(157, 13);
            this.textBoxHealSimpleMax.Name = "textBoxHealSimpleMax";
            this.textBoxHealSimpleMax.Size = new System.Drawing.Size(64, 20);
            this.textBoxHealSimpleMax.TabIndex = 3;
            // 
            // textBoxHealSimpleMin
            // 
            this.textBoxHealSimpleMin.Location = new System.Drawing.Point(39, 13);
            this.textBoxHealSimpleMin.Name = "textBoxHealSimpleMin";
            this.textBoxHealSimpleMin.Size = new System.Drawing.Size(64, 20);
            this.textBoxHealSimpleMin.TabIndex = 1;
            // 
            // labelHealSimpleMax
            // 
            this.labelHealSimpleMax.AutoSize = true;
            this.labelHealSimpleMax.Location = new System.Drawing.Point(121, 16);
            this.labelHealSimpleMax.Name = "labelHealSimpleMax";
            this.labelHealSimpleMax.Size = new System.Drawing.Size(30, 13);
            this.labelHealSimpleMax.TabIndex = 2;
            this.labelHealSimpleMax.Text = "Max:";
            // 
            // labelHealSimpleMin
            // 
            this.labelHealSimpleMin.AutoSize = true;
            this.labelHealSimpleMin.Location = new System.Drawing.Point(6, 16);
            this.labelHealSimpleMin.Name = "labelHealSimpleMin";
            this.labelHealSimpleMin.Size = new System.Drawing.Size(27, 13);
            this.labelHealSimpleMin.TabIndex = 0;
            this.labelHealSimpleMin.Text = "Min:";
            // 
            // textBoxHealFormula
            // 
            this.textBoxHealFormula.Location = new System.Drawing.Point(53, 67);
            this.textBoxHealFormula.Name = "textBoxHealFormula";
            this.textBoxHealFormula.Size = new System.Drawing.Size(183, 20);
            this.textBoxHealFormula.TabIndex = 2;
            // 
            // labelHealFormula
            // 
            this.labelHealFormula.AutoSize = true;
            this.labelHealFormula.Location = new System.Drawing.Point(6, 70);
            this.labelHealFormula.Name = "labelHealFormula";
            this.labelHealFormula.Size = new System.Drawing.Size(47, 13);
            this.labelHealFormula.TabIndex = 1;
            this.labelHealFormula.Text = "Formula:";
            // 
            // groupBoxDamage
            // 
            this.groupBoxDamage.Controls.Add(this.labelDamageType);
            this.groupBoxDamage.Controls.Add(this.comboBoxDamageType);
            this.groupBoxDamage.Controls.Add(this.textBoxDamageFormula);
            this.groupBoxDamage.Controls.Add(this.labelDamageFormula);
            this.groupBoxDamage.Controls.Add(this.groupBoxDamageSimple);
            this.groupBoxDamage.Controls.Add(this.labelDamageFlags);
            this.groupBoxDamage.Controls.Add(this.comboBoxDamageFlags);
            this.groupBoxDamage.Location = new System.Drawing.Point(6, 494);
            this.groupBoxDamage.Name = "groupBoxDamage";
            this.groupBoxDamage.Size = new System.Drawing.Size(246, 164);
            this.groupBoxDamage.TabIndex = 5;
            this.groupBoxDamage.TabStop = false;
            this.groupBoxDamage.Text = "Damage";
            // 
            // labelDamageType
            // 
            this.labelDamageType.AutoSize = true;
            this.labelDamageType.Location = new System.Drawing.Point(9, 123);
            this.labelDamageType.Name = "labelDamageType";
            this.labelDamageType.Size = new System.Drawing.Size(34, 13);
            this.labelDamageType.TabIndex = 5;
            this.labelDamageType.Text = "Type:";
            // 
            // comboBoxDamageType
            // 
            this.comboBoxDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDamageType.FormattingEnabled = true;
            this.comboBoxDamageType.Items.AddRange(new object[] {
            Hybrasyl.Statuses.DamageType.Direct,
            Hybrasyl.Statuses.DamageType.Physical,
            Hybrasyl.Statuses.DamageType.Magical,
            Hybrasyl.Statuses.DamageType.Elemental});
            this.comboBoxDamageType.Location = new System.Drawing.Point(49, 120);
            this.comboBoxDamageType.Name = "comboBoxDamageType";
            this.comboBoxDamageType.Size = new System.Drawing.Size(187, 21);
            this.comboBoxDamageType.TabIndex = 6;
            // 
            // textBoxDamageFormula
            // 
            this.textBoxDamageFormula.Location = new System.Drawing.Point(53, 94);
            this.textBoxDamageFormula.Name = "textBoxDamageFormula";
            this.textBoxDamageFormula.Size = new System.Drawing.Size(183, 20);
            this.textBoxDamageFormula.TabIndex = 4;
            // 
            // labelDamageFormula
            // 
            this.labelDamageFormula.AutoSize = true;
            this.labelDamageFormula.Location = new System.Drawing.Point(6, 97);
            this.labelDamageFormula.Name = "labelDamageFormula";
            this.labelDamageFormula.Size = new System.Drawing.Size(47, 13);
            this.labelDamageFormula.TabIndex = 3;
            this.labelDamageFormula.Text = "Formula:";
            // 
            // groupBoxDamageSimple
            // 
            this.groupBoxDamageSimple.Controls.Add(this.textBoxDamageSimpleMax);
            this.groupBoxDamageSimple.Controls.Add(this.textBoxDamageSimpleMin);
            this.groupBoxDamageSimple.Controls.Add(this.labelDamageSimpleMax);
            this.groupBoxDamageSimple.Controls.Add(this.labelDamageSimpleMin);
            this.groupBoxDamageSimple.Location = new System.Drawing.Point(6, 46);
            this.groupBoxDamageSimple.Name = "groupBoxDamageSimple";
            this.groupBoxDamageSimple.Size = new System.Drawing.Size(230, 42);
            this.groupBoxDamageSimple.TabIndex = 2;
            this.groupBoxDamageSimple.TabStop = false;
            this.groupBoxDamageSimple.Text = "Simple";
            // 
            // textBoxDamageSimpleMax
            // 
            this.textBoxDamageSimpleMax.Location = new System.Drawing.Point(157, 13);
            this.textBoxDamageSimpleMax.Name = "textBoxDamageSimpleMax";
            this.textBoxDamageSimpleMax.Size = new System.Drawing.Size(64, 20);
            this.textBoxDamageSimpleMax.TabIndex = 3;
            // 
            // textBoxDamageSimpleMin
            // 
            this.textBoxDamageSimpleMin.Location = new System.Drawing.Point(39, 13);
            this.textBoxDamageSimpleMin.Name = "textBoxDamageSimpleMin";
            this.textBoxDamageSimpleMin.Size = new System.Drawing.Size(64, 20);
            this.textBoxDamageSimpleMin.TabIndex = 1;
            // 
            // labelDamageSimpleMax
            // 
            this.labelDamageSimpleMax.AutoSize = true;
            this.labelDamageSimpleMax.Location = new System.Drawing.Point(121, 16);
            this.labelDamageSimpleMax.Name = "labelDamageSimpleMax";
            this.labelDamageSimpleMax.Size = new System.Drawing.Size(30, 13);
            this.labelDamageSimpleMax.TabIndex = 2;
            this.labelDamageSimpleMax.Text = "Max:";
            // 
            // labelDamageSimpleMin
            // 
            this.labelDamageSimpleMin.AutoSize = true;
            this.labelDamageSimpleMin.Location = new System.Drawing.Point(6, 16);
            this.labelDamageSimpleMin.Name = "labelDamageSimpleMin";
            this.labelDamageSimpleMin.Size = new System.Drawing.Size(27, 13);
            this.labelDamageSimpleMin.TabIndex = 0;
            this.labelDamageSimpleMin.Text = "Min:";
            // 
            // labelDamageFlags
            // 
            this.labelDamageFlags.AutoSize = true;
            this.labelDamageFlags.Location = new System.Drawing.Point(9, 22);
            this.labelDamageFlags.Name = "labelDamageFlags";
            this.labelDamageFlags.Size = new System.Drawing.Size(60, 13);
            this.labelDamageFlags.TabIndex = 0;
            this.labelDamageFlags.Text = "Dmg Flags:";
            // 
            // comboBoxDamageFlags
            // 
            this.comboBoxDamageFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDamageFlags.FormattingEnabled = true;
            this.comboBoxDamageFlags.Items.AddRange(new object[] {
            Hybrasyl.Statuses.DamageFlags.None,
            Hybrasyl.Statuses.DamageFlags.Scaled,
            Hybrasyl.Statuses.DamageFlags.Resistance,
            Hybrasyl.Statuses.DamageFlags.Threat,
            Hybrasyl.Statuses.DamageFlags.Nonlethal});
            this.comboBoxDamageFlags.Location = new System.Drawing.Point(75, 19);
            this.comboBoxDamageFlags.Name = "comboBoxDamageFlags";
            this.comboBoxDamageFlags.Size = new System.Drawing.Size(161, 21);
            this.comboBoxDamageFlags.TabIndex = 1;
            // 
            // groupBoxStatModifiers
            // 
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModDmgType);
            this.groupBoxStatModifiers.Controls.Add(this.comboBoxStatModDmgType);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModDmg);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModStr);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModReflectIntensity);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModReflectChance);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModHealMod);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModDmgMod);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModMr);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModRegen);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModAc);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModHit);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModMp);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModHp);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModDex);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModCon);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModWis);
            this.groupBoxStatModifiers.Controls.Add(this.textBoxStatModInt);
            this.groupBoxStatModifiers.Controls.Add(this.comboBoxStatModOffElement);
            this.groupBoxStatModifiers.Controls.Add(this.comboBoxStatModDefElement);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModDefElement);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModOffElement);
            this.groupBoxStatModifiers.Controls.Add(this.ReflectIntensity);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModReflectChance);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModHealMod);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModDmgMod);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModMr);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModRegen);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModAc);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModDmg);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModHit);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModMp);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModHp);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModDex);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModCon);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModWis);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModInt);
            this.groupBoxStatModifiers.Controls.Add(this.labelStatModStr);
            this.groupBoxStatModifiers.Location = new System.Drawing.Point(258, 66);
            this.groupBoxStatModifiers.Name = "groupBoxStatModifiers";
            this.groupBoxStatModifiers.Size = new System.Drawing.Size(288, 319);
            this.groupBoxStatModifiers.TabIndex = 6;
            this.groupBoxStatModifiers.TabStop = false;
            this.groupBoxStatModifiers.Text = "Stat Modifiers";
            // 
            // labelStatModDmgType
            // 
            this.labelStatModDmgType.AutoSize = true;
            this.labelStatModDmgType.Location = new System.Drawing.Point(33, 286);
            this.labelStatModDmgType.Name = "labelStatModDmgType";
            this.labelStatModDmgType.Size = new System.Drawing.Size(77, 13);
            this.labelStatModDmgType.TabIndex = 36;
            this.labelStatModDmgType.Text = "Damage Type:";
            // 
            // comboBoxStatModDmgType
            // 
            this.comboBoxStatModDmgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatModDmgType.FormattingEnabled = true;
            this.comboBoxStatModDmgType.Items.AddRange(new object[] {
            Hybrasyl.Statuses.DamageType.Direct,
            Hybrasyl.Statuses.DamageType.Physical,
            Hybrasyl.Statuses.DamageType.Magical,
            Hybrasyl.Statuses.DamageType.Elemental});
            this.comboBoxStatModDmgType.Location = new System.Drawing.Point(116, 283);
            this.comboBoxStatModDmgType.Name = "comboBoxStatModDmgType";
            this.comboBoxStatModDmgType.Size = new System.Drawing.Size(147, 21);
            this.comboBoxStatModDmgType.TabIndex = 37;
            // 
            // textBoxStatModDmg
            // 
            this.textBoxStatModDmg.Location = new System.Drawing.Point(202, 21);
            this.textBoxStatModDmg.Name = "textBoxStatModDmg";
            this.textBoxStatModDmg.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModDmg.TabIndex = 17;
            this.textBoxStatModDmg.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModStr
            // 
            this.textBoxStatModStr.Location = new System.Drawing.Point(43, 21);
            this.textBoxStatModStr.Name = "textBoxStatModStr";
            this.textBoxStatModStr.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModStr.TabIndex = 1;
            this.textBoxStatModStr.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModReflectIntensity
            // 
            this.textBoxStatModReflectIntensity.Location = new System.Drawing.Point(202, 203);
            this.textBoxStatModReflectIntensity.Name = "textBoxStatModReflectIntensity";
            this.textBoxStatModReflectIntensity.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModReflectIntensity.TabIndex = 31;
            this.textBoxStatModReflectIntensity.Leave += new System.EventHandler(this.textBoxFloatValidation_Leave);
            // 
            // textBoxStatModReflectChance
            // 
            this.textBoxStatModReflectChance.Location = new System.Drawing.Point(202, 177);
            this.textBoxStatModReflectChance.Name = "textBoxStatModReflectChance";
            this.textBoxStatModReflectChance.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModReflectChance.TabIndex = 29;
            this.textBoxStatModReflectChance.Leave += new System.EventHandler(this.textBoxFloatValidation_Leave);
            // 
            // textBoxStatModHealMod
            // 
            this.textBoxStatModHealMod.Location = new System.Drawing.Point(202, 151);
            this.textBoxStatModHealMod.Name = "textBoxStatModHealMod";
            this.textBoxStatModHealMod.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModHealMod.TabIndex = 27;
            this.textBoxStatModHealMod.Leave += new System.EventHandler(this.textBoxFloatValidation_Leave);
            // 
            // textBoxStatModDmgMod
            // 
            this.textBoxStatModDmgMod.Location = new System.Drawing.Point(202, 125);
            this.textBoxStatModDmgMod.Name = "textBoxStatModDmgMod";
            this.textBoxStatModDmgMod.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModDmgMod.TabIndex = 25;
            this.textBoxStatModDmgMod.Leave += new System.EventHandler(this.textBoxFloatValidation_Leave);
            // 
            // textBoxStatModMr
            // 
            this.textBoxStatModMr.Location = new System.Drawing.Point(202, 99);
            this.textBoxStatModMr.Name = "textBoxStatModMr";
            this.textBoxStatModMr.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModMr.TabIndex = 23;
            this.textBoxStatModMr.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModRegen
            // 
            this.textBoxStatModRegen.Location = new System.Drawing.Point(202, 73);
            this.textBoxStatModRegen.Name = "textBoxStatModRegen";
            this.textBoxStatModRegen.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModRegen.TabIndex = 21;
            this.textBoxStatModRegen.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModAc
            // 
            this.textBoxStatModAc.Location = new System.Drawing.Point(202, 47);
            this.textBoxStatModAc.Name = "textBoxStatModAc";
            this.textBoxStatModAc.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModAc.TabIndex = 19;
            this.textBoxStatModAc.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModHit
            // 
            this.textBoxStatModHit.Location = new System.Drawing.Point(43, 203);
            this.textBoxStatModHit.Name = "textBoxStatModHit";
            this.textBoxStatModHit.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModHit.TabIndex = 15;
            this.textBoxStatModHit.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModMp
            // 
            this.textBoxStatModMp.Location = new System.Drawing.Point(43, 177);
            this.textBoxStatModMp.Name = "textBoxStatModMp";
            this.textBoxStatModMp.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModMp.TabIndex = 13;
            this.textBoxStatModMp.Leave += new System.EventHandler(this.textBoxIntValidation_Leave);
            // 
            // textBoxStatModHp
            // 
            this.textBoxStatModHp.Location = new System.Drawing.Point(43, 151);
            this.textBoxStatModHp.Name = "textBoxStatModHp";
            this.textBoxStatModHp.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModHp.TabIndex = 11;
            this.textBoxStatModHp.Leave += new System.EventHandler(this.textBoxIntValidation_Leave);
            // 
            // textBoxStatModDex
            // 
            this.textBoxStatModDex.Location = new System.Drawing.Point(43, 125);
            this.textBoxStatModDex.Name = "textBoxStatModDex";
            this.textBoxStatModDex.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModDex.TabIndex = 9;
            this.textBoxStatModDex.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModCon
            // 
            this.textBoxStatModCon.Location = new System.Drawing.Point(43, 99);
            this.textBoxStatModCon.Name = "textBoxStatModCon";
            this.textBoxStatModCon.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModCon.TabIndex = 7;
            this.textBoxStatModCon.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModWis
            // 
            this.textBoxStatModWis.Location = new System.Drawing.Point(43, 73);
            this.textBoxStatModWis.Name = "textBoxStatModWis";
            this.textBoxStatModWis.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModWis.TabIndex = 5;
            this.textBoxStatModWis.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // textBoxStatModInt
            // 
            this.textBoxStatModInt.Location = new System.Drawing.Point(43, 47);
            this.textBoxStatModInt.Name = "textBoxStatModInt";
            this.textBoxStatModInt.Size = new System.Drawing.Size(64, 20);
            this.textBoxStatModInt.TabIndex = 3;
            this.textBoxStatModInt.Leave += new System.EventHandler(this.textBoxSByteValidation_Leave);
            // 
            // comboBoxStatModOffElement
            // 
            this.comboBoxStatModOffElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatModOffElement.FormattingEnabled = true;
            this.comboBoxStatModOffElement.Items.AddRange(new object[] {
            Hybrasyl.Statuses.Element.None,
            Hybrasyl.Statuses.Element.Fire,
            Hybrasyl.Statuses.Element.Water,
            Hybrasyl.Statuses.Element.Wind,
            Hybrasyl.Statuses.Element.Earth,
            Hybrasyl.Statuses.Element.Light,
            Hybrasyl.Statuses.Element.Dark,
            Hybrasyl.Statuses.Element.Wood,
            Hybrasyl.Statuses.Element.Metal,
            Hybrasyl.Statuses.Element.Undead,
            Hybrasyl.Statuses.Element.Random});
            this.comboBoxStatModOffElement.Location = new System.Drawing.Point(116, 229);
            this.comboBoxStatModOffElement.Name = "comboBoxStatModOffElement";
            this.comboBoxStatModOffElement.Size = new System.Drawing.Size(147, 21);
            this.comboBoxStatModOffElement.TabIndex = 33;
            // 
            // comboBoxStatModDefElement
            // 
            this.comboBoxStatModDefElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatModDefElement.FormattingEnabled = true;
            this.comboBoxStatModDefElement.Items.AddRange(new object[] {
            Hybrasyl.Statuses.Element.None,
            Hybrasyl.Statuses.Element.Fire,
            Hybrasyl.Statuses.Element.Water,
            Hybrasyl.Statuses.Element.Wind,
            Hybrasyl.Statuses.Element.Earth,
            Hybrasyl.Statuses.Element.Light,
            Hybrasyl.Statuses.Element.Dark,
            Hybrasyl.Statuses.Element.Wood,
            Hybrasyl.Statuses.Element.Metal,
            Hybrasyl.Statuses.Element.Undead,
            Hybrasyl.Statuses.Element.Random});
            this.comboBoxStatModDefElement.Location = new System.Drawing.Point(116, 255);
            this.comboBoxStatModDefElement.Name = "comboBoxStatModDefElement";
            this.comboBoxStatModDefElement.Size = new System.Drawing.Size(147, 21);
            this.comboBoxStatModDefElement.TabIndex = 35;
            // 
            // labelStatModDefElement
            // 
            this.labelStatModDefElement.AutoSize = true;
            this.labelStatModDefElement.Location = new System.Drawing.Point(11, 258);
            this.labelStatModDefElement.Name = "labelStatModDefElement";
            this.labelStatModDefElement.Size = new System.Drawing.Size(99, 13);
            this.labelStatModDefElement.TabIndex = 34;
            this.labelStatModDefElement.Text = "Defensive Element:";
            // 
            // labelStatModOffElement
            // 
            this.labelStatModOffElement.AutoSize = true;
            this.labelStatModOffElement.Location = new System.Drawing.Point(14, 232);
            this.labelStatModOffElement.Name = "labelStatModOffElement";
            this.labelStatModOffElement.Size = new System.Drawing.Size(96, 13);
            this.labelStatModOffElement.TabIndex = 32;
            this.labelStatModOffElement.Text = "Offensive Element:";
            // 
            // ReflectIntensity
            // 
            this.ReflectIntensity.AutoSize = true;
            this.ReflectIntensity.Location = new System.Drawing.Point(113, 206);
            this.ReflectIntensity.Name = "ReflectIntensity";
            this.ReflectIntensity.Size = new System.Drawing.Size(86, 13);
            this.ReflectIntensity.TabIndex = 30;
            this.ReflectIntensity.Text = "Reflect Intensity:";
            // 
            // labelStatModReflectChance
            // 
            this.labelStatModReflectChance.AutoSize = true;
            this.labelStatModReflectChance.Location = new System.Drawing.Point(115, 180);
            this.labelStatModReflectChance.Name = "labelStatModReflectChance";
            this.labelStatModReflectChance.Size = new System.Drawing.Size(84, 13);
            this.labelStatModReflectChance.TabIndex = 28;
            this.labelStatModReflectChance.Text = "Reflect Chance:";
            // 
            // labelStatModHealMod
            // 
            this.labelStatModHealMod.AutoSize = true;
            this.labelStatModHealMod.Location = new System.Drawing.Point(143, 154);
            this.labelStatModHealMod.Name = "labelStatModHealMod";
            this.labelStatModHealMod.Size = new System.Drawing.Size(56, 13);
            this.labelStatModHealMod.TabIndex = 26;
            this.labelStatModHealMod.Text = "Heal Mod:";
            // 
            // labelStatModDmgMod
            // 
            this.labelStatModDmgMod.AutoSize = true;
            this.labelStatModDmgMod.Location = new System.Drawing.Point(143, 128);
            this.labelStatModDmgMod.Name = "labelStatModDmgMod";
            this.labelStatModDmgMod.Size = new System.Drawing.Size(56, 13);
            this.labelStatModDmgMod.TabIndex = 24;
            this.labelStatModDmgMod.Text = "Dmg Mod:";
            // 
            // labelStatModMr
            // 
            this.labelStatModMr.AutoSize = true;
            this.labelStatModMr.Location = new System.Drawing.Point(177, 102);
            this.labelStatModMr.Name = "labelStatModMr";
            this.labelStatModMr.Size = new System.Drawing.Size(22, 13);
            this.labelStatModMr.TabIndex = 22;
            this.labelStatModMr.Text = "Mr:";
            // 
            // labelStatModRegen
            // 
            this.labelStatModRegen.AutoSize = true;
            this.labelStatModRegen.Location = new System.Drawing.Point(157, 76);
            this.labelStatModRegen.Name = "labelStatModRegen";
            this.labelStatModRegen.Size = new System.Drawing.Size(42, 13);
            this.labelStatModRegen.TabIndex = 20;
            this.labelStatModRegen.Text = "Regen:";
            // 
            // labelStatModAc
            // 
            this.labelStatModAc.AutoSize = true;
            this.labelStatModAc.Location = new System.Drawing.Point(176, 50);
            this.labelStatModAc.Name = "labelStatModAc";
            this.labelStatModAc.Size = new System.Drawing.Size(23, 13);
            this.labelStatModAc.TabIndex = 18;
            this.labelStatModAc.Text = "Ac:";
            // 
            // labelStatModDmg
            // 
            this.labelStatModDmg.AutoSize = true;
            this.labelStatModDmg.Location = new System.Drawing.Point(167, 24);
            this.labelStatModDmg.Name = "labelStatModDmg";
            this.labelStatModDmg.Size = new System.Drawing.Size(32, 13);
            this.labelStatModDmg.TabIndex = 16;
            this.labelStatModDmg.Text = "Dmg:";
            // 
            // labelStatModHit
            // 
            this.labelStatModHit.AutoSize = true;
            this.labelStatModHit.Location = new System.Drawing.Point(14, 206);
            this.labelStatModHit.Name = "labelStatModHit";
            this.labelStatModHit.Size = new System.Drawing.Size(23, 13);
            this.labelStatModHit.TabIndex = 14;
            this.labelStatModHit.Text = "Hit:";
            // 
            // labelStatModMp
            // 
            this.labelStatModMp.AutoSize = true;
            this.labelStatModMp.Location = new System.Drawing.Point(12, 180);
            this.labelStatModMp.Name = "labelStatModMp";
            this.labelStatModMp.Size = new System.Drawing.Size(25, 13);
            this.labelStatModMp.TabIndex = 12;
            this.labelStatModMp.Text = "Mp:";
            // 
            // labelStatModHp
            // 
            this.labelStatModHp.AutoSize = true;
            this.labelStatModHp.Location = new System.Drawing.Point(13, 154);
            this.labelStatModHp.Name = "labelStatModHp";
            this.labelStatModHp.Size = new System.Drawing.Size(24, 13);
            this.labelStatModHp.TabIndex = 10;
            this.labelStatModHp.Text = "Hp:";
            // 
            // labelStatModDex
            // 
            this.labelStatModDex.AutoSize = true;
            this.labelStatModDex.Location = new System.Drawing.Point(8, 128);
            this.labelStatModDex.Name = "labelStatModDex";
            this.labelStatModDex.Size = new System.Drawing.Size(29, 13);
            this.labelStatModDex.TabIndex = 8;
            this.labelStatModDex.Text = "Dex:";
            // 
            // labelStatModCon
            // 
            this.labelStatModCon.AutoSize = true;
            this.labelStatModCon.Location = new System.Drawing.Point(8, 102);
            this.labelStatModCon.Name = "labelStatModCon";
            this.labelStatModCon.Size = new System.Drawing.Size(29, 13);
            this.labelStatModCon.TabIndex = 6;
            this.labelStatModCon.Text = "Con:";
            // 
            // labelStatModWis
            // 
            this.labelStatModWis.AutoSize = true;
            this.labelStatModWis.Location = new System.Drawing.Point(9, 76);
            this.labelStatModWis.Name = "labelStatModWis";
            this.labelStatModWis.Size = new System.Drawing.Size(28, 13);
            this.labelStatModWis.TabIndex = 4;
            this.labelStatModWis.Text = "Wis:";
            // 
            // labelStatModInt
            // 
            this.labelStatModInt.AutoSize = true;
            this.labelStatModInt.Location = new System.Drawing.Point(15, 50);
            this.labelStatModInt.Name = "labelStatModInt";
            this.labelStatModInt.Size = new System.Drawing.Size(22, 13);
            this.labelStatModInt.TabIndex = 2;
            this.labelStatModInt.Text = "Int:";
            // 
            // labelStatModStr
            // 
            this.labelStatModStr.AutoSize = true;
            this.labelStatModStr.Location = new System.Drawing.Point(14, 24);
            this.labelStatModStr.Name = "labelStatModStr";
            this.labelStatModStr.Size = new System.Drawing.Size(23, 13);
            this.labelStatModStr.TabIndex = 0;
            this.labelStatModStr.Text = "Str:";
            // 
            // groupBoxAnimations
            // 
            this.groupBoxAnimations.Controls.Add(this.groupBoxAnimationSpellEffects);
            this.groupBoxAnimations.Controls.Add(this.groupBoxAnimationTarget);
            this.groupBoxAnimations.Location = new System.Drawing.Point(6, 66);
            this.groupBoxAnimations.Name = "groupBoxAnimations";
            this.groupBoxAnimations.Size = new System.Drawing.Size(246, 114);
            this.groupBoxAnimations.TabIndex = 1;
            this.groupBoxAnimations.TabStop = false;
            this.groupBoxAnimations.Text = "Animations";
            // 
            // groupBoxAnimationSpellEffects
            // 
            this.groupBoxAnimationSpellEffects.Controls.Add(this.textBoxAnimationSpellEffect_Speed);
            this.groupBoxAnimationSpellEffects.Controls.Add(this.textBoxAnimationSpellEffect_Id);
            this.groupBoxAnimationSpellEffects.Controls.Add(this.labelAnimationSpellEffect_Id);
            this.groupBoxAnimationSpellEffects.Controls.Add(this.labelAnimationSpellEffect_Speed);
            this.groupBoxAnimationSpellEffects.Location = new System.Drawing.Point(6, 65);
            this.groupBoxAnimationSpellEffects.Name = "groupBoxAnimationSpellEffects";
            this.groupBoxAnimationSpellEffects.Size = new System.Drawing.Size(230, 42);
            this.groupBoxAnimationSpellEffects.TabIndex = 1;
            this.groupBoxAnimationSpellEffects.TabStop = false;
            this.groupBoxAnimationSpellEffects.Text = "Spell Effects";
            // 
            // textBoxAnimationSpellEffect_Speed
            // 
            this.textBoxAnimationSpellEffect_Speed.Location = new System.Drawing.Point(148, 13);
            this.textBoxAnimationSpellEffect_Speed.Name = "textBoxAnimationSpellEffect_Speed";
            this.textBoxAnimationSpellEffect_Speed.Size = new System.Drawing.Size(64, 20);
            this.textBoxAnimationSpellEffect_Speed.TabIndex = 3;
            this.textBoxAnimationSpellEffect_Speed.Leave += new System.EventHandler(this.textBoxShortValidation_Leave);
            // 
            // textBoxAnimationSpellEffect_Id
            // 
            this.textBoxAnimationSpellEffect_Id.Location = new System.Drawing.Point(31, 13);
            this.textBoxAnimationSpellEffect_Id.Name = "textBoxAnimationSpellEffect_Id";
            this.textBoxAnimationSpellEffect_Id.Size = new System.Drawing.Size(64, 20);
            this.textBoxAnimationSpellEffect_Id.TabIndex = 1;
            this.textBoxAnimationSpellEffect_Id.Leave += new System.EventHandler(this.textBoxUShortValidation_Leave);
            // 
            // labelAnimationSpellEffect_Id
            // 
            this.labelAnimationSpellEffect_Id.AutoSize = true;
            this.labelAnimationSpellEffect_Id.Location = new System.Drawing.Point(6, 16);
            this.labelAnimationSpellEffect_Id.Name = "labelAnimationSpellEffect_Id";
            this.labelAnimationSpellEffect_Id.Size = new System.Drawing.Size(19, 13);
            this.labelAnimationSpellEffect_Id.TabIndex = 0;
            this.labelAnimationSpellEffect_Id.Text = "Id:";
            // 
            // labelAnimationSpellEffect_Speed
            // 
            this.labelAnimationSpellEffect_Speed.AutoSize = true;
            this.labelAnimationSpellEffect_Speed.Location = new System.Drawing.Point(101, 16);
            this.labelAnimationSpellEffect_Speed.Name = "labelAnimationSpellEffect_Speed";
            this.labelAnimationSpellEffect_Speed.Size = new System.Drawing.Size(41, 13);
            this.labelAnimationSpellEffect_Speed.TabIndex = 2;
            this.labelAnimationSpellEffect_Speed.Text = "Speed:";
            // 
            // groupBoxAnimationTarget
            // 
            this.groupBoxAnimationTarget.Controls.Add(this.textBoxAnimationTarget_Speed);
            this.groupBoxAnimationTarget.Controls.Add(this.textBoxAnimationTarget_Id);
            this.groupBoxAnimationTarget.Controls.Add(this.labelAnimationTarget_Id);
            this.groupBoxAnimationTarget.Controls.Add(this.labelAnimationTarget_Speed);
            this.groupBoxAnimationTarget.Location = new System.Drawing.Point(6, 19);
            this.groupBoxAnimationTarget.Name = "groupBoxAnimationTarget";
            this.groupBoxAnimationTarget.Size = new System.Drawing.Size(230, 40);
            this.groupBoxAnimationTarget.TabIndex = 0;
            this.groupBoxAnimationTarget.TabStop = false;
            this.groupBoxAnimationTarget.Text = "Target";
            // 
            // textBoxAnimationTarget_Speed
            // 
            this.textBoxAnimationTarget_Speed.Location = new System.Drawing.Point(148, 13);
            this.textBoxAnimationTarget_Speed.Name = "textBoxAnimationTarget_Speed";
            this.textBoxAnimationTarget_Speed.Size = new System.Drawing.Size(64, 20);
            this.textBoxAnimationTarget_Speed.TabIndex = 3;
            this.textBoxAnimationTarget_Speed.Leave += new System.EventHandler(this.textBoxShortValidation_Leave);
            // 
            // textBoxAnimationTarget_Id
            // 
            this.textBoxAnimationTarget_Id.Location = new System.Drawing.Point(31, 13);
            this.textBoxAnimationTarget_Id.Name = "textBoxAnimationTarget_Id";
            this.textBoxAnimationTarget_Id.Size = new System.Drawing.Size(64, 20);
            this.textBoxAnimationTarget_Id.TabIndex = 1;
            this.textBoxAnimationTarget_Id.Leave += new System.EventHandler(this.textBoxUShortValidation_Leave);
            // 
            // labelAnimationTarget_Id
            // 
            this.labelAnimationTarget_Id.AutoSize = true;
            this.labelAnimationTarget_Id.Location = new System.Drawing.Point(6, 16);
            this.labelAnimationTarget_Id.Name = "labelAnimationTarget_Id";
            this.labelAnimationTarget_Id.Size = new System.Drawing.Size(19, 13);
            this.labelAnimationTarget_Id.TabIndex = 0;
            this.labelAnimationTarget_Id.Text = "Id:";
            // 
            // labelAnimationTarget_Speed
            // 
            this.labelAnimationTarget_Speed.AutoSize = true;
            this.labelAnimationTarget_Speed.Location = new System.Drawing.Point(101, 16);
            this.labelAnimationTarget_Speed.Name = "labelAnimationTarget_Speed";
            this.labelAnimationTarget_Speed.Size = new System.Drawing.Size(41, 13);
            this.labelAnimationTarget_Speed.TabIndex = 2;
            this.labelAnimationTarget_Speed.Text = "Speed:";
            // 
            // buttonCloseReturn
            // 
            this.buttonCloseReturn.Location = new System.Drawing.Point(475, 683);
            this.buttonCloseReturn.Name = "buttonCloseReturn";
            this.buttonCloseReturn.Size = new System.Drawing.Size(98, 23);
            this.buttonCloseReturn.TabIndex = 1;
            this.buttonCloseReturn.Text = "Save && Return";
            this.buttonCloseReturn.UseVisualStyleBackColor = true;
            this.buttonCloseReturn.Click += new System.EventHandler(this.buttonCloseReturn_Click);
            // 
            // StatusesEffectsDialog
            // 
            this.AcceptButton = this.buttonCloseReturn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 713);
            this.Controls.Add(this.groupBoxStatusEffects);
            this.Controls.Add(this.buttonCloseReturn);
            this.Name = "StatusesEffectsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statuses Effects Dialog";
            this.Load += new System.EventHandler(this.StatusesEffectsDialog_Load);
            this.groupBoxStatusEffects.ResumeLayout(false);
            this.groupBoxStatusEffects.PerformLayout();
            this.groupBoxConditions.ResumeLayout(false);
            this.groupBoxConditions.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBoxSound.ResumeLayout(false);
            this.groupBoxSound.PerformLayout();
            this.groupBoxHeal.ResumeLayout(false);
            this.groupBoxHeal.PerformLayout();
            this.groupBoxHealSimple.ResumeLayout(false);
            this.groupBoxHealSimple.PerformLayout();
            this.groupBoxDamage.ResumeLayout(false);
            this.groupBoxDamage.PerformLayout();
            this.groupBoxDamageSimple.ResumeLayout(false);
            this.groupBoxDamageSimple.PerformLayout();
            this.groupBoxStatModifiers.ResumeLayout(false);
            this.groupBoxStatModifiers.PerformLayout();
            this.groupBoxAnimations.ResumeLayout(false);
            this.groupBoxAnimationSpellEffects.ResumeLayout(false);
            this.groupBoxAnimationSpellEffects.PerformLayout();
            this.groupBoxAnimationTarget.ResumeLayout(false);
            this.groupBoxAnimationTarget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStatusEffects;
        private System.Windows.Forms.GroupBox groupBoxConditions;
        private System.Windows.Forms.ListBox listBoxCondUnset;
        private System.Windows.Forms.ListBox listBoxCondSet;
        private System.Windows.Forms.Label labelConUnset;
        private System.Windows.Forms.Label labelConSet;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.TextBox textBoxMessagesSource;
        private System.Windows.Forms.Label labelMessagesSource;
        private System.Windows.Forms.TextBox textBoxMessagesGroup;
        private System.Windows.Forms.Label labelMessagesGroup;
        private System.Windows.Forms.TextBox textBoxMessagesSay;
        private System.Windows.Forms.Label labelMessagesSay;
        private System.Windows.Forms.TextBox textBoxMessagesShout;
        private System.Windows.Forms.Label labelMessagesShout;
        private System.Windows.Forms.TextBox textBoxMessagesTarget;
        private System.Windows.Forms.Label labelMessagesTarget;
        private System.Windows.Forms.GroupBox groupBoxSound;
        private System.Windows.Forms.Label labelSound_Id;
        private System.Windows.Forms.GroupBox groupBoxHeal;
        private System.Windows.Forms.GroupBox groupBoxHealSimple;
        private System.Windows.Forms.Label labelHealSimpleMax;
        private System.Windows.Forms.Label labelHealSimpleMin;
        private System.Windows.Forms.TextBox textBoxHealFormula;
        private System.Windows.Forms.Label labelHealFormula;
        private System.Windows.Forms.GroupBox groupBoxDamage;
        private System.Windows.Forms.Label labelDamageType;
        private System.Windows.Forms.ComboBox comboBoxDamageType;
        private System.Windows.Forms.TextBox textBoxDamageFormula;
        private System.Windows.Forms.Label labelDamageFormula;
        private System.Windows.Forms.GroupBox groupBoxDamageSimple;
        private System.Windows.Forms.Label labelDamageSimpleMax;
        private System.Windows.Forms.Label labelDamageSimpleMin;
        private System.Windows.Forms.Label labelDamageFlags;
        private System.Windows.Forms.ComboBox comboBoxDamageFlags;
        private System.Windows.Forms.GroupBox groupBoxStatModifiers;
        private System.Windows.Forms.ComboBox comboBoxStatModOffElement;
        private System.Windows.Forms.ComboBox comboBoxStatModDefElement;
        private System.Windows.Forms.Label labelStatModDefElement;
        private System.Windows.Forms.Label labelStatModOffElement;
        private System.Windows.Forms.Label ReflectIntensity;
        private System.Windows.Forms.Label labelStatModReflectChance;
        private System.Windows.Forms.Label labelStatModHealMod;
        private System.Windows.Forms.Label labelStatModDmgMod;
        private System.Windows.Forms.Label labelStatModMr;
        private System.Windows.Forms.Label labelStatModRegen;
        private System.Windows.Forms.Label labelStatModAc;
        private System.Windows.Forms.Label labelStatModDmg;
        private System.Windows.Forms.Label labelStatModHit;
        private System.Windows.Forms.Label labelStatModMp;
        private System.Windows.Forms.Label labelStatModHp;
        private System.Windows.Forms.Label labelStatModDex;
        private System.Windows.Forms.Label labelStatModCon;
        private System.Windows.Forms.Label labelStatModWis;
        private System.Windows.Forms.Label labelStatModInt;
        private System.Windows.Forms.Label labelStatModStr;
        private System.Windows.Forms.GroupBox groupBoxAnimations;
        private System.Windows.Forms.GroupBox groupBoxAnimationSpellEffects;
        private System.Windows.Forms.Label labelAnimationSpellEffect_Id;
        private System.Windows.Forms.Label labelAnimationSpellEffect_Speed;
        private System.Windows.Forms.GroupBox groupBoxAnimationTarget;
        private System.Windows.Forms.Label labelAnimationTarget_Id;
        private System.Windows.Forms.Label labelAnimationTarget_Speed;
        private System.Windows.Forms.Button buttonCloseReturn;
        private System.Windows.Forms.Label labelTitleValue;
        private System.Windows.Forms.TextBox textBoxSound_Id;
        private System.Windows.Forms.TextBox textBoxHealSimpleMax;
        private System.Windows.Forms.TextBox textBoxHealSimpleMin;
        private System.Windows.Forms.TextBox textBoxDamageSimpleMax;
        private System.Windows.Forms.TextBox textBoxDamageSimpleMin;
        private System.Windows.Forms.TextBox textBoxStatModReflectIntensity;
        private System.Windows.Forms.TextBox textBoxStatModReflectChance;
        private System.Windows.Forms.TextBox textBoxStatModHealMod;
        private System.Windows.Forms.TextBox textBoxStatModDmgMod;
        private System.Windows.Forms.TextBox textBoxStatModMr;
        private System.Windows.Forms.TextBox textBoxStatModRegen;
        private System.Windows.Forms.TextBox textBoxStatModAc;
        private System.Windows.Forms.TextBox textBoxStatModHit;
        private System.Windows.Forms.TextBox textBoxStatModMp;
        private System.Windows.Forms.TextBox textBoxStatModHp;
        private System.Windows.Forms.TextBox textBoxStatModDex;
        private System.Windows.Forms.TextBox textBoxStatModCon;
        private System.Windows.Forms.TextBox textBoxStatModWis;
        private System.Windows.Forms.TextBox textBoxStatModInt;
        private System.Windows.Forms.TextBox textBoxAnimationSpellEffect_Speed;
        private System.Windows.Forms.TextBox textBoxAnimationSpellEffect_Id;
        private System.Windows.Forms.TextBox textBoxAnimationTarget_Speed;
        private System.Windows.Forms.TextBox textBoxAnimationTarget_Id;
        private System.Windows.Forms.TextBox textBoxStatModDmg;
        private System.Windows.Forms.TextBox textBoxStatModStr;
        private System.Windows.Forms.Label labelStatModDmgType;
        private System.Windows.Forms.ComboBox comboBoxStatModDmgType;
    }
}