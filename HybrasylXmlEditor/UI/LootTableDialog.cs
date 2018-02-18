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
    public partial class LootTableDialog : Form
    {
        public LootTableViewModel LootTableVM { get; set; }

        public LootTableDialog()
        {
            InitializeComponent();
        }

        private void setBindings()
        {
            numericAttributeRolls.DataBindings.Add("Value", LootTableVM, "Rolls");
            numericAttributeChance.DataBindings.Add("Value", LootTableVM, "Chance");

            numericGoldMin.DataBindings.Add("Value", LootTableVM, "Gold_Min");
            numericGoldMax.DataBindings.Add("Value", LootTableVM, "Gold_Max");

            numericItemListAttributeRolls.DataBindings.Add("Value", LootTableVM, "Items_Rolls");
            numericItemListAttributeChance.DataBindings.Add("Value", LootTableVM, "Items_Chance");
        }

        private void setupDataGridView()
        {
            #region ItemList
            dataGridViewItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItemList.AllowUserToAddRows = true;
            dataGridViewItemList.MultiSelect = false;
            dataGridViewItemList.RowHeadersVisible = false;
            dataGridViewItemList.AllowUserToOrderColumns = false;
            dataGridViewItemList.AllowUserToResizeColumns = false;
            dataGridViewItemList.AllowUserToResizeRows = false;
            dataGridViewItemList.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn itemValue = new DataGridViewTextBoxColumn();
            itemValue.Name = "Value";
            itemValue.DataPropertyName = "Value";
            itemValue.HeaderText = "Value";
            itemValue.Width = 200;
            itemValue.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemValue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemValue.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewItemList.Columns.Add(itemValue);

            DataGridViewTextBoxColumn itemMin = new DataGridViewTextBoxColumn();
            itemMin.Name = "Min";
            itemMin.DataPropertyName = "Min";
            itemMin.HeaderText = "Min";
            itemMin.Width = 60;
            itemMin.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemMin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemMin.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewItemList.Columns.Add(itemMin);

            DataGridViewTextBoxColumn itemMax = new DataGridViewTextBoxColumn();
            itemMax.Name = "Max";
            itemMax.DataPropertyName = "Max";
            itemMax.HeaderText = "Max";
            itemMax.Width = 60;
            itemMax.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemMax.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemMax.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewItemList.Columns.Add(itemMax);

            DataGridViewCheckBoxColumn itemUnique = new DataGridViewCheckBoxColumn();
            itemUnique.Name = "Unique";
            itemUnique.DataPropertyName = "Unique";
            itemUnique.HeaderText = "Unique";
            itemUnique.Width = 60;
            itemUnique.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemUnique.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemUnique.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewItemList.Columns.Add(itemUnique);

            DataGridViewCheckBoxColumn itemAlways = new DataGridViewCheckBoxColumn();
            itemAlways.Name = "Always";
            itemAlways.DataPropertyName = "Always";
            itemAlways.HeaderText = "Always";
            itemAlways.Width = 60;
            itemAlways.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemAlways.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            itemAlways.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewItemList.Columns.Add(itemAlways);
            #endregion

            //#region Variant List
            //dataGridViewItemListItemVariants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewItemListItemVariants.AllowUserToAddRows = true;
            //dataGridViewItemListItemVariants.MultiSelect = false;
            //dataGridViewItemListItemVariants.RowHeadersVisible = false;
            //dataGridViewItemListItemVariants.AllowUserToOrderColumns = false;
            //dataGridViewItemListItemVariants.AllowUserToResizeColumns = false;
            //dataGridViewItemListItemVariants.AllowUserToResizeRows = false;
            //dataGridViewItemListItemVariants.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            //DataGridViewTextBoxColumn itemVariant = new DataGridViewTextBoxColumn();
            //itemVariant.Name = "Value";
            //itemVariant.DataPropertyName = "Value";
            //itemVariant.HeaderText = "Value";
            //itemVariant.Width = 200;
            //itemVariant.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //itemVariant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //itemVariant.SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewItemListItemVariants.Columns.Add(itemVariant);
            //#endregion
        }

        private void LootTableDialog_Load(object sender, EventArgs e)
        {
            LootTableVM.SetDisplayLootTable(LootTableVM.LootTable);
            setBindings();
            setupDataGridView();
            if(LootTableVM.Items != null)
            {
                checkBoxHasItemList.Checked = true;
            }
        }

        private void dataGridViewItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewItemList.CurrentRow.Index;
            textBoxItemListRowNumber.Text = index.ToString();
            if (LootTableVM.Items_Items != null)
            {
                int indexPlus = index + 1;
                if (LootTableVM.Items_Items.Count > 0)
                {
                    if (LootTableVM.Items_Items[index].Variants != null)
                    {
                        listBoxItemVariantText.DataSource = LootTableVM.Items_Items[index].Variants;
                    }
                    else
                    {
                        listBoxItemVariantText.DataSource = new BindingList<string>();
                    }
                }
            }
            else
            {
                LootTableVM.Items_Items = new BindingList<LootItem>();
                var test = LootTableVM.Items_Items;
                dataGridViewItemList.DataSource = LootTableVM.Items_Items;
            }
        }

        private void checkBoxHasItemList_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                dataGridViewItemList.ReadOnly = false;
                listBoxItemVariantText.Enabled = true;
                textBoxItemVariantText.ReadOnly = false;
                buttonVariantAdd.Enabled = true;
                buttonVariantRemove.Enabled = true;
                if (LootTableVM.Items == null)
                {
                    LootTableVM.Items = new LootTableItemList();
                    LootTableVM.Items_Items = new BindingList<LootItem>(LootTableVM.Items.Items);

                }
                dataGridViewItemList.DataSource = LootTableVM.Items_Items;
            }
            else
            {
                dataGridViewItemList.ReadOnly = true;
                listBoxItemVariantText.Enabled = false;
                textBoxItemVariantText.ReadOnly = true;
                buttonVariantAdd.Enabled = false;
                buttonVariantRemove.Enabled = false;
                LootTableVM.Items = null;
                LootTableVM.Items_Items = null;
            }
        }

        private void buttonVariantAdd_Click(object sender, EventArgs e)
        {
            if (LootTableVM.Items_Items.Count > 0)
            {
                listBoxItemVariantText.DataSource = null;
                int itemIndex = dataGridViewItemList.CurrentRow.Index;
                var itemVariantsList = LootTableVM.Items_Items[itemIndex].Variants;
                itemVariantsList.Add(textBoxItemVariantText.Text);
                listBoxItemVariantText.DataSource = itemVariantsList;
            }
        }

        private void buttonVariantRemove_Click(object sender, EventArgs e)
        {
            if (listBoxItemVariantText.SelectedItem != null)
            {
                int itemIndex = dataGridViewItemList.CurrentRow.Index;
                var itemVariantsList = LootTableVM.Items_Items[itemIndex].Variants;
                itemVariantsList.Remove((string)listBoxItemVariantText.SelectedItem);

                listBoxItemVariantText.DataSource = null;
                listBoxItemVariantText.DataSource = itemVariantsList;
            }
            else
            {
                MessageBox.Show("No rows or no row selected.");
            }
        }
    }
}
