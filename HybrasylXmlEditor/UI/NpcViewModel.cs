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
        private string _name;
        private string _displayName;
        private NpcAppearance _appearance;
        #region Appearance
        private ushort _appearance_Sprite;
        private string _appearance_Portrait;
        #endregion
        private NpcRoleList _roles;
        #region NpcRoles
        private List<NpcRoleTrainCastable> _train; //LIST

        private NpcRoleVend _vend;
        #region NpcRoleVend
        private List<NpcRoleVendItem> _vend_Items; //LIST
        private List<string> _vend_Tabs; //LIST
        #endregion
        private NpcRolePost _post;
        #region NpcRolePost
        private List<NpcRolePostSurcharge> _post_Surcharge; //LIST
        private string _post_Receive;
        #endregion
        private NpcRoleRepair _repair;
        #region NpcRoleRepair
        private string _repair_Nation;
        private int _repair_Discount;
        private List<NpcRepairType> _repair_Type; //LIST
        #endregion
        private NpcRoleBank _bank;
        #region NpcRoleBank
        private string _bank_Discount;
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
        

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public NpcViewModel(Npc npc)
        {
            this.Npc = npc;
        }



        public Npc Npc { get; set; }
    }
}
