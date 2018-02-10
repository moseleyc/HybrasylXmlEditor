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

namespace HybrasylXmlEditor.UI.ViewModel
{
    public class MonsterViewModel : INotifyPropertyChanged
    {

        private string _name;
        private string _description;
        private ushort _sprite;

        public Creature Monster { get; set; }

        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }
        public string Description { get { return _description; } set { _description = value; OnPropertyChanged(); } }
        public ushort Sprite { get { return _sprite; } set { _sprite = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MonsterViewModel(Creature monster)
        {
            this.Monster = monster;
        }

        public void SetDisplayMonster(Creature monster)
        {
            this.Name = monster.Name;
            this.Description = monster.Description;
            this.Sprite = monster.Sprite;
        }

        public Creature GetDisplayMonster()
        {
            var newMonster = new Creature();
            newMonster.Name = this.Name;
            newMonster.Description = this.Description;
            newMonster.Sprite = this.Sprite;

            return newMonster;

            //return new Creature
            //{
            //    Name = this.Name,
            //    Description = this.Description,
            //    Sprite = this.Sprite
            //};
        }
        



    }
}
