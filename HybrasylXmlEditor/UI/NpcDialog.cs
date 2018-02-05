using Hybrasyl.Creatures;
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
            //setupDataGridView();
        }

        private void setBindings()
        {
            textBoxName.DataBindings.Add("Text", NpcVM, "Name");
            textBoxDisplayName.DataBindings.Add("Text", NpcVM, "DisplayName");

            numericUpDownAppearanceSprite.DataBindings.Add("Value", NpcVM, "Appearance_Sprite");
            textBoxAppearancePortrait.DataBindings.Add("Text", NpcVM, "Appearance_Portrait");

            //dataGridViewRolesTrain.AutoGenerateColumns = true;
            setupDataGridView();
            if (NpcVM.Roles_Train != null) dataGridViewRolesTrain.DataSource = NpcVM.Roles_Train;
            else dataGridViewRolesTrain.DataSource = new List<NpcRoleTrainCastable>();

            textBoxInvItemValue.DataBindings.Add("Text", NpcVM, "Inventory_Item_Value");
            numericUpDownInvQty.DataBindings.Add("Value", NpcVM, "Inventory_Item_Quantity");
            numericUpDownInvRefresh.DataBindings.Add("Value", NpcVM, "Inventory_Item_Refresh");
            numericUpDownInvGold.DataBindings.Add("Value", NpcVM, "Inventory_Gold");

            numericUpDownMapX.DataBindings.Add("Value", NpcVM, "X");
            numericUpDownMapY.DataBindings.Add("Value", NpcVM, "Y");
        }

        private void setupDataGridView()
        {
            dataGridViewRolesTrain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRolesTrain.MultiSelect = false;
            //dataGridViewRolesTrain.AllowUserToAddRows = false;
            dataGridViewRolesTrain.RowHeadersVisible = false;
            //dataGridViewRolesTrain.EditMode = DataGridViewEditMode.EditProgrammatically;
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

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file");
                }
            }
            loadFlags();
        }

        private void loadFlags()
        {
            if (NpcVM.Appearance != null)
            {
                checkBoxHasAppearance.Checked = true;
            }
            if (NpcVM.Roles != null)
            {
                checkBoxHasRoles.Checked = true;
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
                NpcVM.Appearance = null;
            }
        }

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
                numericUpDownInvQty.ReadOnly = true;
                numericUpDownInvRefresh.ReadOnly = true;
                NpcVM.Inventory_Item = null;
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
                //various fields should be marked as read-only
                NpcVM.Roles = null;
                if (checkBoxHasTrain.Checked)
                {
                    checkBoxHasTrain.Checked = false;
                }
            }
        }

        private void checkBoxHasTrain_CheckedChanged(object sender, EventArgs e)
        {
            var senderChkBox = sender as CheckBox;
            if (senderChkBox.Checked)
            {
                if (checkBoxHasRoles.Checked)
                {

                }
                else
                {
                    MessageBox.Show("Has Roles must be checked first.");
                    senderChkBox.Checked = false;
                }
            }
        }

        private void dataGridViewRolesTrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewRolesTrain.CurrentRow.Index;
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

    }
}
