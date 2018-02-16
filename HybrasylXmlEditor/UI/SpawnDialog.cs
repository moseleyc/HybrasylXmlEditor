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

using Hybrasyl.Creatures;
using HybrasylXmlEditor.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybrasylXmlEditor.UI
{
    public partial class SpawnDialog : Form
    {
        public SpawnViewModel SpawnVM { get; set; }

        public SpawnDialog()
        {
            InitializeComponent();
        }

        private void setBindings()
        {
            textBoxBase.DataBindings.Add("Text", SpawnVM, "Base");
            numericVariance.DataBindings.Add("Value", SpawnVM, "Variance");

            textBoxScriptValue.DataBindings.Add("Text", SpawnVM, "Script_Value");
            comboBoxScriptType.DataBindings.Add("SelectedItem", SpawnVM, "Script_Type");

            textBoxIntentNpcValue.DataBindings.Add("Text", SpawnVM, "Intents_Npc_Value");
            comboBoxIntentNpcType.DataBindings.Add("SelectedItem", SpawnVM, "Intents_Npc_Type");

            textBoxIntentPlayerValue.DataBindings.Add("Text", SpawnVM, "Intents_Player_Value");
            comboBoxIntentPlayerType.DataBindings.Add("SelectedItem", SpawnVM, "Intents_Player_Type");

            textBoxIntentMonsterValue.DataBindings.Add("Text", SpawnVM, "Intents_Monster_Value");
            comboBoxIntentMonsterType.DataBindings.Add("SelectedItem", SpawnVM, "Intents_Monster_Type");

            numericRespawnInterval.DataBindings.Add("Value", SpawnVM, "Respawn_Interval");
            numericRespawnMin.DataBindings.Add("Value", SpawnVM, "Respawn_Min");
            numericRespawnMax.DataBindings.Add("Value", SpawnVM, "Respawn_Max");
            numericRespawnPercentage.DataBindings.Add("Value", SpawnVM, "Respawn_Percentage");

            numericDamageMin.DataBindings.Add("Value", SpawnVM, "Damage_Min");
            numericDamageMax.DataBindings.Add("Value", SpawnVM, "Damage_Max");
            //listBoxDamageElements.DataBindings.Add("SelectedItem", SpawnVM, "Damage_Elements"); //Enum List
            comboBoxDamageType.DataBindings.Add("SelectedItem", SpawnVM, "Damage_Type"); 
            numericDamageDmg.DataBindings.Add("Value", SpawnVM, "Damage_Dmg");
            numericDamageHit.DataBindings.Add("Value", SpawnVM, "Damage_Hit");

            numericDefenseMr.DataBindings.Add("Value", SpawnVM, "Defense_Mr");
            numericDefenseAc.DataBindings.Add("Value", SpawnVM, "Defense_Ac");
            //
            numericDefenseRegen.DataBindings.Add("Value", SpawnVM, "Defense_Regen");

            numericStatsHp.DataBindings.Add("Value", SpawnVM, "Stats_Hp");
            numericStatsMp.DataBindings.Add("Value", SpawnVM, "Stats_Mp");
            numericStatsLevel.DataBindings.Add("Value", SpawnVM, "Stats_Level");
            numericStatsStr.DataBindings.Add("Value", SpawnVM, "Stats_Str");
            numericStatsInt.DataBindings.Add("Value", SpawnVM, "Stats_Int");
            numericStatsWis.DataBindings.Add("Value", SpawnVM, "Stats_Wis");
            numericStatsCon.DataBindings.Add("Value", SpawnVM, "Stats_Con");
            numericStatsDex.DataBindings.Add("Value", SpawnVM, "Stats_Dex");

            //dataGridViewCastables.AutoGenerateColumns = false;
            //dataGridViewCastables.DataSource = SpawnVM.Castables;

            numericLootXpMin.DataBindings.Add("Value", SpawnVM, "Loot_Xp_Min");
            numericLootXpMax.DataBindings.Add("Value", SpawnVM, "Loot_Xp_Max");
            numericLootGoldMin.DataBindings.Add("Value", SpawnVM, "Loot_Gold_Min");
            numericLootGoldMax.DataBindings.Add("Value", SpawnVM, "Loot_Gold_Max");
        }

        private void setDataGridSettings()
        {
            dataGridViewCastables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCastables.AllowUserToAddRows = true;
            dataGridViewCastables.MultiSelect = false;
            dataGridViewCastables.RowHeadersVisible = false;
            dataGridViewCastables.AllowUserToOrderColumns = false;
            dataGridViewCastables.AllowUserToResizeColumns = false;
            dataGridViewCastables.AllowUserToResizeRows = false;
            dataGridViewCastables.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn castableValue = new DataGridViewTextBoxColumn();
            castableValue.Name = "Value";
            castableValue.DataPropertyName = "Value";
            castableValue.HeaderText = "Value";
            castableValue.Width = 200;
            castableValue.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableValue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableValue.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCastables.Columns.Add(castableValue);

            DataGridViewTextBoxColumn castableCooldown = new DataGridViewTextBoxColumn();
            castableCooldown.Name = "Cooldown";
            castableCooldown.DataPropertyName = "Cooldown";
            castableCooldown.HeaderText = "Cooldown";
            castableCooldown.Width = 60;
            castableCooldown.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableCooldown.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableCooldown.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCastables.Columns.Add(castableCooldown);

            DataGridViewTextBoxColumn castableChance = new DataGridViewTextBoxColumn();
            castableChance.Name = "Chance";
            castableChance.DataPropertyName = "Chance";
            castableChance.HeaderText = "Chance";
            castableChance.Width = 60;
            castableChance.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableChance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableChance.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCastables.Columns.Add(castableChance);

            DataGridViewCheckBoxColumn castableAlways = new DataGridViewCheckBoxColumn();
            castableAlways.Name = "Always";
            castableAlways.DataPropertyName = "Always";
            castableAlways.HeaderText = "Always";
            castableAlways.Width = 60;
            castableAlways.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableAlways.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            castableAlways.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCastables.Columns.Add(castableAlways);
        }

        private void SpawnDialog_Load(object sender, EventArgs e)
        {
            SpawnVM.SetDisplaySpawn(SpawnVM.Spawn);
            setBindings();
            setDataGridSettings();
            if (SpawnVM.Script != null)
            {
                checkBoxHasScript.Checked = true;
            }
            if(SpawnVM.Intents != null)
            {
                checkBoxHasIntents.Checked = true;
                if(SpawnVM.Intents.Npc != null)
                {
                    checkBoxIntentHasNpc.Checked = true;
                }
                if(SpawnVM.Intents.Player != null)
                {
                    checkBoxIntentHasPlayer.Checked = true;
                }
                if (SpawnVM.Intents.Monster != null)
                {
                    checkBoxIntentHasMonster.Checked = true;
                }
            }

            //Select the elements in the multi-select listbox for Damage
            for (int i = 0; i < listBoxDamageElements.Items.Count; i++)
            {
                if (SpawnVM.Damage_Elements != null && SpawnVM.Damage_Elements.Contains((Element)listBoxDamageElements.Items[i]))
                {
                    listBoxDamageElements.SetSelected(i, true);
                }
            }

            //Select the elements in the multi-select listbox for Defense
            for (int i = 0; i < listBoxDefenseElements.Items.Count; i++)
            {
                if (SpawnVM.Defense_Elements != null && SpawnVM.Defense_Elements.Contains((Element)listBoxDefenseElements.Items[i]))
                {
                    listBoxDefenseElements.SetSelected(i, true);
                }
            }

            if(SpawnVM.Loot_Xp != null)
            {
                checkBoxLootHasXp.Checked = true;
            }

            if(SpawnVM.Loot_Gold != null)
            {
                checkBoxLootHasGold.Checked = true;
            }

            if(SpawnVM.Castables != null && SpawnVM.Castables.Count > 0)
            {
                checkBoxHasCastables.Checked = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(listBoxDamageElements.SelectedItems.Count > 0) { SpawnVM.Damage_Elements = new BindingList<Element>(listBoxDamageElements.SelectedItems.Cast<Element>().ToList()); }
            else { SpawnVM.Damage_Elements = null; }

            if (listBoxDefenseElements.SelectedItems.Count > 0) { SpawnVM.Defense_Elements = new BindingList<Element>(listBoxDefenseElements.SelectedItems.Cast<Element>().ToList()); }
            else { SpawnVM.Defense_Elements = null; }
            
            this.DialogResult = DialogResult.OK;
        }

        private void checkBoxHasScript_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if (SpawnVM.Script == null)
                {
                    SpawnVM.Script = new CreatureScript();
                }
                textBoxScriptValue.ReadOnly = false;
                comboBoxScriptType.Enabled = true;
            }
            else
            {
                SpawnVM.Script = null;
                textBoxScriptValue.ReadOnly = true;
                comboBoxScriptType.Enabled = false;
            }
        }

        private void checkBoxHasIntents_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if(SpawnVM.Intents == null)
                {
                    SpawnVM.Intents = new IntentList();
                }
            }
            else
            {
                SpawnVM.Intents = null;
                checkBoxIntentHasNpc.Checked = false;
                checkBoxIntentHasPlayer.Checked = false;
                checkBoxIntentHasMonster.Checked = false;
            }
        }

        #region Intents Events
        private void checkBoxIntentHasNpc_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if (checkBoxHasIntents.Checked)
                {
                    SpawnVM.Intents_Npc = new Intent();
                    textBoxIntentNpcValue.ReadOnly = false;
                    comboBoxIntentNpcType.Enabled = true;
                }
                else
                {
                    checkbox.Checked = false;
                    MessageBox.Show("Has Intents must be checked off first.");
                }
            }
            else
            {
                textBoxIntentNpcValue.Clear();
                textBoxIntentNpcValue.ReadOnly = true;
                comboBoxIntentNpcType.Enabled = false;
            }
        }

        private void checkBoxIntentHasPlayer_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if (checkBoxHasIntents.Checked)
                {
                    SpawnVM.Intents_Player = new Intent();
                    textBoxIntentPlayerValue.ReadOnly = false;
                    comboBoxIntentPlayerType.Enabled = true;
                }
                else
                {
                    checkbox.Checked = false;
                    MessageBox.Show("Has Intents must be checked off first.");
                }
            }
            else
            {
                textBoxIntentPlayerValue.Clear();
                textBoxIntentPlayerValue.ReadOnly = true;
                comboBoxIntentPlayerType.Enabled = false;
            }
        }

        private void checkBoxIntentHasMonster_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if (checkBoxHasIntents.Checked)
                {
                    SpawnVM.Intents_Monster = new Intent();
                    textBoxIntentMonsterValue.ReadOnly = false;
                    comboBoxIntentMonsterType.Enabled = true;
                }
                else
                {
                    checkbox.Checked = false;
                    MessageBox.Show("Has Intents must be checked off first.");
                }
            }
            else
            {
                textBoxIntentMonsterValue.Clear();
                textBoxIntentMonsterValue.ReadOnly = true;
                comboBoxIntentMonsterType.Enabled = false;
            }
        }
        #endregion

        private void checkBoxHasCastables_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if (SpawnVM.Castables == null) SpawnVM.Castables = new BindingList<Castable>();
                dataGridViewCastables.ReadOnly = false;
                dataGridViewCastables.DataSource = SpawnVM.Castables;
            }
            else
            {
                SpawnVM.Castables = null;
                dataGridViewCastables.ReadOnly = true;
            }
        }

        #region Loot Events
        private void checkBoxHasLootImport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHasLootTable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLootHasXp_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if (SpawnVM.Loot_Xp == null) SpawnVM.Loot_Xp = new LootXp();
                numericLootXpMin.ReadOnly = false;
                numericLootXpMax.ReadOnly = false;
            }
            else
            {
                SpawnVM.Loot_Xp = null;
                numericLootXpMin.ReadOnly = true;
                numericLootXpMax.ReadOnly = true;
            }
        }

        private void checkBoxLootHasGold_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                if(SpawnVM.Loot_Gold == null) SpawnVM.Loot_Gold = new LootGold();
                numericLootGoldMin.ReadOnly = false;
                numericLootGoldMax.ReadOnly = false;
            }
            else
            {
                SpawnVM.Loot_Gold = null;
                numericLootGoldMin.ReadOnly = true;
                numericLootGoldMax.ReadOnly = true;
            }
        }
        #endregion


    }
}
