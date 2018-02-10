/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2016 Project Hybrasyl (info@hybrasyl.com)
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hybrasyl.Statuses;
using HybrasylXmlEditor.UI.ViewModel;

namespace HybrasylXmlEditor.UI
{
    public partial class StatusesEffectsDialog : Form
    {
        public const string onApply = "OnApply";
        public const string onTick = "OnTick";
        public const string onRemove = "OnRemove";

        public StatusViewModel statusVM;
        public ModifierEffect OnApply { get; set; }
        public ModifierEffect OnTick { get; set; }
        public ModifierEffect OnRemove { get; set; }

        private string _effectType = string.Empty;

        public StatusesEffectsDialog(string effectType)
        {
            _effectType = effectType;
            InitializeComponent();
        }

        private void StatusesEffectsDialog_Load(object sender, EventArgs e)
        {
            var test = statusVM;
            setBindings();
            if (_effectType.Equals(onApply))
            {
                if (statusVM.Effects.OnApply == null)
                {
                    OnApply = new ModifierEffect();
                }
                else
                {
                    OnApply = statusVM.Effects.OnApply;
                }

                for(int i = 0; i < listBoxCondSet.Items.Count; i++)
                {
                    if (statusVM.Effects_OnApply_Conditions_Set_List.Contains(listBoxCondSet.Items[i].ToString()))
                    {
                        listBoxCondSet.SetSelected(i, true);
                    }
                }

                for (int i = 0; i < listBoxCondUnset.Items.Count; i++)
                {
                    if (statusVM.Effects_OnApply_Conditions_Unset_List.Contains(listBoxCondUnset.Items[i].ToString()))
                    {
                        listBoxCondUnset.SetSelected(i, true);
                    }
                }

            }
            else if (_effectType.Equals(onTick))
            {
                if (statusVM.Effects.OnTick == null)
                {
                    OnTick = new ModifierEffect();
                }
                else
                {
                    OnTick = statusVM.Effects.OnTick;
                }

                for (int i = 0; i < listBoxCondSet.Items.Count; i++)
                {
                    if (statusVM.Effects_OnTick_Conditions_Set_List.Contains(listBoxCondSet.Items[i].ToString()))
                    {
                        listBoxCondSet.SetSelected(i, true);
                    }
                }

                for (int i = 0; i < listBoxCondUnset.Items.Count; i++)
                {
                    if (statusVM.Effects_OnTick_Conditions_Unset_List.Contains(listBoxCondUnset.Items[i].ToString()))
                    {
                        listBoxCondUnset.SetSelected(i, true);
                    }
                }
            }
            else
            {
                if (statusVM.Effects.OnRemove == null)
                {
                    OnRemove = new ModifierEffect();
                }
                else
                {
                    OnRemove = statusVM.Effects.OnRemove;
                }
                for (int i = 0; i < listBoxCondSet.Items.Count; i++)
                {
                    if (statusVM.Effects_OnRemove_Conditions_Set_List.Contains(listBoxCondSet.Items[i].ToString()))
                    {
                        listBoxCondSet.SetSelected(i, true);
                    }
                }

                for (int i = 0; i < listBoxCondUnset.Items.Count; i++)
                {
                    if (statusVM.Effects_OnRemove_Conditions_Unset_List.Contains(listBoxCondUnset.Items[i].ToString()))
                    {
                        listBoxCondUnset.SetSelected(i, true);
                    }
                }
            }
            labelTitleValue.Text = _effectType;
        }

        private void setBindings()
        {
            textBoxAnimationTarget_Id.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Animations_Target_Id");
            textBoxAnimationTarget_Speed.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Animations_Target_Speed");
            textBoxAnimationSpellEffect_Id.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Animations_SpellEffect_Id");
            textBoxAnimationSpellEffect_Speed.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Animations_SpellEffect_Speed");

            textBoxSound_Id.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Sound_Id");

            textBoxMessagesTarget.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Messages_Target");
            textBoxMessagesSource.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Messages_Source");
            textBoxMessagesGroup.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Messages_Group");
            textBoxMessagesSay.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Messages_Say");
            textBoxMessagesShout.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Messages_Shout");

            textBoxHealSimpleMin.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Heal_Simple_Min");
            textBoxHealSimpleMax.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Heal_Simple_Max");
            //simple value?
            textBoxHealFormula.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Heal_Formula");

            comboBoxDamageFlags.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_Damage_Flags"); // damage flag == enum list
            textBoxDamageSimpleMin.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Damage_Simple_Min");
            textBoxDamageSimpleMax.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Damage_Simple_Max");
            // simple value?
            textBoxDamageFormula.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_Damage_Formula");
            comboBoxDamageType.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_Damage_Type"); // damage type == enum single
            
            textBoxStatModStr.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Str");
            textBoxStatModInt.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Int");
            textBoxStatModWis.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Wis");
            textBoxStatModCon.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Con");
            textBoxStatModDex.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Dex");
            textBoxStatModHp.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Hp");
            textBoxStatModMp.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Mp");
            textBoxStatModHit.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Hit");
            textBoxStatModDmg.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Dmg");
            textBoxStatModAc.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Ac");
            textBoxStatModRegen.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Regen");
            textBoxStatModMr.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_Mr");
            comboBoxStatModOffElement.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_StatModifiers_OffensiveElement"); //enum single
            comboBoxStatModDefElement.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_StatModifiers_DefensiveElement"); //enum single
            textBoxStatModDmgMod.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_DmgModifier");
            textBoxStatModHealMod.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_HealModifier");
            comboBoxStatModDmgType.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_StatModifiers_DmgType"); //enum single
            textBoxStatModReflectChance.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_ReflectChance");
            textBoxStatModReflectIntensity.DataBindings.Add("Text", statusVM, "Effects_" + _effectType + "_StatModifiers_ReflectIntensity");

            //listBoxCondSet.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_Conditions_Set"); //enum list
            //listBoxCondUnset.DataBindings.Add("SelectedItem", statusVM, "Effects_" + _effectType + "_Conditions_Unset"); //enum list
        }

        private void buttonCloseReturn_Click(object sender, EventArgs e)
        {
            setCreatureConditionBitwiseEnumValues();
            this.Dispose();
        }

        private void setCreatureConditionBitwiseEnumValues()
        {
            var listSet = listBoxCondSet.SelectedItems.Cast<CreatureCondition>();
            var listUnset = listBoxCondUnset.SelectedItems.Cast<CreatureCondition>();

            if (_effectType.Equals(onApply))
            {
                statusVM.Effects_OnApply_Conditions_Set = new CreatureCondition();
                foreach (var selected in listSet)
                {
                    statusVM.Effects_OnApply_Conditions_Set |= selected;
                }
            }
            else if (_effectType.Equals(onTick))
            {
                statusVM.Effects_OnTick_Conditions_Set = new CreatureCondition();
                foreach (var selected in listSet)
                {
                    statusVM.Effects_OnTick_Conditions_Set |= selected;
                }
            }
            else
            {
                statusVM.Effects_OnRemove_Conditions_Set = new CreatureCondition();
                foreach (var selected in listSet)
                {
                    statusVM.Effects_OnRemove_Conditions_Set |= selected;
                }
            }

            if (_effectType.Equals(onApply))
            {
                statusVM.Effects_OnApply_Conditions_Unset = new CreatureCondition();
                foreach (var selected in listUnset)
                {
                    statusVM.Effects_OnApply_Conditions_Unset |= selected;
                }
            }
            else if (_effectType.Equals(onTick))
            {
                statusVM.Effects_OnTick_Conditions_Unset = new CreatureCondition();
                foreach (var selected in listUnset)
                {
                    statusVM.Effects_OnTick_Conditions_Unset |= selected;
                }
            }
            else
            {
                statusVM.Effects_OnRemove_Conditions_Unset = new CreatureCondition();
                foreach (var selected in listUnset)
                {
                    statusVM.Effects_OnRemove_Conditions_Unset |= selected;
                }
            }
        }

        private void textBoxUShortValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!ushort.TryParse(textBox.Text, out ushort value))
            {
                MessageBox.Show("Must be a number between 0 - 65,535. May be left blank.");
            }
        }

        private void textBoxShortValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!ushort.TryParse(textBox.Text, out ushort value))
            {
                MessageBox.Show("Must be a number between 0 - 32,767. May be left blank.");
            }
        }

        private void textBoxIntValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!int.TryParse(textBox.Text, out int value))
            {
                MessageBox.Show("Must be a number between 0 - 2,147,483,647. May be left blank.");
            }
        }

        private void textBoxSByteValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if(!sbyte.TryParse(textBox.Text, out sbyte value))
            {
                MessageBox.Show("Must be a number between 0 - 127. May be left blank.");
            }
        }

        private void textBoxByteValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!byte.TryParse(textBox.Text, out byte value))
            {
                MessageBox.Show("Must be a number between 0 - 255. May be left blank.");
            }
        }

        private void textBoxFloatValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!float.TryParse(textBox.Text, out float value))
            {
                MessageBox.Show("Must be a number. May be left blank.");
            }
        }
    }
}
