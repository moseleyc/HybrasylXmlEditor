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
        #region Respawn Sub-Properties
        private int _respawn_Interval;
        private int _respawn_Min;
        private int _respawn_Max;
        private float _respawn_Percentage;
        #endregion

        private Damage _damage;
        #region Damage Sub-Properties;
        private int _damage_Min;
        private int _damage_Max;
        private BindingList<Element> _damage_Elements;
        private DamageType _damage_Type;
        private byte _damage_Dmg;
        private byte _damage_Hit;
        #endregion

        private Defense _defense;
        #region Defense Sub-Properties
        private int _defense_Mr;
        private int _defense_Ac;
        private BindingList<Element> _defense_Elements;
        private byte _defense_Regen;
        #endregion

        private Stats _stats;
        #region Stat Sub-Properties
        private uint _stats_Hp;
        private uint _stats_Mp;
        private byte _stats_Level;
        private byte _stats_Str;
        private byte _stats_Int;
        private byte _stats_Wis;
        private byte _stats_Con;
        private byte _stats_Dex;
        #endregion

        private LootList _loot;
        #region Loot Sub-Properties
        private BindingList<LootImport> _loot_Set;
        private BindingList<LootTable> _loot_Table;
        private LootXp _loot_Xp;
        private uint _loot_Xp_Min;
        private uint _loot_Xp_Max;
        private LootGold _loot_Gold;
        private uint _loot_Gold_Min;
        private uint _loot_Gold_Max;
        #endregion
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
        #region Respawn Sub-Properties
        public int Respawn_Interval { get { return _respawn_Interval; } set { _respawn_Interval = value; OnPropertyChanged(); } }
        public int Respawn_Min { get { return _respawn_Min; } set { _respawn_Min = value; OnPropertyChanged(); } }
        public int Respawn_Max { get { return _respawn_Max; } set { _respawn_Max = value; OnPropertyChanged(); } }
        public float Respawn_Percentage { get { return _respawn_Percentage; } set { _respawn_Percentage = value; OnPropertyChanged(); } }
        #endregion

        public Damage Damage { get { return _damage; } set { _damage = value; OnPropertyChanged(); } }
        #region Damage Sub-Properties
        public int Damage_Min { get { return _damage_Min; } set { _damage_Min = value; OnPropertyChanged(); } }
        public int Damage_Max { get { return _damage_Max; } set { _damage_Max = value; OnPropertyChanged(); } }
        public BindingList<Element> Damage_Elements { get { return _damage_Elements; } set { _damage_Elements = value; OnPropertyChanged(); } }
        public DamageType Damage_Type { get { return _damage_Type; } set { _damage_Type = value; OnPropertyChanged(); } }
        public byte Damage_Dmg { get { return _damage_Dmg; } set { _damage_Dmg = value; OnPropertyChanged(); } }
        public byte Damage_Hit { get { return _damage_Hit; } set { _damage_Hit = value; OnPropertyChanged(); } }

        #endregion

        public Defense Defense { get { return _defense; } set { _defense = value; OnPropertyChanged(); } }
        #region Defense Sub-Properties
        public int Defense_Mr { get { return _defense_Mr; } set { _defense_Mr = value; OnPropertyChanged(); } }
        public int Defense_Ac { get { return _defense_Ac; } set { _defense_Ac = value; OnPropertyChanged(); } }
        public BindingList<Element> Defense_Elements { get { return _defense_Elements; } set { _defense_Elements = value; OnPropertyChanged(); } }
        public byte Defense_Regen { get { return _defense_Regen; } set { _defense_Regen = value; OnPropertyChanged(); } }
        #endregion

        public Stats Stats { get { return _stats; } set { _stats = value; OnPropertyChanged(); } }
        #region Stat Sub-Properties
        public uint Stats_Hp { get { return _stats_Hp; } set { _stats_Hp = value; OnPropertyChanged(); } }
        public uint Stats_Mp { get { return _stats_Mp; } set { _stats_Mp = value; OnPropertyChanged(); } }
        public byte Stats_Level { get { return _stats_Level; } set { _stats_Level = value; OnPropertyChanged(); } }
        public byte Stats_Str { get { return _stats_Str; } set { _stats_Str = value; OnPropertyChanged(); } }
        public byte Stats_Int { get { return _stats_Int; } set { _stats_Int = value; OnPropertyChanged(); } }
        public byte Stats_Wis { get { return _stats_Wis; } set { _stats_Wis = value; OnPropertyChanged(); } }
        public byte Stats_Con { get { return _stats_Con; } set { _stats_Con = value; OnPropertyChanged(); } }
        public byte Stats_Dex { get { return _stats_Dex; } set { _stats_Dex = value; OnPropertyChanged(); } }

        #endregion

        public LootList Loot { get { return _loot; } set { _loot = value; OnPropertyChanged(); } }
        #region Loot Sub-Properties
        public BindingList<LootImport> Loot_Set { get { return _loot_Set; } set { _loot_Set = value; OnPropertyChanged(); } }
        public BindingList<LootTable> Loot_Table { get { return _loot_Table; } set { _loot_Table = value; OnPropertyChanged(); } }
        public LootXp Loot_Xp { get { return _loot_Xp; } set { _loot_Xp = value; OnPropertyChanged(); } }
        public uint Loot_Xp_Min { get { return _loot_Xp_Min; } set { _loot_Xp_Min = value; OnPropertyChanged(); } }
        public uint Loot_Xp_Max { get { return _loot_Xp_Max; } set { _loot_Xp_Max = value; OnPropertyChanged(); } }
        public LootGold Loot_Gold { get { return _loot_Gold; } set { _loot_Gold = value; OnPropertyChanged(); } }
        public uint Loot_Gold_Min { get { return _loot_Gold_Min; } set { _loot_Gold_Min = value; OnPropertyChanged(); } }
        public uint Loot_Gold_Max { get { return _loot_Gold_Max; } set { _loot_Gold_Max = value; OnPropertyChanged(); } }
        #endregion

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

            newSpawn.Respawn = this.Respawn;
            newSpawn.Respawn.Interval = this.Respawn_Interval;
            newSpawn.Respawn.Min = this.Respawn_Min;
            newSpawn.Respawn.Max = this.Respawn_Max;
            newSpawn.Respawn.Percentage = this.Respawn_Percentage;

            newSpawn.Damage = this.Damage;
            newSpawn.Damage.Min = this.Damage_Min;
            newSpawn.Damage.Max = this.Damage_Max;
            if(this.Damage_Elements != null) { newSpawn.Damage.Element = this.Damage_Elements.ToList(); }
            else { newSpawn.Damage.Element = null; }
            newSpawn.Damage.Type = this.Damage_Type;
            newSpawn.Damage.Dmg = this.Damage_Dmg;
            newSpawn.Damage.Hit = this.Damage_Hit;

            newSpawn.Defense = this.Defense;
            newSpawn.Defense.Mr = this.Defense_Mr;
            newSpawn.Defense.Ac = this.Defense_Ac;
            if(this.Defense_Elements != null) { newSpawn.Defense.Element = this.Defense_Elements.ToList(); }
            else { newSpawn.Defense.Element = null; }
            newSpawn.Defense.Regen = this.Defense_Regen;

            newSpawn.Stats = this.Stats;
            newSpawn.Stats.Hp = this.Stats_Hp;
            newSpawn.Stats.Mp = this.Stats_Mp;
            newSpawn.Stats.Level = this.Stats_Level;
            newSpawn.Stats.Str = this.Stats_Str;
            newSpawn.Stats.Int = this.Stats_Int;
            newSpawn.Stats.Wis = this.Stats_Wis;
            newSpawn.Stats.Con = this.Stats_Con;
            newSpawn.Stats.Dex = this.Stats_Dex;

            newSpawn.Loot = this.Loot;

            if(this.Loot_Set != null)
            {
                newSpawn.Loot.Set = this.Loot_Set.ToList();
            }

            if(this.Loot_Table != null)
            {

            }

            if(this.Loot_Xp != null)
            {
                newSpawn.Loot.Xp = this.Loot_Xp;
                newSpawn.Loot.Xp.Min = this.Loot_Xp_Min;
                newSpawn.Loot.Xp.Max = this.Loot_Xp_Max;
            }

            if(this.Loot_Gold != null)
            {
                newSpawn.Loot.Gold = this.Loot_Gold;
                newSpawn.Loot.Gold.Min = this.Loot_Gold_Min;
                newSpawn.Loot.Gold.Max = this.Loot_Gold_Max;
            }

            if (this.Castables != null)
            {
                newSpawn.Castables = this.Castables.ToList();
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
            this.Respawn_Interval = spawn.Respawn.Interval;
            this.Respawn_Min = spawn.Respawn.Min;
            this.Respawn_Max = spawn.Respawn.Max;
            this.Respawn_Interval = spawn.Respawn.Interval;

            this.Damage = spawn.Damage;
            this.Damage_Min = spawn.Damage.Min;
            this.Damage_Max = spawn.Damage.Max;
            if(spawn.Damage.Element != null) { this.Damage_Elements = new BindingList<Element>(spawn.Damage.Element); }            
            this.Damage_Type = spawn.Damage.Type;
            this.Damage_Dmg = spawn.Damage.Dmg;
            this.Damage_Hit = spawn.Damage.Hit;

            this.Defense = spawn.Defense;
            this.Defense_Mr = spawn.Defense.Mr;
            this.Defense_Ac = spawn.Defense.Ac;
            if (spawn.Defense.Element != null) { this.Defense_Elements = new BindingList<Element>(spawn.Defense.Element); }
            this.Defense_Regen = spawn.Defense.Regen;

            this.Stats = spawn.Stats;
            this.Stats_Hp = spawn.Stats.Hp;
            this.Stats_Mp = spawn.Stats.Mp;
            this.Stats_Level = spawn.Stats.Level;
            this.Stats_Str = spawn.Stats.Str;
            this.Stats_Int = spawn.Stats.Int;
            this.Stats_Wis = spawn.Stats.Wis;
            this.Stats_Con = spawn.Stats.Con;
            this.Stats_Dex = spawn.Stats.Dex;

            this.Loot = spawn.Loot;
            
            if(spawn.Loot.Set != null)
            {
                this.Loot_Set = new BindingList<LootImport>(spawn.Loot.Set);
            }

            if(spawn.Loot.Table != null)
            {

            }

            if(spawn.Loot.Xp != null)
            {
                this.Loot_Xp = spawn.Loot.Xp;
                this.Loot_Xp_Min = spawn.Loot.Xp.Min;
                this.Loot_Xp_Max = spawn.Loot.Xp.Max;
            }

            if(spawn.Loot.Gold != null)
            {
                this.Loot_Gold = spawn.Loot.Gold;
                this.Loot_Gold_Min = spawn.Loot.Gold.Min;
                this.Loot_Gold_Max = spawn.Loot.Gold.Max;
            }


            if (spawn.Castables != null)
            {
                this.Castables = new BindingList<Castable>(spawn.Castables);
            }
            this.Base = spawn.Base;
            this.Variance = spawn.Variance;
        }
    }
}
