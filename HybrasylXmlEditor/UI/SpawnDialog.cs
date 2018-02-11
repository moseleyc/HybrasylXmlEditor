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
        }

        private void SpawnDialog_Load(object sender, EventArgs e)
        {
            SpawnVM.SetDisplaySpawn(SpawnVM.Spawn);
            setBindings();
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
            }
        }

        private void checkBoxHasCastables_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHasLootImport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHasLootTable_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
