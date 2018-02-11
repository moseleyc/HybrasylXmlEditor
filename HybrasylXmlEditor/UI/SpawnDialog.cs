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
        }

        private void SpawnDialog_Load(object sender, EventArgs e)
        {
            SpawnVM.SetDisplaySpawn(SpawnVM.Spawn);
            setBindings();
            if(SpawnVM.Script != null)
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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
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

        }

        #region Loot Events
        private void checkBoxHasLootImport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHasLootTable_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
