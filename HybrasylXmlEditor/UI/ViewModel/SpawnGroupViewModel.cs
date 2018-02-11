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
