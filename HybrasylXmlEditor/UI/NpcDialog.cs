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
using Hybrasyl.XML;
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
using System.Xml;

namespace HybrasylXmlEditor.UI
{
    public partial class NpcDialog : Form
    {
        public NpcViewModel NpcVM { get; set; }

        public NpcDialog()
        {
            InitializeComponent();
        }

        public void NpcDialogForm_Load(object sender, EventArgs e)
        {
            NpcVM = new NpcViewModel(new Npc());
            setBindings();
            setupDataGridView();
        }

        private void setBindings()
        {
            textBoxName.DataBindings.Add("Text", NpcVM, "Name");
            textBoxDisplayName.DataBindings.Add("Text", NpcVM, "DisplayName");

            numericUpDownAppearanceSprite.DataBindings.Add("Value", NpcVM, "Appearance_Sprite");
            textBoxAppearancePortrait.DataBindings.Add("Text", NpcVM, "Appearance_Portrait");

            dataGridViewRolesTrain.AutoGenerateColumns = false;
            if (NpcVM.Roles_Train == null) NpcVM.Roles_Train = new BindingList<NpcRoleTrainCastable>();
            dataGridViewRolesTrain.DataSource = NpcVM.Roles_Train;

            dataGridViewVendorItems.AutoGenerateColumns = false;
            if (NpcVM.Roles_Vend_Items == null) NpcVM.Roles_Vend_Items = new BindingList<NpcRoleVendItem>();
            dataGridViewVendorItems.DataSource = NpcVM.Roles_Vend_Items;

            dataGridViewPostSurcharge.AutoGenerateColumns = false;
            if (NpcVM.Roles_Post_Surcharge == null) NpcVM.Roles_Post_Surcharge = new BindingList<NpcRolePostSurcharge>();
            dataGridViewPostSurcharge.DataSource = NpcVM.Roles_Post_Surcharge;

            textBoxPostReceive.DataBindings.Add("Text", NpcVM, "Roles_Post_Receive");

            textBoxRepairNation.DataBindings.Add("Text", NpcVM, "Roles_Repair_Nation");
            numericUpDownRepairDiscount.DataBindings.Add("Value", NpcVM, "Roles_Repair_Discount");

            textBoxBankDiscount.DataBindings.Add("Text", NpcVM, "Roles_Bank_Discount");

            textBoxInvItemValue.DataBindings.Add("Text", NpcVM, "Inventory_Item_Value");
            numericUpDownInvQty.DataBindings.Add("Value", NpcVM, "Inventory_Item_Quantity");
            numericUpDownInvRefresh.DataBindings.Add("Value", NpcVM, "Inventory_Item_Refresh");
            numericUpDownInvGold.DataBindings.Add("Value", NpcVM, "Inventory_Gold");

            numericUpDownMapX.DataBindings.Add("Value", NpcVM, "X");
            numericUpDownMapY.DataBindings.Add("Value", NpcVM, "Y");
        }

        private void setupDataGridView()
        {
            #region NPC Roles Training
            dataGridViewRolesTrain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRolesTrain.MultiSelect = false;
            dataGridViewRolesTrain.RowHeadersVisible = false;
            dataGridViewRolesTrain.AllowUserToOrderColumns = false;
            dataGridViewRolesTrain.AllowUserToResizeColumns = false;
            dataGridViewRolesTrain.AllowUserToResizeRows = false;
            dataGridViewRolesTrain.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn trainName = new DataGridViewTextBoxColumn();
            trainName.Name = "Name";
            trainName.DataPropertyName = "Name";
            trainName.HeaderText = "Name";
            trainName.Width = 155;
            trainName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewRolesTrain.Columns.Add(trainName);

            DataGridViewTextBoxColumn trainType = new DataGridViewTextBoxColumn();
            trainType.Name = "Type";
            trainType.DataPropertyName = "Type";
            trainType.HeaderText = "Type";
            trainType.Width = 80;
            trainType.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainType.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainType.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewRolesTrain.Columns.Add(trainType);
            #endregion

            #region NPC Roles Vendor Items
            dataGridViewVendorItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVendorItems.MultiSelect = false;
            dataGridViewVendorItems.RowHeadersVisible = false;
            dataGridViewVendorItems.AllowUserToOrderColumns = false;
            dataGridViewVendorItems.AllowUserToResizeColumns = false;
            dataGridViewVendorItems.AllowUserToResizeRows = false;
            dataGridViewVendorItems.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn vendorItemsName = new DataGridViewTextBoxColumn();
            vendorItemsName.Name = "Name";
            vendorItemsName.DataPropertyName = "Name";
            vendorItemsName.HeaderText = "Name";
            vendorItemsName.Width = 60;
            vendorItemsName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewVendorItems.Columns.Add(vendorItemsName);

            DataGridViewTextBoxColumn vendorItemsQty = new DataGridViewTextBoxColumn();
            vendorItemsQty.Name = "Quantity";
            vendorItemsQty.DataPropertyName = "Quantity";
            vendorItemsQty.HeaderText = "Qty";
            vendorItemsQty.Width = 60;
            vendorItemsQty.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsQty.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewVendorItems.Columns.Add(vendorItemsQty);

            DataGridViewTextBoxColumn vendorItemsRestock = new DataGridViewTextBoxColumn();
            vendorItemsRestock.Name = "Restock";
            vendorItemsRestock.DataPropertyName = "Restock";
            vendorItemsRestock.HeaderText = "Restock";
            vendorItemsRestock.Width = 60;
            vendorItemsRestock.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsRestock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsRestock.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewVendorItems.Columns.Add(vendorItemsRestock);

            DataGridViewTextBoxColumn vendorItemsTab = new DataGridViewTextBoxColumn();
            vendorItemsTab.Name = "Tab";
            vendorItemsTab.DataPropertyName = "Tab";
            vendorItemsTab.HeaderText = "Tab";
            vendorItemsTab.Width = 60;
            vendorItemsTab.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsTab.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            vendorItemsTab.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewVendorItems.Columns.Add(vendorItemsTab);
            #endregion

            #region NPC Roles Post Surcharge
            dataGridViewPostSurcharge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPostSurcharge.MultiSelect = false;
            dataGridViewPostSurcharge.RowHeadersVisible = false;
            dataGridViewPostSurcharge.AllowUserToOrderColumns = false;
            dataGridViewPostSurcharge.AllowUserToResizeColumns = false;
            dataGridViewPostSurcharge.AllowUserToResizeRows = false;
            dataGridViewPostSurcharge.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn postSurchargeNation = new DataGridViewTextBoxColumn();
            postSurchargeNation.Name = "Nation";
            postSurchargeNation.DataPropertyName = "Nation";
            postSurchargeNation.HeaderText = "Nation";
            postSurchargeNation.Width = 60;
            postSurchargeNation.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postSurchargeNation.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postSurchargeNation.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewPostSurcharge.Columns.Add(postSurchargeNation);

            DataGridViewTextBoxColumn postSurchargePercentage = new DataGridViewTextBoxColumn();
            postSurchargePercentage.Name = "Percent";
            postSurchargePercentage.DataPropertyName = "Percent";
            postSurchargePercentage.HeaderText = "Percent";
            postSurchargePercentage.Width = 60;
            postSurchargePercentage.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postSurchargePercentage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postSurchargePercentage.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewPostSurcharge.Columns.Add(postSurchargePercentage);
            #endregion
        }

        private void buttonLoadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadNpcXML = new OpenFileDialog();
            loadNpcXML.Filter = "(XML)|*.xml";
            if (loadNpcXML.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreComments = true;

                    XmlReader reader = XmlReader.Create(loadNpcXML.FileName, settings);
                    Npc nullNpc = null;
                    var readNpc = Serializer.Deserialize(reader, nullNpc);
                    NpcVM.SetDisplayNpc(readNpc);
                    dataGridViewRolesTrain.DataSource = NpcVM.Roles_Train;
                    dataGridViewVendorItems.DataSource = NpcVM.Roles_Vend_Items;
                    dataGridViewPostSurcharge.DataSource = NpcVM.Roles_Post_Surcharge;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Problem with loading the file");
                }
            }
            loadFlags();
        }

        private void loadFlags()
        {
            if (NpcVM.Appearance != null) checkBoxHasAppearance.Checked = true;
            if (NpcVM.Roles != null)
            {
                checkBoxHasRoles.Checked = true;
                if (NpcVM.Roles.Train != null)
                {
                    checkBoxHasTrain.Checked = true;
                }
                if (NpcVM.Roles.Vend != null)
                {
                    checkBoxHasVendor.Checked = true;
                    if(NpcVM.Roles.Vend.Items != null)
                    {
                        checkBoxVendorHasItems.Checked = true;
                    }
                }
                if (NpcVM.Roles.Post != null)
                {
                    checkBoxHasPost.Checked = true;
                }
                if (NpcVM.Roles.Repair != null)
                {
                    checkBoxHasRepairs.Checked = true;
                    var repairTypes = NpcVM.Roles.Repair.Type;
                    if (repairTypes != null)
                    {
                        if (repairTypes.Contains(NpcRepairType.Armor)) { checkBoxRepairArmor.Checked = true; }
                        if (repairTypes.Contains(NpcRepairType.Weapon)) { checkBoxRepairWeapon.Checked = true; }
                        if (repairTypes.Contains(NpcRepairType.All)) { checkBoxRepairAll.Checked = true; }
                    }
                }
                if (NpcVM.Roles.Bank != null)
                {
                    checkBoxHasBank.Checked = true;
                }
            }
            if (NpcVM.Inventory != null)
            {
                checkBoxHasInventory.Checked = true;
                if (NpcVM.Inventory.Item != null)
                {
                    checkBoxHasInvItem.Checked = true;
                }
            }
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveNpcXML = new SaveFileDialog();
            saveNpcXML.Filter = "(XML)|*.xml";
            if (saveNpcXML.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileName = saveNpcXML.FileName;
                    XmlWriterSettings xmlSettings = new XmlWriterSettings();
                    xmlSettings.Indent = true;
                    xmlSettings.IndentChars = "\t";

                    XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlSettings);
                    Serializer.Serialize(xmlWriter, NpcVM.GetDisplayNpc());

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
            NpcVM.SetDisplayNpc(new Npc());
            checkBoxHasAppearance.Checked = false;
            checkBoxHasRoles.Checked = false;
            checkBoxHasInventory.Checked = false;
        }

        private void checkBoxHasAppearance_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                numericUpDownAppearanceSprite.ReadOnly = false;
                textBoxAppearancePortrait.ReadOnly = false;
                if (NpcVM.Appearance == null) NpcVM.Appearance = new NpcAppearance();
            }
            else
            {
                numericUpDownAppearanceSprite.ReadOnly = true;
                textBoxAppearancePortrait.ReadOnly = true;
                NpcVM.Appearance_Sprite = 0;
                NpcVM.Appearance_Portrait = string.Empty;
                NpcVM.Appearance = null;
            }
        }

        private void checkBoxHasRoles_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                if (NpcVM.Roles == null) NpcVM.Roles = new NpcRoleList();
            }
            else
            {
                NpcVM.Roles = null;

                checkBoxHasTrain.Checked = false;
                checkBoxHasVendor.Checked = false;
                checkBoxHasPost.Checked = false;
                checkBoxHasRepairs.Checked = false;
                checkBoxHasBank.Checked = false;
            }
        }

        


        //Roles Events
        #region Training Events
        private void checkBoxHasTrain_CheckedChanged(object sender, EventArgs e)
        {
            var senderChkBox = sender as CheckBox;
            if (senderChkBox.Checked)
            {
                if (checkBoxHasRoles.Checked)
                {
                    dataGridViewRolesTrain.ReadOnly = false;
                    if (NpcVM.Roles_Train == null) NpcVM.Roles_Train = new BindingList<NpcRoleTrainCastable>();
                    dataGridViewRolesTrain.DataSource = null;
                    dataGridViewRolesTrain.DataSource = NpcVM.Roles_Train;
                }
                else
                {
                    MessageBox.Show("Has Roles must be checked first.");
                    senderChkBox.Checked = false;
                }
            }
            else
            {
                checkBoxTrainPeasant.Checked = false;
                checkBoxTrainWizard.Checked = false;
                checkBoxTrainPriest.Checked = false;
                checkBoxTrainRogue.Checked = false;
                checkBoxTrainMonk.Checked = false;
                checkBoxTrainWarrior.Checked = false;
                dataGridViewRolesTrain.ReadOnly = true;
                NpcVM.Roles_Train.Clear();
                NpcVM.Roles_Train = null;
            }
        }

        private void dataGridViewRolesTrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewRolesTrain.CurrentRow.Index;
            if (NpcVM.Roles_Train != null && NpcVM.Roles_Train.Count > 0)
            {
                var currentTrainClass = NpcVM.Roles_Train[index].Class;

                if (currentTrainClass != null && currentTrainClass.Count > 0)
                {
                    if (currentTrainClass.Contains(Class.Peasant)) checkBoxTrainPeasant.Checked = true;
                    else checkBoxTrainPeasant.Checked = false;

                    if (currentTrainClass.Contains(Class.Wizard)) checkBoxTrainWizard.Checked = true;
                    else checkBoxTrainWizard.Checked = false;
                    if (currentTrainClass.Contains(Class.Priest)) checkBoxTrainPriest.Checked = true;
                    else checkBoxTrainPriest.Checked = false;
                    if (currentTrainClass.Contains(Class.Rogue)) checkBoxTrainRogue.Checked = true;
                    else checkBoxTrainRogue.Checked = false;
                    if (currentTrainClass.Contains(Class.Monk)) checkBoxTrainMonk.Checked = true;
                    else checkBoxTrainMonk.Checked = false;
                    if (currentTrainClass.Contains(Class.Warrior)) checkBoxTrainWarrior.Checked = true;
                    else checkBoxTrainWarrior.Checked = false;
                }
                else
                {
                    checkBoxTrainPeasant.Checked = false;
                    checkBoxTrainWizard.Checked = false;
                    checkBoxTrainPriest.Checked = false;
                    checkBoxTrainRogue.Checked = false;
                    checkBoxTrainMonk.Checked = false;
                    checkBoxTrainWarrior.Checked = false;

                }
            }            
        }

        private void checkBoxTrainPeasant_CheckedChanged(object sender, EventArgs e)
        {
            var currentClass = Class.Peasant;

            addOrRemoveCurrentClass(currentClass, (sender as CheckBox).Checked);
        }

        private void checkBoxTrainPriest_CheckedChanged(object sender, EventArgs e)
        {
            var currentClass = Class.Priest;

            addOrRemoveCurrentClass(currentClass, (sender as CheckBox).Checked);
        }

        private void checkBoxTrainMonk_CheckedChanged(object sender, EventArgs e)
        {
            var currentClass = Class.Monk;

            addOrRemoveCurrentClass(currentClass, (sender as CheckBox).Checked);
        }

        private void checkBoxTrainWizard_CheckedChanged(object sender, EventArgs e)
        {
            var currentClass = Class.Wizard;

            addOrRemoveCurrentClass(currentClass, (sender as CheckBox).Checked);
        }

        private void checkBoxTrainWarrior_CheckedChanged(object sender, EventArgs e)
        {
            var currentClass = Class.Warrior;

            addOrRemoveCurrentClass(currentClass, (sender as CheckBox).Checked);
        }

        private void checkBoxTrainRogue_CheckedChanged(object sender, EventArgs e)
        {
            var currentClass = Class.Rogue;

            addOrRemoveCurrentClass(currentClass, (sender as CheckBox).Checked);
        }

        /// <summary>
        /// Helper method for the Role Training Class Selection CheckChanged Events
        /// </summary>
        /// <param name="npcRoleTrainCastable"></param>
        /// <param name="classAddRemove"></param>
        /// <param name="boxChecked"></param>
        private void addOrRemoveCurrentClass(Class classAddRemove, bool boxChecked)
        {
            var currentTrain = NpcVM.Roles_Train[dataGridViewRolesTrain.CurrentRow.Index];

            if (boxChecked)
            {
                if(!(currentTrain.Class.Contains(classAddRemove))) currentTrain.Class.Add(classAddRemove);
            }
            else
            {
                for (int i = currentTrain.Class.Count - 1; i >= 0; i--)
                {
                    if (currentTrain.Class[i] == classAddRemove)
                    {
                        currentTrain.Class.RemoveAt(i);
                    }
                }
            }
        }
        #endregion

        #region Vendor Events
        private void checkBoxIsVendor_CheckedChanged(object sender, EventArgs e)
        {
            var chkboxIsVen = sender as CheckBox;
            if (chkboxIsVen.Checked)
            {
                if (checkBoxHasRoles.Checked)
                {
                    buttonVendorTabNameAdd.Visible = true;
                    buttonVendorTabNameRemove.Visible = true;
                    textBoxVendorTabName.ReadOnly = false;
                    if (NpcVM.Roles_Vend == null) NpcVM.Roles_Vend = new NpcRoleVend();
                    if (NpcVM.Roles_Vend_Tabs == null) NpcVM.Roles_Vend_Tabs = new BindingList<string>();
                    listBoxVendorTabNames.DataSource = null;
                    listBoxVendorTabNames.DataSource = NpcVM.Roles_Vend_Tabs;
                }
                else
                {
                    MessageBox.Show("Has Roles must be checked first.");
                    chkboxIsVen.Checked = false;
                }
            }
            else
            {
                dataGridViewVendorItems.ReadOnly = true;
                textBoxVendorTabName.ReadOnly = true;
                buttonVendorTabNameAdd.Visible = false;
                buttonVendorTabNameRemove.Visible = false;
                checkBoxVendorHasItems.Checked = false;
                NpcVM.Roles_Vend = null;
                NpcVM.Roles_Vend_Tabs.Clear();
            }
        }

        private void checkBoxVendorHasItems_CheckedChanged(object sender, EventArgs e)
        {
            var chkboxVendorHasItems = sender as CheckBox;
            if (chkboxVendorHasItems.Checked)
            {
                if (checkBoxHasVendor.Checked)
                {
                    if (NpcVM.Roles_Vend_Items == null) NpcVM.Roles_Vend_Items = new BindingList<NpcRoleVendItem>();
                    dataGridViewVendorItems.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Is Vendor must be checked first.");
                    chkboxVendorHasItems.Checked = false;
                }
            }
            else
            {
                dataGridViewVendorItems.ReadOnly = true;
                NpcVM.Roles_Vend_Items.Clear();
            }
        }

        private void dataGridViewVendorItems_DataError(object sender, DataGridViewDataErrorEventArgs error)
        {
            //MessageBox.Show("Error: " + error.Context.ToString());
            var cellColumnName = (sender as DataGridView).Columns[error.ColumnIndex].Name;
            var errorText = string.Empty;

            if (error.Context.HasFlag(DataGridViewDataErrorContexts.CurrentCellChange) && (cellColumnName.Equals("Quantity") || cellColumnName.Equals("Restock")))
            {
                errorText = "may only contain numeric values.";
            }
            MessageBox.Show(cellColumnName + " " + errorText);
        }

        private void buttonVendorTabNameAdd_Click(object sender, EventArgs e)
        {
            if (!(NpcVM.Roles_Vend_Tabs.Contains(textBoxVendorTabName.Text)))
            {
                NpcVM.Roles_Vend_Tabs.Add(textBoxVendorTabName.Text);
            }
            listBoxVendorTabNames.DataSource = null;
            listBoxVendorTabNames.DataSource = NpcVM.Roles_Vend_Tabs;
        }

        private void buttonVendorTabNameRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxVendorTabNames.SelectedIndex;
            try
            {
                NpcVM.Roles_Vend_Tabs.RemoveAt(selectedIndex);
            }
            catch (Exception ex)
            {

            }
            listBoxVendorTabNames.DataSource = null;
            listBoxVendorTabNames.DataSource = NpcVM.Roles_Vend_Tabs;
        }
        #endregion

        #region Post Events
        private void checkBoxHasPost_CheckedChanged(object sender, EventArgs e)
        {
            var chkboxIsPost = sender as CheckBox;
            if (chkboxIsPost.Checked)
            {
                if (checkBoxHasRoles.Checked)
                {
                    dataGridViewPostSurcharge.ReadOnly = false;
                    textBoxPostReceive.ReadOnly = false;
                    if (NpcVM.Roles_Post == null) NpcVM.Roles_Post = new NpcRolePost();
                    if (NpcVM.Roles_Post_Surcharge == null) NpcVM.Roles_Post_Surcharge = new BindingList<NpcRolePostSurcharge>();

                }
                else
                {
                    MessageBox.Show("Has Roles must be checked first.");
                    chkboxIsPost.Checked = false;
                }
            }
            else
            {
                dataGridViewPostSurcharge.ReadOnly = true;
                textBoxPostReceive.ReadOnly = true;
                NpcVM.Roles_Post_Receive = string.Empty;
                NpcVM.Roles_Post = null;
                NpcVM.Roles_Post_Surcharge.Clear();
            }
        }
        #endregion

        #region Repair Events

        private void checkBoxHasRepairs_CheckedChanged(object sender, EventArgs e)
        {
            var chkboxHasRepair = sender as CheckBox;
            if (chkboxHasRepair.Checked)
            {
                if (checkBoxHasRoles.Checked)
                {
                    textBoxRepairNation.ReadOnly = false;
                    numericUpDownRepairDiscount.ReadOnly = false;
                    if (NpcVM.Roles_Repair == null) NpcVM.Roles_Repair = new NpcRoleRepair();
                    if (NpcVM.Roles_Repair_Nation == null) NpcVM.Roles_Repair_Nation = string.Empty;
                    if (NpcVM.Roles_Repair_Type == null) NpcVM.Roles_Repair_Type = new BindingList<NpcRepairType>();
                }
                else
                {
                    MessageBox.Show("Has Roles must be checked first.");
                    chkboxHasRepair.Checked = false;
                }
            }
            else
            {
                textBoxRepairNation.ReadOnly = true;
                NpcVM.Roles_Repair_Nation = string.Empty;
                numericUpDownRepairDiscount.ReadOnly = true;
                NpcVM.Roles_Repair_Discount = 0;
                checkBoxRepairArmor.Checked = false;
                checkBoxRepairWeapon.Checked = false;
                checkBoxRepairAll.Checked = false;

                NpcVM.Roles_Repair = null;
                NpcVM.Roles_Repair_Type = null;
            }
        }

        private void checkBoxRepairArmor_CheckedChanged(object sender, EventArgs e)
        {
            var repairOptions = NpcVM.Roles_Repair_Type;
            var repairType = NpcRepairType.Armor;
            if ((sender as CheckBox).Checked)
            {
                if (!(repairOptions.Contains(repairType))) repairOptions.Add(repairType);
            }
            else
            {
                for (int i = repairOptions.Count - 1; i >= 0; i--)
                {
                    if (repairOptions[i] == repairType)
                    {
                        repairOptions.RemoveAt(i);
                    }
                }
            }
        }

        private void checkBoxRepairWeapon_CheckedChanged(object sender, EventArgs e)
        {
            var repairOptions = NpcVM.Roles_Repair_Type;
            var repairType = NpcRepairType.Weapon;
            if ((sender as CheckBox).Checked)
            {
                if (!(repairOptions.Contains(repairType))) repairOptions.Add(repairType);
            }
            else
            {
                for (int i = repairOptions.Count - 1; i >= 0; i--)
                {
                    if (repairOptions[i] == repairType)
                    {
                        repairOptions.RemoveAt(i);
                    }
                }
            }
        }

        private void checkBoxRepairAll_CheckedChanged(object sender, EventArgs e)
        {
            var repairOptions = NpcVM.Roles_Repair_Type;
            var repairType = NpcRepairType.All;
            if ((sender as CheckBox).Checked)
            {
                if (!(repairOptions.Contains(repairType))) repairOptions.Add(repairType);
            }
            else
            {
                for (int i = repairOptions.Count - 1; i >= 0; i--)
                {
                    if (repairOptions[i] == repairType)
                    {
                        repairOptions.RemoveAt(i);
                    }
                }
            }
        }
        #endregion

        #region Bank Events
        private void checkBoxHasBank_CheckedChanged(object sender, EventArgs e)
        {
            var checkboxBank = sender as CheckBox;
            if (checkboxBank.Checked)
            {
                if (checkBoxHasRoles.Checked)
                {
                    textBoxBankDiscount.ReadOnly = false;
                    if (NpcVM.Roles_Bank == null) NpcVM.Roles_Bank = new NpcRoleBank();
                }
                else
                {
                    MessageBox.Show("Has Roles must be checked first.");
                    checkboxBank.Checked = false;
                }
            }
            else
            {
                textBoxBankDiscount.ReadOnly = true;
                NpcVM.Roles_Bank_Discount = string.Empty;
                NpcVM.Roles_Bank = null;
            }
        }
        #endregion


        #region Inventory Events
        private void checkBoxHasInventory_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                numericUpDownInvGold.ReadOnly = false;
                if (NpcVM.Inventory == null) NpcVM.Inventory = new NpcInventory();
            }
            else
            {
                checkBoxHasInvItem.Checked = false;
                numericUpDownInvGold.ReadOnly = true;
                NpcVM.Inventory_Gold = 0;
                NpcVM.Inventory = null;
            }
        }

        private void checkBoxHasInventoryItem_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                textBoxInvItemValue.ReadOnly = false;
                numericUpDownInvQty.ReadOnly = false;
                numericUpDownInvRefresh.ReadOnly = false;
                if (NpcVM.Inventory == null) NpcVM.Inventory_Item = new NpcInventoryItem();
            }
            else
            {
                textBoxInvItemValue.ReadOnly = true;
                NpcVM.Inventory_Item_Value = string.Empty;
                NpcVM.Inventory_Item_Quantity = 0;
                NpcVM.Inventory_Item_Refresh = 0;
                numericUpDownInvQty.ReadOnly = true;
                numericUpDownInvRefresh.ReadOnly = true;
                NpcVM.Inventory_Item = null;
            }
        }
        #endregion



    }
}
