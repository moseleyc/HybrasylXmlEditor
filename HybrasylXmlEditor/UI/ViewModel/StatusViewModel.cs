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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Hybrasyl.Statuses;

namespace HybrasylXmlEditor.UI.ViewModel
{
    public class StatusViewModel : INotifyPropertyChanged
    {

        private string _category;
        private CastRestriction _castRestriction;
        //CR Begin
        private string _castRestriction_Use;
        private string _castRestriction_Receive;
        //CR End

        private Effects _effects;

        #region OnApply
        private ushort _effects_OnApply_Animations_Target_Id;
        private short _effects_OnApply_Animations_Target_Speed;
        private ushort _effects_OnApply_Animations_SpellEffect_Id;
        private short _effects_OnApply_Animations_SpellEffect_Speed;

        private byte _effects_OnApply_Sound_Id;

        private string _effects_OnApply_Messages_Target;
        private string _effects_OnApply_Messages_Source;
        private string _effects_OnApply_Messages_Group;
        private string _effects_OnApply_Messages_Say;
        private string _effects_OnApply_Messages_Shout;

        private string _effects_OnApply_Heal_Simple_Min;
        private string _effects_OnApply_Heal_Simple_Max;
        private string _effects_OnApply_Heal_Simple_Value;
        private string _effects_OnApply_Heal_Formula;

        private DamageFlags _effects_OnApply_Damage_Flags;
        private string _effects_OnApply_Damage_Simple_Min;
        private string _effects_OnApply_Damage_Simple_Max;
        private string _effects_OnApply_Damage_Simple_Value;
        private string _effects_OnApply_Damage_Formula;
        private DamageType _effects_OnApply_Damage_Type;

        private sbyte _effects_OnApply_StatModifiers_Str;
        private sbyte _effects_OnApply_StatModifiers_Int;
        private sbyte _effects_OnApply_StatModifiers_Wis;
        private sbyte _effects_OnApply_StatModifiers_Con;
        private sbyte _effects_OnApply_StatModifiers_Dex;
        private int _effects_OnApply_StatModifiers_Hp;
        private int _effects_OnApply_StatModifiers_Mp;
        private sbyte _effects_OnApply_StatModifiers_Hit;
        private sbyte _effects_OnApply_StatModifiers_Dmg;
        private sbyte _effects_OnApply_StatModifiers_Ac;
        private sbyte _effects_OnApply_StatModifiers_Regen;
        private sbyte _effects_OnApply_StatModifiers_Mr;
        private Element _effects_OnApply_StatModifiers_OffensiveElement;
        private Element _effects_OnApply_StatModifiers_DefensiveElement;
        private float _effects_OnApply_StatModifiers_DmgModifier;
        private float _effects_OnApply_StatModifiers_HealModifier;
        private DamageType _effects_OnApply_StatModifiers_DmgType;
        private float _effects_OnApply_StatModifiers_ReflectChance;
        private float _effects_OnApply_StatModifiers_ReflectIntensity;

        private CreatureCondition _effects_OnApply_Conditions_Set;
        private List<string> _effects_OnApply_Conditions_Set_List;
        private CreatureCondition _effects_OnApply_Conditions_Unset;
        private List<string> _effects_OnApply_Conditions_Unset_List;
        #endregion

        #region OnTick
        private ushort _effects_OnTick_Animations_Target_Id;
        private short _effects_OnTick_Animations_Target_Speed;
        private ushort _effects_OnTick_Animations_SpellEffect_Id;
        private short _effects_OnTick_Animations_SpellEffect_Speed;

        private byte _effects_OnTick_Sound_Id;

        private string _effects_OnTick_Messages_Target;
        private string _effects_OnTick_Messages_Source;
        private string _effects_OnTick_Messages_Group;
        private string _effects_OnTick_Messages_Say;
        private string _effects_OnTick_Messages_Shout;

        private string _effects_OnTick_Heal_Simple_Min;
        private string _effects_OnTick_Heal_Simple_Max;
        private string _effects_OnTick_Heal_Simple_Value;
        private string _effects_OnTick_Heal_Formula;

        private DamageFlags _effects_OnTick_Damage_Flags;
        private string _effects_OnTick_Damage_Simple_Min;
        private string _effects_OnTick_Damage_Simple_Max;
        private string _effects_OnTick_Damage_Simple_Value;
        private string _effects_OnTick_Damage_Formula;
        private DamageType _effects_OnTick_Damage_Type;

        private sbyte _effects_OnTick_StatModifiers_Str;
        private sbyte _effects_OnTick_StatModifiers_Int;
        private sbyte _effects_OnTick_StatModifiers_Wis;
        private sbyte _effects_OnTick_StatModifiers_Con;
        private sbyte _effects_OnTick_StatModifiers_Dex;
        private int _effects_OnTick_StatModifiers_Hp;
        private int _effects_OnTick_StatModifiers_Mp;
        private sbyte _effects_OnTick_StatModifiers_Hit;
        private sbyte _effects_OnTick_StatModifiers_Dmg;
        private sbyte _effects_OnTick_StatModifiers_Ac;
        private sbyte _effects_OnTick_StatModifiers_Regen;
        private sbyte _effects_OnTick_StatModifiers_Mr;
        private Element _effects_OnTick_StatModifiers_OffensiveElement;
        private Element _effects_OnTick_StatModifiers_DefensiveElement;
        private float _effects_OnTick_StatModifiers_DmgModifier;
        private float _effects_OnTick_StatModifiers_HealModifier;
        private DamageType _effects_OnTick_StatModifiers_DmgType;
        private float _effects_OnTick_StatModifiers_ReflectChance;
        private float _effects_OnTick_StatModifiers_ReflectIntensity;

        private CreatureCondition _effects_OnTick_Conditions_Set;
        private List<string> _effects_OnTick_Conditions_Set_List;
        private CreatureCondition _effects_OnTick_Conditions_Unset;
        private List<string> _effects_OnTick_Conditions_Unset_List;
        #endregion

        #region OnRemove
        private ushort _effects_OnRemove_Animations_Target_Id;
        private short _effects_OnRemove_Animations_Target_Speed;
        private ushort _effects_OnRemove_Animations_SpellEffect_Id;
        private short _effects_OnRemove_Animations_SpellEffect_Speed;

        private byte _effects_OnRemove_Sound_Id;

        private string _effects_OnRemove_Messages_Target;
        private string _effects_OnRemove_Messages_Source;
        private string _effects_OnRemove_Messages_Group;
        private string _effects_OnRemove_Messages_Say;
        private string _effects_OnRemove_Messages_Shout;

        private string _effects_OnRemove_Heal_Simple_Min;
        private string _effects_OnRemove_Heal_Simple_Max;
        private string _effects_OnRemove_Heal_Simple_Value;
        private string _effects_OnRemove_Heal_Formula;

        private DamageFlags _effects_OnRemove_Damage_Flags;
        private string _effects_OnRemove_Damage_Simple_Min;
        private string _effects_OnRemove_Damage_Simple_Max;
        private string _effects_OnRemove_Damage_Simple_Value;
        private string _effects_OnRemove_Damage_Formula;
        private DamageType _effects_OnRemove_Damage_Type;

        private sbyte _effects_OnRemove_StatModifiers_Str;
        private sbyte _effects_OnRemove_StatModifiers_Int;
        private sbyte _effects_OnRemove_StatModifiers_Wis;
        private sbyte _effects_OnRemove_StatModifiers_Con;
        private sbyte _effects_OnRemove_StatModifiers_Dex;
        private int _effects_OnRemove_StatModifiers_Hp;
        private int _effects_OnRemove_StatModifiers_Mp;
        private sbyte _effects_OnRemove_StatModifiers_Hit;
        private sbyte _effects_OnRemove_StatModifiers_Dmg;
        private sbyte _effects_OnRemove_StatModifiers_Ac;
        private sbyte _effects_OnRemove_StatModifiers_Regen;
        private sbyte _effects_OnRemove_StatModifiers_Mr;
        private Element _effects_OnRemove_StatModifiers_OffensiveElement;
        private Element _effects_OnRemove_StatModifiers_DefensiveElement;
        private float _effects_OnRemove_StatModifiers_DmgModifier;
        private float _effects_OnRemove_StatModifiers_HealModifier;
        private DamageType _effects_OnRemove_StatModifiers_DmgType;
        private float _effects_OnRemove_StatModifiers_ReflectChance;
        private float _effects_OnRemove_StatModifiers_ReflectIntensity;

        private CreatureCondition _effects_OnRemove_Conditions_Set;
        private List<string> _effects_OnRemove_Conditions_Set_List;
        private CreatureCondition _effects_OnRemove_Conditions_Unset;
        private List<string> _effects_OnRemove_Conditions_Unset_List;
        #endregion

        private string _prohibitedMessage;
        private string _script;
        private int _duration;
        private int _tick;
        private ushort _icon;
        private string _name;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public StatusViewModel(Status status)
        {
            this.Status = status;
        }

        public void SetDisplayStatus(Status status)
        {
            this.Category = status.Category;
            this.Effects = status.Effects;
            #region OnApply
            this.Effects_OnApply_Animations_Target_Id = status.Effects.OnApply.Animations.Target.Id;
            this.Effects_OnApply_Animations_Target_Speed = status.Effects.OnApply.Animations.Target.Speed;
            this.Effects_OnApply_Animations_SpellEffect_Id = status.Effects.OnApply.Animations.SpellEffect.Id;
            this.Effects_OnApply_Animations_SpellEffect_Speed = status.Effects.OnApply.Animations.SpellEffect.Speed;

            this.Effects_OnApply_Sound_Id = status.Effects.OnApply.Sound.Id;

            this.Effects_OnApply_Messages_Target = status.Effects.OnApply.Messages.Target;
            this.Effects_OnApply_Messages_Source = status.Effects.OnApply.Messages.Source;
            this.Effects_OnApply_Messages_Group = status.Effects.OnApply.Messages.Group;
            this.Effects_OnApply_Messages_Say = status.Effects.OnApply.Messages.Say;
            this.Effects_OnApply_Messages_Shout = status.Effects.OnApply.Messages.Shout;

            this.Effects_OnApply_Heal_Simple_Min = status.Effects.OnApply.Heal.Simple.Min;
            this.Effects_OnApply_Heal_Simple_Max = status.Effects.OnApply.Heal.Simple.Max;
            this.Effects_OnApply_Heal_Simple_Value = status.Effects.OnApply.Heal.Simple.Value;
            this.Effects_OnApply_Heal_Formula = status.Effects.OnApply.Heal.Formula;

            this.Effects_OnApply_Damage_Flags = status.Effects.OnApply.Damage.Flags;
            this.Effects_OnApply_Damage_Simple_Min = status.Effects.OnApply.Damage.Simple.Min;
            this.Effects_OnApply_Damage_Simple_Max = status.Effects.OnApply.Damage.Simple.Max;
            this.Effects_OnApply_Damage_Simple_Value = status.Effects.OnApply.Damage.Simple.Value;
            this.Effects_OnApply_Damage_Formula = status.Effects.OnApply.Damage.Formula;
            this.Effects_OnApply_Damage_Type = status.Effects.OnApply.Damage.Type;

            this.Effects_OnApply_StatModifiers_Str = status.Effects.OnApply.StatModifiers.Str;
            this.Effects_OnApply_StatModifiers_Int = status.Effects.OnApply.StatModifiers.Int;
            this.Effects_OnApply_StatModifiers_Wis = status.Effects.OnApply.StatModifiers.Wis;
            this.Effects_OnApply_StatModifiers_Con = status.Effects.OnApply.StatModifiers.Con;
            this.Effects_OnApply_StatModifiers_Dex = status.Effects.OnApply.StatModifiers.Dex;
            this.Effects_OnApply_StatModifiers_Hp = status.Effects.OnApply.StatModifiers.Hp;
            this.Effects_OnApply_StatModifiers_Mp = status.Effects.OnApply.StatModifiers.Mp;
            this.Effects_OnApply_StatModifiers_Hit = status.Effects.OnApply.StatModifiers.Hit;
            this.Effects_OnApply_StatModifiers_Dmg = status.Effects.OnApply.StatModifiers.Dmg;
            this.Effects_OnApply_StatModifiers_Ac = status.Effects.OnApply.StatModifiers.Ac;
            this.Effects_OnApply_StatModifiers_Regen = status.Effects.OnApply.StatModifiers.Regen;
            this.Effects_OnApply_StatModifiers_Mr = status.Effects.OnApply.StatModifiers.Mr;
            this.Effects_OnApply_StatModifiers_OffensiveElement = status.Effects.OnApply.StatModifiers.OffensiveElement;
            this.Effects_OnApply_StatModifiers_DefensiveElement = status.Effects.OnApply.StatModifiers.DefensiveElement;
            this.Effects_OnApply_StatModifiers_DmgModifier = status.Effects.OnApply.StatModifiers.DamageModifier;
            this.Effects_OnApply_StatModifiers_HealModifier = status.Effects.OnApply.StatModifiers.HealModifier;
            this.Effects_OnApply_StatModifiers_DmgType = status.Effects.OnApply.StatModifiers.DamageType;
            this.Effects_OnApply_StatModifiers_ReflectChance = status.Effects.OnApply.StatModifiers.ReflectChance;
            this.Effects_OnApply_StatModifiers_ReflectIntensity = status.Effects.OnApply.StatModifiers.ReflectIntensity;

            this.Effects_OnApply_Conditions_Set = status.Effects.OnApply.Conditions.Set;
            this.Effects_OnApply_Conditions_Unset = status.Effects.OnApply.Conditions.Unset;
            #endregion

            #region OnTick
            this.Effects_OnTick_Animations_Target_Id = status.Effects.OnTick.Animations.Target.Id;
            this.Effects_OnTick_Animations_Target_Speed = status.Effects.OnTick.Animations.Target.Speed;
            this.Effects_OnTick_Animations_SpellEffect_Id = status.Effects.OnTick.Animations.SpellEffect.Id;
            this.Effects_OnTick_Animations_SpellEffect_Speed = status.Effects.OnTick.Animations.SpellEffect.Speed;

            this.Effects_OnTick_Sound_Id = status.Effects.OnTick.Sound.Id;

            this.Effects_OnTick_Messages_Target = status.Effects.OnTick.Messages.Target;
            this.Effects_OnTick_Messages_Source = status.Effects.OnTick.Messages.Source;
            this.Effects_OnTick_Messages_Group = status.Effects.OnTick.Messages.Group;
            this.Effects_OnTick_Messages_Say = status.Effects.OnTick.Messages.Say;
            this.Effects_OnTick_Messages_Shout = status.Effects.OnTick.Messages.Shout;

            this.Effects_OnTick_Heal_Simple_Min = status.Effects.OnTick.Heal.Simple.Min;
            this.Effects_OnTick_Heal_Simple_Max = status.Effects.OnTick.Heal.Simple.Max;
            this.Effects_OnTick_Heal_Simple_Value = status.Effects.OnTick.Heal.Simple.Value;
            this.Effects_OnTick_Heal_Formula = status.Effects.OnTick.Heal.Formula;

            this.Effects_OnTick_Damage_Flags = status.Effects.OnTick.Damage.Flags;
            this.Effects_OnTick_Damage_Simple_Min = status.Effects.OnTick.Damage.Simple.Min;
            this.Effects_OnTick_Damage_Simple_Max = status.Effects.OnTick.Damage.Simple.Max;
            this.Effects_OnTick_Damage_Simple_Value = status.Effects.OnTick.Damage.Simple.Value;
            this.Effects_OnTick_Damage_Formula = status.Effects.OnTick.Damage.Formula;
            this.Effects_OnTick_Damage_Type = status.Effects.OnTick.Damage.Type;

            this.Effects_OnTick_StatModifiers_Str = status.Effects.OnTick.StatModifiers.Str;
            this.Effects_OnTick_StatModifiers_Int = status.Effects.OnTick.StatModifiers.Int;
            this.Effects_OnTick_StatModifiers_Wis = status.Effects.OnTick.StatModifiers.Wis;
            this.Effects_OnTick_StatModifiers_Con = status.Effects.OnTick.StatModifiers.Con;
            this.Effects_OnTick_StatModifiers_Dex = status.Effects.OnTick.StatModifiers.Dex;
            this.Effects_OnTick_StatModifiers_Hp = status.Effects.OnTick.StatModifiers.Hp;
            this.Effects_OnTick_StatModifiers_Mp = status.Effects.OnTick.StatModifiers.Mp;
            this.Effects_OnTick_StatModifiers_Hit = status.Effects.OnTick.StatModifiers.Hit;
            this.Effects_OnTick_StatModifiers_Dmg = status.Effects.OnTick.StatModifiers.Dmg;
            this.Effects_OnTick_StatModifiers_Ac = status.Effects.OnTick.StatModifiers.Ac;
            this.Effects_OnTick_StatModifiers_Regen = status.Effects.OnTick.StatModifiers.Regen;
            this.Effects_OnTick_StatModifiers_Mr = status.Effects.OnTick.StatModifiers.Mr;
            this.Effects_OnTick_StatModifiers_OffensiveElement = status.Effects.OnTick.StatModifiers.OffensiveElement;
            this.Effects_OnTick_StatModifiers_DefensiveElement = status.Effects.OnTick.StatModifiers.DefensiveElement;
            this.Effects_OnTick_StatModifiers_DmgModifier = status.Effects.OnTick.StatModifiers.DamageModifier;
            this.Effects_OnTick_StatModifiers_HealModifier = status.Effects.OnTick.StatModifiers.HealModifier;
            this.Effects_OnTick_StatModifiers_DmgType = status.Effects.OnTick.StatModifiers.DamageType;
            this.Effects_OnTick_StatModifiers_ReflectChance = status.Effects.OnTick.StatModifiers.ReflectChance;
            this.Effects_OnTick_StatModifiers_ReflectIntensity = status.Effects.OnTick.StatModifiers.ReflectIntensity;

            this.Effects_OnTick_Conditions_Set = status.Effects.OnTick.Conditions.Set;
            this.Effects_OnTick_Conditions_Unset = status.Effects.OnTick.Conditions.Unset;
            #endregion

            #region OnRemove
            this.Effects_OnRemove_Animations_Target_Id = status.Effects.OnRemove.Animations.Target.Id;
            this.Effects_OnRemove_Animations_Target_Speed = status.Effects.OnRemove.Animations.Target.Speed;
            this.Effects_OnRemove_Animations_SpellEffect_Id = status.Effects.OnRemove.Animations.SpellEffect.Id;
            this.Effects_OnRemove_Animations_SpellEffect_Speed = status.Effects.OnRemove.Animations.SpellEffect.Speed;

            this.Effects_OnRemove_Sound_Id = status.Effects.OnRemove.Sound.Id;

            this.Effects_OnRemove_Messages_Target = status.Effects.OnRemove.Messages.Target;
            this.Effects_OnRemove_Messages_Source = status.Effects.OnRemove.Messages.Source;
            this.Effects_OnRemove_Messages_Group = status.Effects.OnRemove.Messages.Group;
            this.Effects_OnRemove_Messages_Say = status.Effects.OnRemove.Messages.Say;
            this.Effects_OnRemove_Messages_Shout = status.Effects.OnRemove.Messages.Shout;

            this.Effects_OnRemove_Heal_Simple_Min = status.Effects.OnRemove.Heal.Simple.Min;
            this.Effects_OnRemove_Heal_Simple_Max = status.Effects.OnRemove.Heal.Simple.Max;
            this.Effects_OnRemove_Heal_Simple_Value = status.Effects.OnRemove.Heal.Simple.Value;
            this.Effects_OnRemove_Heal_Formula = status.Effects.OnRemove.Heal.Formula;

            this.Effects_OnRemove_Damage_Flags = status.Effects.OnRemove.Damage.Flags;
            this.Effects_OnRemove_Damage_Simple_Min = status.Effects.OnRemove.Damage.Simple.Min;
            this.Effects_OnRemove_Damage_Simple_Max = status.Effects.OnRemove.Damage.Simple.Max;
            this.Effects_OnRemove_Damage_Simple_Value = status.Effects.OnRemove.Damage.Simple.Value;
            this.Effects_OnRemove_Damage_Formula = status.Effects.OnRemove.Damage.Formula;
            this.Effects_OnRemove_Damage_Type = status.Effects.OnRemove.Damage.Type;

            this.Effects_OnRemove_StatModifiers_Str = status.Effects.OnRemove.StatModifiers.Str;
            this.Effects_OnRemove_StatModifiers_Int = status.Effects.OnRemove.StatModifiers.Int;
            this.Effects_OnRemove_StatModifiers_Wis = status.Effects.OnRemove.StatModifiers.Wis;
            this.Effects_OnRemove_StatModifiers_Con = status.Effects.OnRemove.StatModifiers.Con;
            this.Effects_OnRemove_StatModifiers_Dex = status.Effects.OnRemove.StatModifiers.Dex;
            this.Effects_OnRemove_StatModifiers_Hp = status.Effects.OnRemove.StatModifiers.Hp;
            this.Effects_OnRemove_StatModifiers_Mp = status.Effects.OnRemove.StatModifiers.Mp;
            this.Effects_OnRemove_StatModifiers_Hit = status.Effects.OnRemove.StatModifiers.Hit;
            this.Effects_OnRemove_StatModifiers_Dmg = status.Effects.OnRemove.StatModifiers.Dmg;
            this.Effects_OnRemove_StatModifiers_Ac = status.Effects.OnRemove.StatModifiers.Ac;
            this.Effects_OnRemove_StatModifiers_Regen = status.Effects.OnRemove.StatModifiers.Regen;
            this.Effects_OnRemove_StatModifiers_Mr = status.Effects.OnRemove.StatModifiers.Mr;
            this.Effects_OnRemove_StatModifiers_OffensiveElement = status.Effects.OnRemove.StatModifiers.OffensiveElement;
            this.Effects_OnRemove_StatModifiers_DefensiveElement = status.Effects.OnRemove.StatModifiers.DefensiveElement;
            this.Effects_OnRemove_StatModifiers_DmgModifier = status.Effects.OnRemove.StatModifiers.DamageModifier;
            this.Effects_OnRemove_StatModifiers_HealModifier = status.Effects.OnRemove.StatModifiers.HealModifier;
            this.Effects_OnRemove_StatModifiers_DmgType = status.Effects.OnRemove.StatModifiers.DamageType;
            this.Effects_OnRemove_StatModifiers_ReflectChance = status.Effects.OnRemove.StatModifiers.ReflectChance;
            this.Effects_OnRemove_StatModifiers_ReflectIntensity = status.Effects.OnRemove.StatModifiers.ReflectIntensity;

            this.Effects_OnRemove_Conditions_Set = status.Effects.OnRemove.Conditions.Set;
            this.Effects_OnRemove_Conditions_Unset = status.Effects.OnRemove.Conditions.Unset;
            #endregion

            this.CastRestriction = status.CastRestriction;
            this.ProhibitedMessage = status.ProhibitedMessage;
            this.Script = status.Script;
            this.Duration = status.Duration;
            this.Tick = status.Tick;
            this.Icon = status.Icon;
            this.Name = status.Name;
        }


        public Status GetDisplayStatus()
        {
            var newStatus = new Status();
            newStatus.Category = this.Category;
            newStatus.CastRestriction.Receive = this.CastRestriction_Receive;
            newStatus.CastRestriction.Use = this.CastRestriction_Use;

            #region Effects_OnApply
            newStatus.Effects.OnApply.Animations.Target.Id = this.Effects_OnApply_Animations_Target_Id;
            newStatus.Effects.OnApply.Animations.Target.Speed = this.Effects_OnApply_Animations_Target_Speed;
            newStatus.Effects.OnApply.Animations.SpellEffect.Id = this.Effects_OnApply_Animations_SpellEffect_Id;
            newStatus.Effects.OnApply.Animations.SpellEffect.Speed = this.Effects_OnApply_Animations_SpellEffect_Speed;

            newStatus.Effects.OnApply.Sound.Id = this.Effects_OnApply_Sound_Id;

            newStatus.Effects.OnApply.Messages.Target = this.Effects_OnApply_Messages_Target;
            newStatus.Effects.OnApply.Messages.Source = this.Effects_OnApply_Messages_Source;
            newStatus.Effects.OnApply.Messages.Group = this.Effects_OnApply_Messages_Group;
            newStatus.Effects.OnApply.Messages.Say = this.Effects_OnApply_Messages_Say;
            newStatus.Effects.OnApply.Messages.Shout = this.Effects_OnApply_Messages_Shout;

            newStatus.Effects.OnApply.Heal.Simple.Min = this.Effects_OnApply_Heal_Simple_Min;
            newStatus.Effects.OnApply.Heal.Simple.Max = this.Effects_OnApply_Heal_Simple_Max;
            newStatus.Effects.OnApply.Heal.Simple.Value = this.Effects_OnApply_Heal_Simple_Value;
            newStatus.Effects.OnApply.Heal.Formula = this.Effects_OnApply_Heal_Formula;

            newStatus.Effects.OnApply.Damage.Flags = this.Effects_OnApply_Damage_Flags;
            newStatus.Effects.OnApply.Damage.Simple.Min = this.Effects_OnApply_Damage_Simple_Min;
            newStatus.Effects.OnApply.Damage.Simple.Max = this.Effects_OnApply_Damage_Simple_Max;
            newStatus.Effects.OnApply.Damage.Simple.Value = this.Effects_OnApply_Damage_Simple_Value;
            newStatus.Effects.OnApply.Damage.Formula = this.Effects_OnApply_Damage_Formula;
            newStatus.Effects.OnApply.Damage.Type = this.Effects_OnApply_Damage_Type;

            newStatus.Effects.OnApply.StatModifiers.Str = this.Effects_OnApply_StatModifiers_Str;
            newStatus.Effects.OnApply.StatModifiers.Int = this.Effects_OnApply_StatModifiers_Int;
            newStatus.Effects.OnApply.StatModifiers.Wis = this.Effects_OnApply_StatModifiers_Wis;
            newStatus.Effects.OnApply.StatModifiers.Con = this.Effects_OnApply_StatModifiers_Con;
            newStatus.Effects.OnApply.StatModifiers.Dex = this.Effects_OnApply_StatModifiers_Dex;
            newStatus.Effects.OnApply.StatModifiers.Hp = this.Effects_OnApply_StatModifiers_Hp;
            newStatus.Effects.OnApply.StatModifiers.Mp = this.Effects_OnApply_StatModifiers_Mp;
            newStatus.Effects.OnApply.StatModifiers.Hit = this.Effects_OnApply_StatModifiers_Hit;
            newStatus.Effects.OnApply.StatModifiers.Dmg = this.Effects_OnApply_StatModifiers_Dmg;
            newStatus.Effects.OnApply.StatModifiers.Ac = this.Effects_OnApply_StatModifiers_Ac;
            newStatus.Effects.OnApply.StatModifiers.Regen = this.Effects_OnApply_StatModifiers_Regen;
            newStatus.Effects.OnApply.StatModifiers.Mr = this.Effects_OnApply_StatModifiers_Mr;
            newStatus.Effects.OnApply.StatModifiers.OffensiveElement = this.Effects_OnApply_StatModifiers_OffensiveElement;
            newStatus.Effects.OnApply.StatModifiers.DefensiveElement = this.Effects_OnApply_StatModifiers_DefensiveElement;
            newStatus.Effects.OnApply.StatModifiers.DamageModifier = this.Effects_OnApply_StatModifiers_DmgModifier;
            newStatus.Effects.OnApply.StatModifiers.HealModifier = this.Effects_OnApply_StatModifiers_HealModifier;
            newStatus.Effects.OnApply.StatModifiers.DamageType = this.Effects_OnApply_StatModifiers_DmgType;
            newStatus.Effects.OnApply.StatModifiers.ReflectChance = this.Effects_OnApply_StatModifiers_ReflectChance;
            newStatus.Effects.OnApply.StatModifiers.ReflectIntensity = this.Effects_OnApply_StatModifiers_ReflectIntensity;

            newStatus.Effects.OnApply.Conditions.Set = this.Effects_OnApply_Conditions_Set;
            newStatus.Effects.OnApply.Conditions.Unset = this.Effects_OnApply_Conditions_Unset;
            #endregion

            #region Effects_OnTick
            newStatus.Effects.OnTick.Animations.Target.Id = this.Effects_OnTick_Animations_Target_Id;
            newStatus.Effects.OnTick.Animations.Target.Speed = this.Effects_OnTick_Animations_Target_Speed;
            newStatus.Effects.OnTick.Animations.SpellEffect.Id = this.Effects_OnTick_Animations_SpellEffect_Id;
            newStatus.Effects.OnTick.Animations.SpellEffect.Speed = this.Effects_OnTick_Animations_SpellEffect_Speed;

            newStatus.Effects.OnTick.Sound.Id = this.Effects_OnTick_Sound_Id;

            newStatus.Effects.OnTick.Messages.Target = this.Effects_OnTick_Messages_Target;
            newStatus.Effects.OnTick.Messages.Source = this.Effects_OnTick_Messages_Source;
            newStatus.Effects.OnTick.Messages.Group = this.Effects_OnTick_Messages_Group;
            newStatus.Effects.OnTick.Messages.Say = this.Effects_OnTick_Messages_Say;
            newStatus.Effects.OnTick.Messages.Shout = this.Effects_OnTick_Messages_Shout;

            newStatus.Effects.OnTick.Heal.Simple.Min = this.Effects_OnTick_Heal_Simple_Min;
            newStatus.Effects.OnTick.Heal.Simple.Max = this.Effects_OnTick_Heal_Simple_Max;
            newStatus.Effects.OnTick.Heal.Simple.Value = this.Effects_OnTick_Heal_Simple_Value;
            newStatus.Effects.OnTick.Heal.Formula = this.Effects_OnTick_Heal_Formula;

            newStatus.Effects.OnTick.Damage.Flags = this.Effects_OnTick_Damage_Flags;
            newStatus.Effects.OnTick.Damage.Simple.Min = this.Effects_OnTick_Damage_Simple_Min;
            newStatus.Effects.OnTick.Damage.Simple.Max = this.Effects_OnTick_Damage_Simple_Max;
            newStatus.Effects.OnTick.Damage.Simple.Value = this.Effects_OnTick_Damage_Simple_Value;
            newStatus.Effects.OnTick.Damage.Formula = this.Effects_OnTick_Damage_Formula;
            newStatus.Effects.OnTick.Damage.Type = this.Effects_OnTick_Damage_Type;

            newStatus.Effects.OnTick.StatModifiers.Str = this.Effects_OnTick_StatModifiers_Str;
            newStatus.Effects.OnTick.StatModifiers.Int = this.Effects_OnTick_StatModifiers_Int;
            newStatus.Effects.OnTick.StatModifiers.Wis = this.Effects_OnTick_StatModifiers_Wis;
            newStatus.Effects.OnTick.StatModifiers.Con = this.Effects_OnTick_StatModifiers_Con;
            newStatus.Effects.OnTick.StatModifiers.Dex = this.Effects_OnTick_StatModifiers_Dex;
            newStatus.Effects.OnTick.StatModifiers.Hp = this.Effects_OnTick_StatModifiers_Hp;
            newStatus.Effects.OnTick.StatModifiers.Mp = this.Effects_OnTick_StatModifiers_Mp;
            newStatus.Effects.OnTick.StatModifiers.Hit = this.Effects_OnTick_StatModifiers_Hit;
            newStatus.Effects.OnTick.StatModifiers.Dmg = this.Effects_OnTick_StatModifiers_Dmg;
            newStatus.Effects.OnTick.StatModifiers.Ac = this.Effects_OnTick_StatModifiers_Ac;
            newStatus.Effects.OnTick.StatModifiers.Regen = this.Effects_OnTick_StatModifiers_Regen;
            newStatus.Effects.OnTick.StatModifiers.Mr = this.Effects_OnTick_StatModifiers_Mr;
            newStatus.Effects.OnTick.StatModifiers.OffensiveElement = this.Effects_OnTick_StatModifiers_OffensiveElement;
            newStatus.Effects.OnTick.StatModifiers.DefensiveElement = this.Effects_OnTick_StatModifiers_DefensiveElement;
            newStatus.Effects.OnTick.StatModifiers.DamageModifier = this.Effects_OnTick_StatModifiers_DmgModifier;
            newStatus.Effects.OnTick.StatModifiers.HealModifier = this.Effects_OnTick_StatModifiers_HealModifier;
            newStatus.Effects.OnTick.StatModifiers.DamageType = this.Effects_OnTick_StatModifiers_DmgType;
            newStatus.Effects.OnTick.StatModifiers.ReflectChance = this.Effects_OnTick_StatModifiers_ReflectChance;
            newStatus.Effects.OnTick.StatModifiers.ReflectIntensity = this.Effects_OnTick_StatModifiers_ReflectIntensity;

            newStatus.Effects.OnTick.Conditions.Set = this.Effects_OnTick_Conditions_Set;
            newStatus.Effects.OnTick.Conditions.Unset = this.Effects_OnTick_Conditions_Unset;
            #endregion

            #region Effects_OnRemove
            newStatus.Effects.OnRemove.Animations.Target.Id = this.Effects_OnRemove_Animations_Target_Id;
            newStatus.Effects.OnRemove.Animations.Target.Speed = this.Effects_OnRemove_Animations_Target_Speed;
            newStatus.Effects.OnRemove.Animations.SpellEffect.Id = this.Effects_OnRemove_Animations_SpellEffect_Id;
            newStatus.Effects.OnRemove.Animations.SpellEffect.Speed = this.Effects_OnRemove_Animations_SpellEffect_Speed;

            newStatus.Effects.OnRemove.Sound.Id = this.Effects_OnRemove_Sound_Id;

            newStatus.Effects.OnRemove.Messages.Target = this.Effects_OnRemove_Messages_Target;
            newStatus.Effects.OnRemove.Messages.Source = this.Effects_OnRemove_Messages_Source;
            newStatus.Effects.OnRemove.Messages.Group = this.Effects_OnRemove_Messages_Group;
            newStatus.Effects.OnRemove.Messages.Say = this.Effects_OnRemove_Messages_Say;
            newStatus.Effects.OnRemove.Messages.Shout = this.Effects_OnRemove_Messages_Shout;

            newStatus.Effects.OnRemove.Heal.Simple.Min = this.Effects_OnRemove_Heal_Simple_Min;
            newStatus.Effects.OnRemove.Heal.Simple.Max = this.Effects_OnRemove_Heal_Simple_Max;
            newStatus.Effects.OnRemove.Heal.Simple.Value = this.Effects_OnRemove_Heal_Simple_Value;
            newStatus.Effects.OnRemove.Heal.Formula = this.Effects_OnRemove_Heal_Formula;

            newStatus.Effects.OnRemove.Damage.Flags = this.Effects_OnRemove_Damage_Flags;
            newStatus.Effects.OnRemove.Damage.Simple.Min = this.Effects_OnRemove_Damage_Simple_Min;
            newStatus.Effects.OnRemove.Damage.Simple.Max = this.Effects_OnRemove_Damage_Simple_Max;
            newStatus.Effects.OnRemove.Damage.Simple.Value = this.Effects_OnRemove_Damage_Simple_Value;
            newStatus.Effects.OnRemove.Damage.Formula = this.Effects_OnRemove_Damage_Formula;
            newStatus.Effects.OnRemove.Damage.Type = this.Effects_OnRemove_Damage_Type;

            newStatus.Effects.OnRemove.StatModifiers.Str = this.Effects_OnRemove_StatModifiers_Str;
            newStatus.Effects.OnRemove.StatModifiers.Int = this.Effects_OnRemove_StatModifiers_Int;
            newStatus.Effects.OnRemove.StatModifiers.Wis = this.Effects_OnRemove_StatModifiers_Wis;
            newStatus.Effects.OnRemove.StatModifiers.Con = this.Effects_OnRemove_StatModifiers_Con;
            newStatus.Effects.OnRemove.StatModifiers.Dex = this.Effects_OnRemove_StatModifiers_Dex;
            newStatus.Effects.OnRemove.StatModifiers.Hp = this.Effects_OnRemove_StatModifiers_Hp;
            newStatus.Effects.OnRemove.StatModifiers.Mp = this.Effects_OnRemove_StatModifiers_Mp;
            newStatus.Effects.OnRemove.StatModifiers.Hit = this.Effects_OnRemove_StatModifiers_Hit;
            newStatus.Effects.OnRemove.StatModifiers.Dmg = this.Effects_OnRemove_StatModifiers_Dmg;
            newStatus.Effects.OnRemove.StatModifiers.Ac = this.Effects_OnRemove_StatModifiers_Ac;
            newStatus.Effects.OnRemove.StatModifiers.Regen = this.Effects_OnRemove_StatModifiers_Regen;
            newStatus.Effects.OnRemove.StatModifiers.Mr = this.Effects_OnRemove_StatModifiers_Mr;
            newStatus.Effects.OnRemove.StatModifiers.OffensiveElement = this.Effects_OnRemove_StatModifiers_OffensiveElement;
            newStatus.Effects.OnRemove.StatModifiers.DefensiveElement = this.Effects_OnRemove_StatModifiers_DefensiveElement;
            newStatus.Effects.OnRemove.StatModifiers.DamageModifier = this.Effects_OnRemove_StatModifiers_DmgModifier;
            newStatus.Effects.OnRemove.StatModifiers.HealModifier = this.Effects_OnRemove_StatModifiers_HealModifier;
            newStatus.Effects.OnRemove.StatModifiers.DamageType = this.Effects_OnRemove_StatModifiers_DmgType;
            newStatus.Effects.OnRemove.StatModifiers.ReflectChance = this.Effects_OnRemove_StatModifiers_ReflectChance;
            newStatus.Effects.OnRemove.StatModifiers.ReflectIntensity = this.Effects_OnRemove_StatModifiers_ReflectIntensity;

            newStatus.Effects.OnRemove.Conditions.Set = this.Effects_OnRemove_Conditions_Set;
            newStatus.Effects.OnRemove.Conditions.Unset = this.Effects_OnRemove_Conditions_Unset;
            #endregion

            newStatus.ProhibitedMessage = this.ProhibitedMessage;
            newStatus.Script = this.Script;
            newStatus.Duration = this.Duration;
            newStatus.Tick = this.Tick;
            newStatus.Icon = this.Icon;
            newStatus.Name = this.Name;

            return newStatus;
        }


        #region Properties
        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }

        public Effects Effects
        {
            get { return _effects; }
            set
            {
                _effects = value;
                OnPropertyChanged();
            }
        }

        #region Effects_SubCategories

        #region OnApply
        public ushort Effects_OnApply_Animations_Target_Id { get { return _effects_OnApply_Animations_Target_Id; } set { _effects_OnApply_Animations_Target_Id = value; OnPropertyChanged(); } }
        public short Effects_OnApply_Animations_Target_Speed { get { return _effects_OnApply_Animations_Target_Speed; } set { _effects_OnApply_Animations_Target_Speed = value; OnPropertyChanged(); } }
        public ushort Effects_OnApply_Animations_SpellEffect_Id { get { return _effects_OnApply_Animations_SpellEffect_Id; } set { _effects_OnApply_Animations_SpellEffect_Id = value; OnPropertyChanged(); } }
        public short Effects_OnApply_Animations_SpellEffect_Speed { get { return _effects_OnApply_Animations_SpellEffect_Speed; } set { _effects_OnApply_Animations_SpellEffect_Speed = value; OnPropertyChanged(); } }

        public byte Effects_OnApply_Sound_Id { get { return _effects_OnApply_Sound_Id; } set { _effects_OnApply_Sound_Id = value; OnPropertyChanged(); } }

        public string Effects_OnApply_Messages_Target { get { return _effects_OnApply_Messages_Target; } set { _effects_OnApply_Messages_Target = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Messages_Source { get { return _effects_OnApply_Messages_Source; } set { _effects_OnApply_Messages_Source = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Messages_Group { get { return _effects_OnApply_Messages_Group; } set { _effects_OnApply_Messages_Group = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Messages_Say { get { return _effects_OnApply_Messages_Say; } set { _effects_OnApply_Messages_Say = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Messages_Shout { get { return _effects_OnApply_Messages_Shout; } set { _effects_OnApply_Messages_Shout = value; OnPropertyChanged(); } }

        public string Effects_OnApply_Heal_Simple_Min { get { return _effects_OnApply_Heal_Simple_Min; } set { _effects_OnApply_Heal_Simple_Min = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Heal_Simple_Max { get { return _effects_OnApply_Heal_Simple_Max; } set { _effects_OnApply_Heal_Simple_Max = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Heal_Simple_Value { get { return _effects_OnApply_Heal_Simple_Value; } set { _effects_OnApply_Heal_Simple_Value = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Heal_Formula { get { return _effects_OnApply_Heal_Formula; } set { _effects_OnApply_Heal_Formula = value; OnPropertyChanged(); } }
        public DamageFlags Effects_OnApply_Damage_Flags { get { return _effects_OnApply_Damage_Flags; } set { _effects_OnApply_Damage_Flags = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Damage_Simple_Min { get { return _effects_OnApply_Damage_Simple_Min; } set { _effects_OnApply_Damage_Simple_Min = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Damage_Simple_Max { get { return _effects_OnApply_Damage_Simple_Max; } set { _effects_OnApply_Damage_Simple_Max = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Damage_Simple_Value { get { return _effects_OnApply_Damage_Simple_Value; } set { _effects_OnApply_Damage_Simple_Value = value; OnPropertyChanged(); } }
        public string Effects_OnApply_Damage_Formula { get { return _effects_OnApply_Damage_Formula; } set { _effects_OnApply_Damage_Formula = value; OnPropertyChanged(); } }
        public DamageType Effects_OnApply_Damage_Type { get { return _effects_OnApply_Damage_Type; } set { _effects_OnApply_Damage_Type = value; OnPropertyChanged(); } }

        public sbyte Effects_OnApply_StatModifiers_Str { get { return _effects_OnApply_StatModifiers_Str; } set { _effects_OnApply_StatModifiers_Str = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Int { get { return _effects_OnApply_StatModifiers_Int; } set { _effects_OnApply_StatModifiers_Int = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Wis { get { return _effects_OnApply_StatModifiers_Wis; } set { _effects_OnApply_StatModifiers_Wis = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Con { get { return _effects_OnApply_StatModifiers_Con; } set { _effects_OnApply_StatModifiers_Con = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Dex { get { return _effects_OnApply_StatModifiers_Dex; } set { _effects_OnApply_StatModifiers_Dex = value; OnPropertyChanged(); } }
        public int Effects_OnApply_StatModifiers_Hp { get { return _effects_OnApply_StatModifiers_Hp; } set { _effects_OnApply_StatModifiers_Hp = value; OnPropertyChanged(); } }
        public int Effects_OnApply_StatModifiers_Mp { get { return _effects_OnApply_StatModifiers_Mp; } set { _effects_OnApply_StatModifiers_Mp = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Hit { get { return _effects_OnApply_StatModifiers_Hit; } set { _effects_OnApply_StatModifiers_Hit = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Dmg { get { return _effects_OnApply_StatModifiers_Dmg; } set { _effects_OnApply_StatModifiers_Dmg = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Ac { get { return _effects_OnApply_StatModifiers_Ac; } set { _effects_OnApply_StatModifiers_Ac = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Regen { get { return _effects_OnApply_StatModifiers_Regen; } set { _effects_OnApply_StatModifiers_Regen = value; OnPropertyChanged(); } }
        public sbyte Effects_OnApply_StatModifiers_Mr { get { return _effects_OnApply_StatModifiers_Mr; } set { _effects_OnApply_StatModifiers_Mr = value; OnPropertyChanged(); } }
        public Element Effects_OnApply_StatModifiers_OffensiveElement { get { return _effects_OnApply_StatModifiers_OffensiveElement; } set { _effects_OnApply_StatModifiers_OffensiveElement = value; OnPropertyChanged(); } }
        public Element Effects_OnApply_StatModifiers_DefensiveElement { get { return _effects_OnApply_StatModifiers_DefensiveElement; } set { _effects_OnApply_StatModifiers_DefensiveElement = value; OnPropertyChanged(); } }
        public float Effects_OnApply_StatModifiers_DmgModifier { get { return _effects_OnApply_StatModifiers_DmgModifier; } set { _effects_OnApply_StatModifiers_DmgModifier = value; OnPropertyChanged(); } }
        public float Effects_OnApply_StatModifiers_HealModifier { get { return _effects_OnApply_StatModifiers_HealModifier; } set { _effects_OnApply_StatModifiers_HealModifier = value; OnPropertyChanged(); } }
        public DamageType Effects_OnApply_StatModifiers_DmgType { get { return _effects_OnApply_StatModifiers_DmgType; } set { _effects_OnApply_StatModifiers_DmgType = value; OnPropertyChanged(); } }
        public float Effects_OnApply_StatModifiers_ReflectChance { get { return _effects_OnApply_StatModifiers_ReflectChance; } set { _effects_OnApply_StatModifiers_ReflectChance = value; OnPropertyChanged(); } }
        public float Effects_OnApply_StatModifiers_ReflectIntensity { get { return _effects_OnApply_StatModifiers_ReflectIntensity; } set { _effects_OnApply_StatModifiers_ReflectIntensity = value; OnPropertyChanged(); } }

        public CreatureCondition Effects_OnApply_Conditions_Set { get { return _effects_OnApply_Conditions_Set; } set { _effects_OnApply_Conditions_Set = value; OnPropertyChanged(); } }
        public List<string> Effects_OnApply_Conditions_Set_List { get { return _effects_OnApply_Conditions_Set_List; } set { _effects_OnApply_Conditions_Set_List = value; OnPropertyChanged(); } }
        public CreatureCondition Effects_OnApply_Conditions_Unset { get { return _effects_OnApply_Conditions_Unset; } set { _effects_OnApply_Conditions_Unset = value; OnPropertyChanged(); } }
        public List<string> Effects_OnApply_Conditions_Unset_List { get { return _effects_OnApply_Conditions_Unset_List; } set { _effects_OnApply_Conditions_Unset_List = value; OnPropertyChanged(); } }
        #endregion

        #region OnTick
        public ushort Effects_OnTick_Animations_Target_Id { get { return _effects_OnTick_Animations_Target_Id; } set { _effects_OnTick_Animations_Target_Id = value; OnPropertyChanged(); } }
        public short Effects_OnTick_Animations_Target_Speed { get { return _effects_OnTick_Animations_Target_Speed; } set { _effects_OnTick_Animations_Target_Speed = value; OnPropertyChanged(); } }
        public ushort Effects_OnTick_Animations_SpellEffect_Id { get { return _effects_OnTick_Animations_SpellEffect_Id; } set { _effects_OnTick_Animations_SpellEffect_Id = value; OnPropertyChanged(); } }
        public short Effects_OnTick_Animations_SpellEffect_Speed { get { return _effects_OnTick_Animations_SpellEffect_Speed; } set { _effects_OnTick_Animations_SpellEffect_Speed = value; OnPropertyChanged(); } }

        public byte Effects_OnTick_Sound_Id { get { return _effects_OnTick_Sound_Id; } set { _effects_OnTick_Sound_Id = value; OnPropertyChanged(); } }

        public string Effects_OnTick_Messages_Target { get { return _effects_OnTick_Messages_Target; } set { _effects_OnTick_Messages_Target = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Messages_Source { get { return _effects_OnTick_Messages_Source; } set { _effects_OnTick_Messages_Source = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Messages_Group { get { return _effects_OnTick_Messages_Group; } set { _effects_OnTick_Messages_Group = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Messages_Say { get { return _effects_OnTick_Messages_Say; } set { _effects_OnTick_Messages_Say = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Messages_Shout { get { return _effects_OnTick_Messages_Shout; } set { _effects_OnTick_Messages_Shout = value; OnPropertyChanged(); } }

        public string Effects_OnTick_Heal_Simple_Min { get { return _effects_OnTick_Heal_Simple_Min; } set { _effects_OnTick_Heal_Simple_Min = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Heal_Simple_Max { get { return _effects_OnTick_Heal_Simple_Max; } set { _effects_OnTick_Heal_Simple_Max = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Heal_Simple_Value { get { return _effects_OnTick_Heal_Simple_Value; } set { _effects_OnTick_Heal_Simple_Value = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Heal_Formula { get { return _effects_OnTick_Heal_Formula; } set { _effects_OnTick_Heal_Formula = value; OnPropertyChanged(); } }

        public DamageFlags Effects_OnTick_Damage_Flags { get { return _effects_OnTick_Damage_Flags; } set { _effects_OnTick_Damage_Flags = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Damage_Simple_Min { get { return _effects_OnTick_Damage_Simple_Min; } set { _effects_OnTick_Damage_Simple_Min = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Damage_Simple_Max { get { return _effects_OnTick_Damage_Simple_Max; } set { _effects_OnTick_Damage_Simple_Max = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Damage_Simple_Value { get { return _effects_OnTick_Damage_Simple_Value; } set { _effects_OnTick_Damage_Simple_Value = value; OnPropertyChanged(); } }
        public string Effects_OnTick_Damage_Formula { get { return _effects_OnTick_Damage_Formula; } set { _effects_OnTick_Damage_Formula = value; OnPropertyChanged(); } }
        public DamageType Effects_OnTick_Damage_Type { get { return _effects_OnTick_Damage_Type; } set { _effects_OnTick_Damage_Type = value; OnPropertyChanged(); } }

        public sbyte Effects_OnTick_StatModifiers_Str { get { return _effects_OnTick_StatModifiers_Str; } set { _effects_OnTick_StatModifiers_Str = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Int { get { return _effects_OnTick_StatModifiers_Int; } set { _effects_OnTick_StatModifiers_Int = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Wis { get { return _effects_OnTick_StatModifiers_Wis; } set { _effects_OnTick_StatModifiers_Wis = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Con { get { return _effects_OnTick_StatModifiers_Con; } set { _effects_OnTick_StatModifiers_Con = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Dex { get { return _effects_OnTick_StatModifiers_Dex; } set { _effects_OnTick_StatModifiers_Dex = value; OnPropertyChanged(); } }
        public int Effects_OnTick_StatModifiers_Hp { get { return _effects_OnTick_StatModifiers_Hp; } set { _effects_OnTick_StatModifiers_Hp = value; OnPropertyChanged(); } }
        public int Effects_OnTick_StatModifiers_Mp { get { return _effects_OnTick_StatModifiers_Mp; } set { _effects_OnTick_StatModifiers_Mp = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Hit { get { return _effects_OnTick_StatModifiers_Hit; } set { _effects_OnTick_StatModifiers_Hit = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Dmg { get { return _effects_OnTick_StatModifiers_Dmg; } set { _effects_OnTick_StatModifiers_Dmg = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Ac { get { return _effects_OnTick_StatModifiers_Ac; } set { _effects_OnTick_StatModifiers_Ac = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Regen { get { return _effects_OnTick_StatModifiers_Regen; } set { _effects_OnTick_StatModifiers_Regen = value; OnPropertyChanged(); } }
        public sbyte Effects_OnTick_StatModifiers_Mr { get { return _effects_OnTick_StatModifiers_Mr; } set { _effects_OnTick_StatModifiers_Mr = value; OnPropertyChanged(); } }
        public Element Effects_OnTick_StatModifiers_OffensiveElement { get { return _effects_OnTick_StatModifiers_OffensiveElement; } set { _effects_OnTick_StatModifiers_OffensiveElement = value; OnPropertyChanged(); } }
        public Element Effects_OnTick_StatModifiers_DefensiveElement { get { return _effects_OnTick_StatModifiers_DefensiveElement; } set { _effects_OnTick_StatModifiers_DefensiveElement = value; OnPropertyChanged(); } }
        public float Effects_OnTick_StatModifiers_DmgModifier { get { return _effects_OnTick_StatModifiers_DmgModifier; } set { _effects_OnTick_StatModifiers_DmgModifier = value; OnPropertyChanged(); } }
        public float Effects_OnTick_StatModifiers_HealModifier { get { return _effects_OnTick_StatModifiers_HealModifier; } set { _effects_OnTick_StatModifiers_HealModifier = value; OnPropertyChanged(); } }
        public DamageType Effects_OnTick_StatModifiers_DmgType { get { return _effects_OnTick_StatModifiers_DmgType; } set { _effects_OnTick_StatModifiers_DmgType = value; OnPropertyChanged(); } }
        public float Effects_OnTick_StatModifiers_ReflectChance { get { return _effects_OnTick_StatModifiers_ReflectChance; } set { _effects_OnTick_StatModifiers_ReflectChance = value; OnPropertyChanged(); } }
        public float Effects_OnTick_StatModifiers_ReflectIntensity { get { return _effects_OnTick_StatModifiers_ReflectIntensity; } set { _effects_OnTick_StatModifiers_ReflectIntensity = value; OnPropertyChanged(); } }

        public CreatureCondition Effects_OnTick_Conditions_Set { get { return _effects_OnTick_Conditions_Set; } set { _effects_OnTick_Conditions_Set = value; OnPropertyChanged(); } }
        public List<string> Effects_OnTick_Conditions_Set_List { get { return _effects_OnTick_Conditions_Set_List; } set { _effects_OnTick_Conditions_Set_List = value; OnPropertyChanged(); } }
        public CreatureCondition Effects_OnTick_Conditions_Unset { get { return _effects_OnTick_Conditions_Unset; } set { _effects_OnTick_Conditions_Unset = value; OnPropertyChanged(); } }
        public List<string> Effects_OnTick_Conditions_Unset_List { get { return _effects_OnTick_Conditions_Unset_List; } set { _effects_OnTick_Conditions_Unset_List = value; OnPropertyChanged(); } }
        #endregion

        #region OnRemove
        public ushort Effects_OnRemove_Animations_Target_Id { get { return _effects_OnRemove_Animations_Target_Id; } set { _effects_OnRemove_Animations_Target_Id = value; OnPropertyChanged(); } }
        public short Effects_OnRemove_Animations_Target_Speed { get { return _effects_OnRemove_Animations_Target_Speed; } set { _effects_OnRemove_Animations_Target_Speed = value; OnPropertyChanged(); } }
        public ushort Effects_OnRemove_Animations_SpellEffect_Id { get { return _effects_OnRemove_Animations_SpellEffect_Id; } set { _effects_OnRemove_Animations_SpellEffect_Id = value; OnPropertyChanged(); } }
        public short Effects_OnRemove_Animations_SpellEffect_Speed { get { return _effects_OnRemove_Animations_SpellEffect_Speed; } set { _effects_OnRemove_Animations_SpellEffect_Speed = value; OnPropertyChanged(); } }

        public byte Effects_OnRemove_Sound_Id { get { return _effects_OnRemove_Sound_Id; } set { _effects_OnRemove_Sound_Id = value; OnPropertyChanged(); } }

        public string Effects_OnRemove_Messages_Target { get { return _effects_OnRemove_Messages_Target; } set { _effects_OnRemove_Messages_Target = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Messages_Source { get { return _effects_OnRemove_Messages_Source; } set { _effects_OnRemove_Messages_Source = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Messages_Group { get { return _effects_OnRemove_Messages_Group; } set { _effects_OnRemove_Messages_Group = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Messages_Say { get { return _effects_OnRemove_Messages_Say; } set { _effects_OnRemove_Messages_Say = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Messages_Shout { get { return _effects_OnRemove_Messages_Shout; } set { _effects_OnRemove_Messages_Shout = value; OnPropertyChanged(); } }

        public string Effects_OnRemove_Heal_Simple_Min { get { return _effects_OnRemove_Heal_Simple_Min; } set { _effects_OnRemove_Heal_Simple_Min = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Heal_Simple_Max { get { return _effects_OnRemove_Heal_Simple_Max; } set { _effects_OnRemove_Heal_Simple_Max = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Heal_Simple_Value { get { return _effects_OnRemove_Heal_Simple_Value; } set { _effects_OnRemove_Heal_Simple_Value = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Heal_Formula { get { return _effects_OnRemove_Heal_Formula; } set { _effects_OnRemove_Heal_Formula = value; OnPropertyChanged(); } }

        public DamageFlags Effects_OnRemove_Damage_Flags { get { return _effects_OnRemove_Damage_Flags; } set { _effects_OnRemove_Damage_Flags = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Damage_Simple_Min { get { return _effects_OnRemove_Damage_Simple_Min; } set { _effects_OnRemove_Damage_Simple_Min = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Damage_Simple_Max { get { return _effects_OnRemove_Damage_Simple_Max; } set { _effects_OnRemove_Damage_Simple_Max = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Damage_Simple_Value { get { return _effects_OnRemove_Damage_Simple_Value; } set { _effects_OnRemove_Damage_Simple_Value = value; OnPropertyChanged(); } }
        public string Effects_OnRemove_Damage_Formula { get { return _effects_OnRemove_Damage_Formula; } set { _effects_OnRemove_Damage_Formula = value; OnPropertyChanged(); } }
        public DamageType Effects_OnRemove_Damage_Type { get { return _effects_OnRemove_Damage_Type; } set { _effects_OnRemove_Damage_Type = value; OnPropertyChanged(); } }

        public sbyte Effects_OnRemove_StatModifiers_Str { get { return _effects_OnRemove_StatModifiers_Str; } set { _effects_OnRemove_StatModifiers_Str = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Int { get { return _effects_OnRemove_StatModifiers_Int; } set { _effects_OnRemove_StatModifiers_Int = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Wis { get { return _effects_OnRemove_StatModifiers_Wis; } set { _effects_OnRemove_StatModifiers_Wis = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Con { get { return _effects_OnRemove_StatModifiers_Con; } set { _effects_OnRemove_StatModifiers_Con = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Dex { get { return _effects_OnRemove_StatModifiers_Dex; } set { _effects_OnRemove_StatModifiers_Dex = value; OnPropertyChanged(); } }
        public int Effects_OnRemove_StatModifiers_Hp { get { return _effects_OnRemove_StatModifiers_Hp; } set { _effects_OnRemove_StatModifiers_Hp = value; OnPropertyChanged(); } }
        public int Effects_OnRemove_StatModifiers_Mp { get { return _effects_OnRemove_StatModifiers_Mp; } set { _effects_OnRemove_StatModifiers_Mp = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Hit { get { return _effects_OnRemove_StatModifiers_Hit; } set { _effects_OnRemove_StatModifiers_Hit = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Dmg { get { return _effects_OnRemove_StatModifiers_Dmg; } set { _effects_OnRemove_StatModifiers_Dmg = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Ac { get { return _effects_OnRemove_StatModifiers_Ac; } set { _effects_OnRemove_StatModifiers_Ac = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Regen { get { return _effects_OnRemove_StatModifiers_Regen; } set { _effects_OnRemove_StatModifiers_Regen = value; OnPropertyChanged(); } }
        public sbyte Effects_OnRemove_StatModifiers_Mr { get { return _effects_OnRemove_StatModifiers_Mr; } set { _effects_OnRemove_StatModifiers_Mr = value; OnPropertyChanged(); } }
        public Element Effects_OnRemove_StatModifiers_OffensiveElement { get { return _effects_OnRemove_StatModifiers_OffensiveElement; } set { _effects_OnRemove_StatModifiers_OffensiveElement = value; OnPropertyChanged(); } }
        public Element Effects_OnRemove_StatModifiers_DefensiveElement { get { return _effects_OnRemove_StatModifiers_DefensiveElement; } set { _effects_OnRemove_StatModifiers_DefensiveElement = value; OnPropertyChanged(); } }
        public float Effects_OnRemove_StatModifiers_DmgModifier { get { return _effects_OnRemove_StatModifiers_DmgModifier; } set { _effects_OnRemove_StatModifiers_DmgModifier = value; OnPropertyChanged(); } }
        public float Effects_OnRemove_StatModifiers_HealModifier { get { return _effects_OnRemove_StatModifiers_HealModifier; } set { _effects_OnRemove_StatModifiers_HealModifier = value; OnPropertyChanged(); } }
        public DamageType Effects_OnRemove_StatModifiers_DmgType { get { return _effects_OnRemove_StatModifiers_DmgType; } set { _effects_OnRemove_StatModifiers_DmgType = value; OnPropertyChanged(); } }
        public float Effects_OnRemove_StatModifiers_ReflectChance { get { return _effects_OnRemove_StatModifiers_ReflectChance; } set { _effects_OnRemove_StatModifiers_ReflectChance = value; OnPropertyChanged(); } }
        public float Effects_OnRemove_StatModifiers_ReflectIntensity { get { return _effects_OnRemove_StatModifiers_ReflectIntensity; } set { _effects_OnRemove_StatModifiers_ReflectIntensity = value; OnPropertyChanged(); } }

        public CreatureCondition Effects_OnRemove_Conditions_Set { get { return _effects_OnRemove_Conditions_Set; } set { _effects_OnRemove_Conditions_Set = value; OnPropertyChanged(); } }
        public List<string> Effects_OnRemove_Conditions_Set_List { get { return _effects_OnRemove_Conditions_Set_List; } set { _effects_OnRemove_Conditions_Set_List = value; OnPropertyChanged(); } }
        public CreatureCondition Effects_OnRemove_Conditions_Unset { get { return _effects_OnRemove_Conditions_Unset; } set { _effects_OnRemove_Conditions_Unset = value; OnPropertyChanged(); } }
        public List<string> Effects_OnRemove_Conditions_Unset_List { get { return _effects_OnRemove_Conditions_Unset_List; } set { _effects_OnRemove_Conditions_Unset_List = value; OnPropertyChanged(); } }
        #endregion

        #endregion

        public CastRestriction CastRestriction
        {
            get { return _castRestriction; }
            set
            {
                _castRestriction = value;
                OnPropertyChanged();
            }
        }

        public string CastRestriction_Receive
        {
            get { return _castRestriction_Receive; }
            set
            {
                _castRestriction_Receive = value;
                OnPropertyChanged();
            }
        }

        public string CastRestriction_Use
        {
            get { return _castRestriction_Use; }
            set
            {
                _castRestriction_Use = value;
                OnPropertyChanged();
            }
        }

        public string ProhibitedMessage
        {
            get { return _prohibitedMessage; }
            set
            {
                _prohibitedMessage = value;
                OnPropertyChanged();
            }
        }

        public string Script
        {
            get { return _script; }
            set
            {
                _script = value;
                OnPropertyChanged();
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                OnPropertyChanged();
            }
        }

        public int Tick
        {
            get { return _tick; }
            set
            {
                _tick = value;
                OnPropertyChanged();
            }
        }

        public ushort Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public Status Status { get; set; }
    }
}
