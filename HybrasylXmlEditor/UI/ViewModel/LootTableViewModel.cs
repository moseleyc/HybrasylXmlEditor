using Hybrasyl.Creatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HybrasylXmlEditor.UI.ViewModel
{
    public class LootTableViewModel : INotifyPropertyChanged
    {
        #region Private
        private LootTableItemList _items;
        private BindingList<LootItem> _items_Items;

        //private int _items_Items_Min;
        //private int _items_Items_Max;
        //private bool _items_Items_Unique;
        //private bool _items_Items_Always;
        //private BindingList<string> _items_Items_Variants;
        //private string _items_Items_Value;

        private int _items_Rolls;
        private double _items_Chance;

        private LootTableGold _gold;
        private int _gold_Min;
        private int _gold_Max;
        private int _rolls;
        private double _chance;
        #endregion

        #region Properties
        public LootTableItemList Items { get { return _items; } set { _items = value; OnPropertyChanged(); } }
        public BindingList<LootItem> Items_Items { get { return _items_Items; } set { _items_Items = value; OnPropertyChanged(); } }

        //public int Items_Items_Min { get { return _items_Items_Min; } set { _items_Items_Min = value; OnPropertyChanged(); } }
        //public int Items_Items_Max { get { return _items_Items_Max; } set { _items_Items_Max = value; OnPropertyChanged(); } }
        //public bool Items_Items_Unique { get { return _items_Items_Unique; } set { _items_Items_Unique = value; OnPropertyChanged(); } }
        //public bool Items_Items_Always { get { return _items_Items_Always; } set { _items_Items_Always = value; OnPropertyChanged(); } }
        //public BindingList<string> Items_Items_Variants { get { return _items_Items_Variants; } set { _items_Items_Variants = value; OnPropertyChanged(); } }
        //public string Items_Items_Value { get { return _items_Items_Value; } set { _items_Items_Value = value; OnPropertyChanged(); } }

        public int Items_Rolls { get { return _items_Rolls; } set { _items_Rolls = value; OnPropertyChanged(); } }
        public double Items_Chance { get { return _items_Chance; } set { _items_Chance = value; OnPropertyChanged(); } }

        public LootTableGold Gold { get { return _gold; } set { _gold = value; OnPropertyChanged(); } }
        public int Gold_Min { get { return _gold_Min; } set { _gold_Min = value; OnPropertyChanged(); } }
        public int Gold_Max { get { return _gold_Max; } set { _gold_Max = value; OnPropertyChanged(); } }
        public int Rolls { get { return _rolls; } set { _rolls = value; OnPropertyChanged(); } }
        public double Chance { get { return _chance; } set { _chance = value; OnPropertyChanged(); } }
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LootTableViewModel(LootTable lootTable)
        {
            this.LootTable = lootTable;
        }

        public LootTable GetDisplayLootTable()
        {
            var newLootTable = new LootTable();

            if(this.Items != null)
            {
                newLootTable.Items = this.Items;
                newLootTable.Items.Rolls = this.Items_Rolls;
                newLootTable.Items.Chance = this.Items_Chance;

                if (this.Items_Items != null)
                {
                    newLootTable.Items.Items = this.Items_Items.ToList();
                }
            }           

            newLootTable.Gold = this.Gold;
            newLootTable.Gold.Min = this.Gold_Min;
            newLootTable.Gold.Max = this.Gold_Max;

            newLootTable.Rolls = this.Rolls;
            newLootTable.Chance = this.Chance;
            
            return newLootTable;
        }

        public void SetDisplayLootTable(LootTable lootTable)
        {
            //this = lootTable
            if(lootTable.Items != null)
            {
                this.Items = lootTable.Items;
                this.Items_Rolls = lootTable.Items.Rolls;
                this.Items_Chance = lootTable.Items.Chance;

                if (lootTable.Items.Items != null)
                {
                    this.Items_Items = new BindingList<LootItem>(lootTable.Items.Items);
                }
            }           

            this.Gold = lootTable.Gold;
            this.Gold_Min = lootTable.Gold.Min;
            this.Gold_Max = lootTable.Gold.Max;

            this.Rolls = lootTable.Rolls;
            this.Chance = lootTable.Chance;
        }

        public LootTable LootTable { get; set; }
    }
}
