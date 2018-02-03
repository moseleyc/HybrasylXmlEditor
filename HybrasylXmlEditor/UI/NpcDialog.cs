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
            setupDataGridView();
        }

        private void setBindings()
        {
            textBoxName.DataBindings.Add("Text", NpcVM, "Name");
            textBoxDisplayName.DataBindings.Add("Text", NpcVM, "DisplayName");

            numericUpDownAppearanceSprite.DataBindings.Add("Value", NpcVM, "Appearance_Sprite");
            textBoxAppearancePortrait.DataBindings.Add("Text", NpcVM, "Appearance_Portrait");



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
            dataGridViewRolesTrain.AllowUserToAddRows = false;
            dataGridViewRolesTrain.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewRolesTrain.AllowUserToOrderColumns = false;
            dataGridViewRolesTrain.AllowUserToResizeColumns = false;
            dataGridViewRolesTrain.AllowUserToResizeRows = false;
            dataGridViewRolesTrain.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn trainType = new DataGridViewTextBoxColumn();
            trainType.Name = "trainType";
            trainType.DataPropertyName = "Type";
            trainType.HeaderText = "Train Type";
            trainType.Width = 60;
            trainType.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainType.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainType.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewRolesTrain.Columns.Add(trainType);

            DataGridViewTextBoxColumn trainName = new DataGridViewTextBoxColumn();
            trainType.Name = "trainName";
            trainType.DataPropertyName = "Name";
            trainType.HeaderText = "Train Name";
            trainType.Width = 60;
            trainType.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainType.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            trainType.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewRolesTrain.Columns.Add(trainName);
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
            if(NpcVM.Appearance != null)
            {
                checkBoxHasAppearance.Checked = true;
            }
            if(NpcVM.Roles != null)
            {
                checkBoxHasRoles.Checked = true;
            }
            if(NpcVM.Inventory != null)
            {
                checkBoxHasInventory.Checked = true;
                if(NpcVM.Inventory.Item != null)
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
            if((sender as CheckBox).Checked)
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
    }
}
