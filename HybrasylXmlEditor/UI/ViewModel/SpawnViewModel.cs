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
        private string _script_Value;
        private ScriptType _script_Type;

        private IntentList _intents;
        #region Intents Sub-Properties
        private Intent _intents_Npc;
        private string _intents_Npc_Value;
        private IntentType _intents_Npc_Type;

        private Intent _intents_Player;
        private string _intents_Player_Value;
        private IntentType _intents_Player_Type;

        private Intent _intents_Monster;
        private string _intents_Monster_Value;
        private IntentType _intents_Monster_Type;
        #endregion



        private Respawn _respawn;
        private Damage _damage;
        private Defense _defense;
        private Stats _stats;
        private LootList _loot;
        private BindingList<Castable> _castables;
        private string _base;
        private float _variance;
        #endregion

        #region Properties
        public CreatureScript Script { get { return _script; } set { _script = value; OnPropertyChanged(); } }
        public string Script_Value { get { return _script_Value; } set { _script_Value = value; OnPropertyChanged(); } }
        public ScriptType Script_Type { get { return _script_Type; } set { _script_Type = value; OnPropertyChanged(); } }

        public IntentList Intents { get { return _intents; } set { _intents = value; OnPropertyChanged(); } }
        #region Intents Sub-Properties
        public Intent Intents_Npc { get { return _intents_Npc; } set { _intents_Npc = value; OnPropertyChanged(); } }
        public string Intents_Npc_Value { get { return _intents_Npc_Value; } set { _intents_Npc_Value = value; OnPropertyChanged(); } }
        public IntentType Intents_Npc_Type { get { return _intents_Npc_Type; } set { _intents_Npc_Type = value; OnPropertyChanged(); } }

        public Intent Intents_Player { get { return _intents_Player; } set { _intents_Player = value; OnPropertyChanged(); } }
        public string Intents_Player_Value { get { return _intents_Player_Value; } set { _intents_Player_Value = value; OnPropertyChanged(); } }
        public IntentType Intents_Player_Type { get { return _intents_Player_Type; } set { _intents_Player_Type = value; OnPropertyChanged(); } }

        public Intent Intents_Monster { get { return _intents_Monster; } set { _intents_Monster = value; OnPropertyChanged(); } }
        public string Intents_Monster_Value { get { return _intents_Monster_Value; } set { _intents_Monster_Value = value; OnPropertyChanged(); } }
        public IntentType Intents_Monster_Type { get { return _intents_Monster_Type; } set { _intents_Monster_Type = value; OnPropertyChanged(); } }
        #endregion

        public Respawn Respawn { get { return _respawn; } set { _respawn = value; OnPropertyChanged(); } }

        public Damage Damage { get { return _damage; } set { _damage = value; OnPropertyChanged(); } }

        public Defense Defense { get { return _defense; } set { _defense = value; OnPropertyChanged(); } }

        public Stats Stats { get { return _stats; } set { _stats = value; OnPropertyChanged(); } }

        public LootList LootList { get { return _loot; } set { _loot = value; OnPropertyChanged(); } }

        public BindingList<Castable> Castables { get { return _castables; } set { _castables = value; OnPropertyChanged(); } }

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
            if(this.Script != null)
            {
                newSpawn.Script = new CreatureScript();
                newSpawn.Script.Value = this.Script_Value;
                newSpawn.Script.type = this.Script_Type;
            }
            if(this.Intents != null)
            {
                newSpawn.Intents = this.Intents;
                if(this.Intents_Npc != null)
                {
                    newSpawn.Intents.Npc = this.Intents_Npc;
                    newSpawn.Intents.Npc.Value = this.Intents_Npc_Value;
                    newSpawn.Intents.Npc.intent = this.Intents_Npc_Type;
                }
                if(this.Intents_Player != null)
                {
                    newSpawn.Intents.Player = this.Intents_Player;
                    newSpawn.Intents.Player.Value = this.Intents_Player_Value;
                    newSpawn.Intents.Player.intent = this.Intents_Player_Type;
                }
                if (this.Intents_Monster != null)
                {
                    newSpawn.Intents.Monster = this.Intents_Monster;
                    newSpawn.Intents.Monster.Value = this.Intents_Monster_Value;
                    newSpawn.Intents.Monster.intent = this.Intents_Monster_Type;
                }
            }

            //if(this.Damage_Element.Count > 0)
            //{
            //    newSpawn.Damage.Element = this.Damage_Element.ToList();
            //}

            if(this.Castables != null)
            {

            }
            newSpawn.Base = this.Base;
            newSpawn.Variance = this.Variance;

            return newSpawn;
        }

        public void SetDisplaySpawn(Spawn spawn)
        {
            if(spawn.Script != null)
            {
                this.Script = spawn.Script;
                this.Script_Value = spawn.Script.Value;
                this.Script_Type = spawn.Script.type;
            }

            if(spawn.Intents != null)
            {
                this.Intents = spawn.Intents;
                if (spawn.Intents.Npc != null)
                {
                    this.Intents_Npc = spawn.Intents.Npc;
                    this.Intents_Npc_Value = spawn.Intents.Npc.Value;
                    this.Intents_Npc_Type = spawn.Intents.Npc.intent;
                }
                if (spawn.Intents.Player != null)
                {
                    this.Intents_Player = spawn.Intents.Player;
                    this.Intents_Player_Value = spawn.Intents.Player.Value;
                    this.Intents_Player_Type = spawn.Intents.Player.intent;
                }
                if (spawn.Intents.Monster != null)
                {
                    this.Intents_Monster = spawn.Intents.Monster;
                    this.Intents_Monster_Value = spawn.Intents.Monster.Value;
                    this.Intents_Monster_Type = spawn.Intents.Monster.intent;
                }
            }

            this.Respawn = spawn.Respawn;

            this.Damage = spawn.Damage;

            this.Defense = spawn.Defense;

            this.Stats = spawn.Stats;

            this.LootList = spawn.Loot;
            
            if(spawn.Castables != null)
            {
                this.Castables = new BindingList<Castable>(spawn.Castables);
            }
            this.Base = spawn.Base;
            this.Variance = spawn.Variance;
        }
    }
}
