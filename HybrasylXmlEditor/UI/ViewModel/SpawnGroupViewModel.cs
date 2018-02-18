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
    public class SpawnGroupViewModel : INotifyPropertyChanged
    {
        #region Private Fields
        private BindingList<Map> _maps;
        private BindingList<Spawn> _spawns;
        #endregion

        #region Properties
        public BindingList<Map> Maps { get { return _maps; } set { _maps = value; OnPropertyChanged(); } }
        public BindingList<Spawn> Spawn { get { return _spawns; } set { _spawns = value; OnPropertyChanged(); } }
        #endregion

        public SpawnGroup SpawnGroup { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SpawnGroupViewModel(SpawnGroup spawnGroup)
        {
            this.SpawnGroup = spawnGroup;
        }

        public void SetDisplaySpawnGroup(SpawnGroup spawnGroup)
        {
            this.Maps = new BindingList<Map>(spawnGroup.Maps);
            this.Spawn = new BindingList<Spawn>(spawnGroup.Spawns);
        }

        public SpawnGroup GetDisplaySpawnGroup()
        {
            var newSpawnGroup = new SpawnGroup();
            newSpawnGroup.Maps = this.Maps.ToList();
            newSpawnGroup.Spawns = this.Spawn.ToList();

            return newSpawnGroup;
        }
    }
}
