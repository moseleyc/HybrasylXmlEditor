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

using Hybrasyl.Statuses;
using Hybrasyl.XML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HybrasylXmlEditor.UI
{
    public partial class StatusesDialog : Form
    {
        public StatusViewModel StatusVM { get; set; }
        public StatusesDialog()
        {
            InitializeComponent();
        }

        private void buttonLoadStatusXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadStatusXML = new OpenFileDialog();
            loadStatusXML.Filter = "(XML)|*.xml";
            if(loadStatusXML.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreComments = true;
                    
                    XmlReader reader = XmlReader.Create(loadStatusXML.FileName, settings);
                    Status nullStatus = null;
                    var readStatus = Serializer.Deserialize(reader, nullStatus);
                    StatusVM.SetDisplayStatus(readStatus);
                    loadCastRestrictions();

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file");
                }

            }
        }

        private void StatusesDialog_Load(object sender, EventArgs e)
        {
            StatusVM = new StatusViewModel(new Status());
            setBindings();
            StatusVM.SetDisplayStatus(new Status());
            loadCastRestrictions();
        }

        private void setBindings()
        {
            textBoxStatusName.DataBindings.Add("Text", StatusVM, "Name");
            textBoxStatusIcon.DataBindings.Add("Text", StatusVM, "Icon");
            textBoxStatusDuration.DataBindings.Add("Text", StatusVM, "Duration");
            textBoxStatusTick.DataBindings.Add("Text", StatusVM, "Tick");

            textBoxStatusCategory.DataBindings.Add("Text", StatusVM, "Category");
            textBoxStatusProhibitedMsg.DataBindings.Add("Text", StatusVM, "ProhibitedMessage");
            textBoxStatusScript.DataBindings.Add("Text", StatusVM, "Script");

            textBoxCastRestUse.DataBindings.Add("Text", StatusVM, "CastRestriction_Use");
            textBoxCastRestReceive.DataBindings.Add("Text", StatusVM, "CastRestriction_Receive");
        }

        private void buttonOnApply_Click(object sender, EventArgs e)
        {
            StatusesEffectsDialog dlg = new StatusesEffectsDialog("OnApply");
            StatusVM.Effects_OnApply_Conditions_Set_List = new List<string>(StatusVM.Effects_OnApply_Conditions_Set.ToString().Replace(" ", "").Split(','));
            StatusVM.Effects_OnApply_Conditions_Unset_List = new List<string>(StatusVM.Effects_OnApply_Conditions_Unset.ToString().Replace(" ", "").Split(','));
            dlg.statusVM = StatusVM;

            if(dlg.ShowDialog() == DialogResult.OK)
            {

            }

            dlg.Dispose();
        }


        private void buttonOnTick_Click(object sender, EventArgs e)
        {
            StatusesEffectsDialog dlg = new StatusesEffectsDialog("OnTick");
            StatusVM.Effects_OnTick_Conditions_Set_List = new List<string>(StatusVM.Effects_OnTick_Conditions_Set.ToString().Replace(" ", "").Split(','));
            StatusVM.Effects_OnTick_Conditions_Unset_List = new List<string>(StatusVM.Effects_OnTick_Conditions_Unset.ToString().Replace(" ", "").Split(','));
            dlg.statusVM = StatusVM;

            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }

            dlg.Dispose();
        }


        private void buttonOnRemove_Click(object sender, EventArgs e)
        {
            StatusesEffectsDialog dlg = new StatusesEffectsDialog("OnRemove");
            StatusVM.Effects_OnRemove_Conditions_Set_List = new List<string>(StatusVM.Effects_OnRemove_Conditions_Set.ToString().Replace(" ", "").Split(','));
            StatusVM.Effects_OnRemove_Conditions_Unset_List = new List<string>(StatusVM.Effects_OnRemove_Conditions_Unset.ToString().Replace(" ", "").Split(','));
            dlg.statusVM = StatusVM;

            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }

            dlg.Dispose();
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveStatusXML = new SaveFileDialog();
            saveStatusXML.Filter = "(XML)|*.xml";
            if (saveStatusXML.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileName = saveStatusXML.FileName;
                    XmlWriterSettings xmlSettings = new XmlWriterSettings();
                    xmlSettings.Indent = true;
                    xmlSettings.IndentChars = "\t";

                    XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlSettings);
                    Serializer.Serialize(xmlWriter, StatusVM.GetDisplayStatus());

                    xmlWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file");
                }

            }
        }

        private void buttonNewXML_Click(object sender, EventArgs e)
        {
            StatusVM.SetDisplayStatus(new Status());
            StatusVM.CastRestriction_Receive = StatusVM.CastRestriction.Receive;
            StatusVM.CastRestriction_Use = StatusVM.CastRestriction.Use;
        }

        private void textBoxUShortValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!ushort.TryParse(textBox.Text, out ushort value))
            {
                MessageBox.Show("Must be a number between 0 - 65,535. May be left blank.");
            }
        }

        private void textBoxIntValidation_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var test1 = !int.TryParse(textBox.Text, out int valu1e);
            var test2 = !textBox.Text.Equals(string.Empty);
            if (!int.TryParse(textBox.Text, out int value))
            {
                MessageBox.Show("Must be a number between 0 - 2,147,483,647. May be left blank.");
            }
        }

        private void textBoxCastRestriction_Leave(object sender, EventArgs e)
        {
            StatusVM.CastRestriction.Receive = StatusVM.CastRestriction_Receive;
            StatusVM.CastRestriction.Use = StatusVM.CastRestriction.Use;
        }

        private void loadCastRestrictions()
        {
            StatusVM.CastRestriction_Receive = StatusVM.CastRestriction.Receive;
            StatusVM.CastRestriction_Use = StatusVM.CastRestriction.Use;
        }
    }
}
