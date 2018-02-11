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
    public class SpawnViewModel : INotifyPropertyChanged
    {
        #region Private
        private CreatureScript _script;
        private IntentList _intents;
        private Respawn _respawn;
        private Damage _damage;
        private Defense _defense;
        private Stats _stats;
        private LootList _loot;
        private List<Castable> _castables;
        private string _base;
        private float _variance;
        #endregion

        #region Properties


        public string Base { get { return _base; } set { _base = value; OnPropertyChanged(); } }
        public float Variance { get { return _variance; } set { _variance = value; OnPropertyChanged(); } }
        #endregion

        public Spawn Spawn { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SpawnViewModel(Spawn spawn)
        {
            this.Spawn = spawn;
        }

        public Spawn GetDisplaySpawn()
        {
            var newSpawn = new Spawn();
            newSpawn.Base = this.Base;
            newSpawn.Variance = this.Variance;

            return newSpawn;
        }

        public void SetDisplaySpawn(Spawn spawn)
        {
            this.Base = spawn.Base;
            this.Variance = spawn.Variance;
        }
    }
}
