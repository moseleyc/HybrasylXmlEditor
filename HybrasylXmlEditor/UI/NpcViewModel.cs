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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HybrasylXmlEditor.UI
{
    class NpcViewModel : INotifyPropertyChanged
    {
        #region Private fields
        private string _name;
        private string _displayName;
        private NpcAppearance _appearance;
        #region Appearance
        private ushort _appearance_Sprite;
        private string _appearance_Portrait;
        #endregion
        private NpcRoleList _roles;
        #region NpcRoles
        private BindingList<NpcRoleTrainCastable> _roles_Train; //LIST

        private NpcRoleVend _roles_Vend;
        #region NpcRoleVend
        private BindingList<NpcRoleVendItem> _roles_Vend_Items; //LIST
        private BindingList<string> _roles_Vend_Tabs; //LIST
        #endregion
        private NpcRolePost _roles_Post;
        #region NpcRolePost
        private BindingList<NpcRolePostSurcharge> _roles_Post_Surcharge; //LIST
        private string _roles_Post_Receive;
        #endregion
        private NpcRoleRepair _roles_Repair;
        #region NpcRoleRepair
        private string _roles_Repair_Nation;
        private int _roles_Repair_Discount;
        private BindingList<NpcRepairType> _roles_Repair_Type; //LIST
        #endregion
        private NpcRoleBank _roles_Bank;
        #region NpcRoleBank
        private string _roles_Bank_Discount;
        #endregion
        #endregion
        private NpcInventory _inventory;
        #region NpcInventory
        private NpcInventoryItem _inventory_Item;
        #region InventoryItem
        private uint _inventory_Item_Quantity;
        private uint _inventory_Item_Refresh;
        private string _inventory_Item_Value;
        #endregion
        private byte _inventory_Gold;
        #endregion
        private byte _x;
        private byte _y;
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public NpcViewModel(Npc npc)
        {
            this.Npc = npc;
        }

        public void SetDisplayNpc(Npc npc)
        {
            this.Name = npc.Name;
            this.DisplayName = npc.DisplayName;
            this.Appearance = npc.Appearance;
            this.Appearance_Sprite = npc.Appearance.Sprite;
            this.Appearance_Portrait = npc.Appearance.Portrait;
            this.Roles = npc.Roles;

            this.Roles_Train = new BindingList<NpcRoleTrainCastable>(npc.Roles.Train);

            this.Roles_Vend = npc.Roles.Vend;
            this.Roles_Vend_Items = new BindingList<NpcRoleVendItem>(npc.Roles.Vend.Items);
            this.Roles_Vend_Tabs = new BindingList<string>(npc.Roles.Vend.Tabs);

            this.Roles_Post = npc.Roles.Post;
            this.Roles_Post_Surcharge = new BindingList<NpcRolePostSurcharge>(npc.Roles.Post.Surcharge);
            this.Roles_Post_Receive = npc.Roles.Post.Receive;

            this.Roles_Repair = npc.Roles.Repair;
            this.Roles_Repair_Nation = npc.Roles.Repair.Nation;
            this.Roles_Repair_Discount = npc.Roles.Repair.Discount;
            this.Roles_Repair_Type = new BindingList<NpcRepairType>(npc.Roles.Repair.Type);

            this.Roles_Bank = npc.Roles.Bank;
            this.Roles_Bank_Discount = npc.Roles.Bank.Discount;

            this.Inventory = npc.Inventory;
            this.Inventory_Item = npc.Inventory.Item;
            this.Inventory_Item_Quantity = npc.Inventory.Item.Quantity;
            this.Inventory_Item_Refresh = npc.Inventory.Item.Refresh;
            this.Inventory_Item_Value = npc.Inventory.Item.Value;
            this.Inventory_Gold = npc.Inventory.Gold;

            this.X = npc.X;
            this.Y = npc.Y;
        }

        public Npc GetDisplayNpc()
        {
            var newNpc = new Npc();

            newNpc.Name = this.Name;
            newNpc.DisplayName = this.DisplayName;
            newNpc.Appearance = this.Appearance;
            newNpc.Appearance.Sprite = this.Appearance_Sprite;
            newNpc.Appearance.Portrait = this.Appearance_Portrait;
            newNpc.Roles = this.Roles;

            newNpc.Roles.Train = this.Roles_Train.ToList();

            newNpc.Roles.Vend = this.Roles_Vend;
            newNpc.Roles.Vend.Items = this.Roles_Vend_Items.ToList();
            newNpc.Roles.Vend.Tabs = this.Roles_Vend_Tabs.ToList();

            newNpc.Roles.Post = this.Roles_Post;
            newNpc.Roles.Post.Surcharge = this.Roles_Post_Surcharge.ToList();
            newNpc.Roles.Post.Receive = this.Roles_Post_Receive;

            newNpc.Roles.Repair = this.Roles_Repair;
            newNpc.Roles.Repair.Nation = this.Roles_Repair_Nation;
            newNpc.Roles.Repair.Discount = this.Roles_Repair_Discount;
            newNpc.Roles.Repair.Type = this.Roles_Repair_Type.ToList();

            newNpc.Roles.Bank = this.Roles_Bank;
            newNpc.Roles.Bank.Discount = this.Roles_Bank_Discount;

            newNpc.Inventory = this.Inventory;
            newNpc.Inventory.Item = this.Inventory_Item;
            newNpc.Inventory.Item.Quantity = this.Inventory_Item_Quantity;
            newNpc.Inventory.Item.Refresh = this.Inventory_Item_Refresh;
            newNpc.Inventory.Item.Value = this.Inventory_Item_Value;
            newNpc.Inventory.Gold = this.Inventory_Gold;

            newNpc.X = this.X;
            newNpc.Y = this.Y;


            return newNpc;
        }

        public Npc Npc { get; set; }

        #region Properties
        private string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }
        private string DisplayName { get { return _displayName; } set { _displayName = value; OnPropertyChanged(); } }
        private NpcAppearance Appearance { get { return _appearance; } set { _appearance = value; OnPropertyChanged(); } }
        private ushort Appearance_Sprite { get { return _appearance_Sprite; } set { _appearance_Sprite = value; OnPropertyChanged(); } }
        private string Appearance_Portrait { get { return _appearance_Portrait; } set { _appearance_Portrait = value; OnPropertyChanged(); } }
        private NpcRoleList Roles { get { return _roles; } set { _roles = value; OnPropertyChanged(); } }
        private BindingList<NpcRoleTrainCastable> Roles_Train { get { return _roles_Train; } set { _roles_Train = value; OnPropertyChanged(); } }
        private NpcRoleVend Roles_Vend { get { return _roles_Vend; } set { _roles_Vend = value; OnPropertyChanged(); } }
        private BindingList<NpcRoleVendItem> Roles_Vend_Items { get { return _roles_Vend_Items; } set { _roles_Vend_Items = value; OnPropertyChanged(); } }
        private BindingList<string> Roles_Vend_Tabs { get { return _roles_Vend_Tabs; } set { _roles_Vend_Tabs = value; OnPropertyChanged(); } }
        private NpcRolePost Roles_Post { get { return _roles_Post; } set { _roles_Post = value; OnPropertyChanged(); } }
        private BindingList<NpcRolePostSurcharge> Roles_Post_Surcharge { get { return _roles_Post_Surcharge; } set { _roles_Post_Surcharge = value; OnPropertyChanged(); } }
        private string Roles_Post_Receive { get { return _roles_Post_Receive; } set { _roles_Post_Receive = value; OnPropertyChanged(); } }
        private NpcRoleRepair Roles_Repair { get { return _roles_Repair; } set { _roles_Repair = value; OnPropertyChanged(); } }
        private string Roles_Repair_Nation { get { return _roles_Repair_Nation; } set { _roles_Repair_Nation = value; OnPropertyChanged(); } }
        private int Roles_Repair_Discount { get { return _roles_Repair_Discount; } set { _roles_Repair_Discount = value; OnPropertyChanged(); } }
        private BindingList<NpcRepairType> Roles_Repair_Type { get { return _roles_Repair_Type; } set { _roles_Repair_Type = value; OnPropertyChanged(); } }
        private NpcRoleBank Roles_Bank { get { return _roles_Bank; } set { _roles_Bank = value; OnPropertyChanged(); } }
        private string Roles_Bank_Discount { get { return _roles_Bank_Discount; } set { _roles_Bank_Discount = value; OnPropertyChanged(); } }
        private NpcInventory Inventory { get { return _inventory; } set { _inventory = value; OnPropertyChanged(); } }
        private NpcInventoryItem Inventory_Item { get { return _inventory_Item; } set { _inventory_Item = value; OnPropertyChanged(); } }
        private uint Inventory_Item_Quantity { get { return _inventory_Item_Quantity; } set { _inventory_Item_Quantity = value; OnPropertyChanged(); } }
        private uint Inventory_Item_Refresh { get { return _inventory_Item_Refresh; } set { _inventory_Item_Refresh = value; OnPropertyChanged(); } }
        private string Inventory_Item_Value { get { return _inventory_Item_Value; } set { _inventory_Item_Value = value; OnPropertyChanged(); } }
        private byte Inventory_Gold { get { return _inventory_Gold; } set { _inventory_Gold = value; OnPropertyChanged(); } }
        private byte X { get { return _x; } set { _x = value; OnPropertyChanged(); } }
        private byte Y { get { return _y; } set { _y = value; OnPropertyChanged(); } }
        #endregion
    }
}
