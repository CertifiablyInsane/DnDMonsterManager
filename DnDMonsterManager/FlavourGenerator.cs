using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMonsterManager
{
    static class FlavourGenerator
    {
        // Use luckMod for anything involving random chance.
        // 1 is normal, 2 is twice as lucky
        private static float luckMod = 1;
        // It is more likely to damage a small creature. Tiny -> Medium -> Gargantuan.
        private static float[] sizeLuckMods = { 1.35f, 1.2f, 1f, 0.9f, 0.8f, 0.75f };

        private static MonsterData? _data;
        private static int _oldHealth;
        private static int _newHealth;
        private static int _damage;
        private static DamageType _damageType;
        static Random random = new Random();
        public static string[] Generate(MonsterData data, int oldHealth, int newHealth, int damage, DamageType damageType, bool guaranteedEffect = false)
        {
            _data = data;
            _oldHealth = oldHealth;
            _newHealth = newHealth;
            _damage = damage;
            _damageType = damageType;
            if(guaranteedEffect || RollForEffect())
            {
                int severity = random.Next(0, 3);
                return GetString(_data._name, severity, _damageType, _data._type);
                
            }
            else
            {
                return new string[] { string.Empty, string.Empty };
            }
        }

        private static bool RollForEffect()
        {
            if(_data == null)
            {
                return false;
            }
            // If bloodied, guarantee an event.
            if ((_oldHealth > _data._maxHp / 2) && (_newHealth < _data._maxHp / 2))
            {
                return true;
            }
            float healthRatio = _damage / _data._maxHp; // example: 0.25 for 25% of hp
            float sizeLuckMod = sizeLuckMods[(int)_data._size]; // Set luck mod to size
            float randomVal = (float)random.NextDouble();
            // with a luckMod of 1, the chance of an event will be equal to ratio of hp taken off.
            // > 1 = more chance it hits, < 1 = less chance it hits
            if(randomVal < healthRatio * sizeLuckMod * luckMod)
            {
                return true;
            }
            return false;
        }
        private static string[] GetString(string name, int severity, DamageType dmgType, EType monType)
        {
            if (
                monType == EType.Aberration ||
                monType == EType.Beast ||
                monType == EType.Celestial ||
                monType == EType.Dragon ||
                monType == EType.Fey ||
                monType == EType.Fiend ||
                monType == EType.Giant ||
                monType == EType.Humanoid ||
                monType == EType.Monstrosity
                )
            {
                return GetPhysicalRegularString(name, severity, dmgType);
            }
            else if (monType == EType.Construct || monType == EType.Undead)
            {
                return GetPhysicalIrregularString(name, severity, dmgType);
            }
            else if (monType == EType.Elemental || monType == EType.Ooze)
            {
                return GetSubstanceString(name, severity, dmgType);
            }
            else if (monType == EType.Plant)
            {
                return GetPlantString(name, severity, dmgType);
            }
            return new string[] { string.Empty, string.Empty };
        }
        private static string[] GetPhysicalRegularString(string name, int severity, DamageType dmgType)
        {
            if (dmgType == DamageType.Generic)
            {
                int r = random.Next(3); // 0, 1, 2
                dmgType = (DamageType)r; // turn it blud, slash, or pierce
            }
            
            string[][] s = new string[1][];
            switch (dmgType)
            {
                case DamageType.Bludgeoning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is knocked over!", "Prone" },
                        new string[] { $"The {name} loses an appendage!", "Missing Appendage" },
                        new string[] { $"The {name} breaks a bone!", "Broken None" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];

                case DamageType.Piercing:
                    s = new string[][]
                    {
                        new string[] { $"The {name} begins gushing blood!", "Bleeding (Major)" },
                        new string[] { $"The attack pierces an organ!", "Pierced Organ" },
                        new string[] { $"The {name} bleeds a little!", "Bleeding (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Slashing:
                    s = new string[][]
                    {
                        new string[] { $"The attack tears flesh!", "Flesh Wound (Major)" },
                        new string[] { $"The {name} loses an appendage!", "Missing Appendage" },
                        new string[] { $"The attack rips open skin!", "Skin Wound (Major)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Acid:
                    s = new string[][]
                    {
                        new string[] { $"The acid gets into the {name}'s bloodstream!", "Acid Infected" },
                        new string[] { $"The {name} bone becomes exposed!", "Bone Exposed" },
                        new string[] { $"The {name}'s skin begins to melt!", "Skin Wound (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Cold:
                    s = new string[][]
                    {
                        new string[] { $"An appendage on the {name} becomes difficult to move!", "Frozen Appendage" },
                        new string[] { $"The {name}'s blood flow begins to slow!", "Slowed Heartrate" },
                        new string[] { $"The {name} starts shivering uncontrollably!", "Shivering Cold" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Fire:
                    s = new string[][]
                    {
                        new string[] { $"A chunk of the {name}'s flesh burns clean off!", "Charred Flesh" },
                        new string[] { $"The {name}'s skin begins to melt!", "Melting Skin" },
                        new string[] { $"The {name} swells up!", "Swelling Heat" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Force:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is thrown to the ground!", "Prone" },
                        new string[] { $"The {name}'s bone breaks from force!", "Broken Bone" },
                        new string[] { $"The {name} is pushed back significantly!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Lightning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} temporarily loses hearing!", "Deaf" },
                        new string[] { $"The {name}' skin burns from shock!", "Burnt Skin" },
                        new string[] { $"The {name}'s heartrate spikes!", "Increased Heartrate" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Necrotic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} begins to feel drained!", "Lifeforce Drained (Minor)" },
                        new string[] { $"The {name}' soul begins to wither!", "Soul Damage (Major)" },
                        new string[] { $"The {name}'s soul dies, slightly!", "Soul Damage (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Poison:
                    s = new string[][]
                    {
                        new string[] { $"The {name} projectile vomits!", string.Empty },
                        new string[] { $"The {name} feels a little dizzy!", "Dizzy" },
                        new string[] { $"The {name} feels sick!", "Sickened" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Psychic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels a loss of mental cognition!", "Brain Damaged" },
                        new string[] { $"The {name} cannot control its emotions!", "Psychic Degradation (Major)" },
                        new string[] { $"The {name} is offended, but doesn't know why!", "Psychic Degradation (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Radiant:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels light enter their bloodstream!", "Glowing" },
                        new string[] { $"The {name} feels the rage of the Gods", "Smitten (Major)" },
                        new string[] { $"The {name} feels the frowns of the Gods", "Smitten (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Thunder:
                    s = new string[][]
                    {
                        new string[] { $"Something explodes inside the {name}!", "Interal Damage" },
                        new string[] { $"An appendage from the {name} is blown clean off!", "Missing Appendage" },
                        new string[] { $"The {name} is pushed by the force!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
            }
            return new string[] {string.Empty, string.Empty};
        }
        private static string[] GetPhysicalIrregularString(string name, int severity, DamageType dmgType)
        {
            if (dmgType == DamageType.Generic)
            {
                int r = random.Next(3); // 0, 1, 2
                dmgType = (DamageType)r; // turn it blud, slash, or pierce
            }
            
            string[][] s = new string[1][];
            switch (dmgType)
            {
                case DamageType.Bludgeoning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is knocked over!", "Prone" },
                        new string[] { $"The {name} loses an appendage!", "Missing Appendage" },
                        new string[] { $"The {name} is knocked back!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];

                case DamageType.Piercing:
                    s = new string[][]
                    {
                        new string[] { $"A substantal hole is poked into the {name}!", "Hole Poked" },
                        new string[] { $"The attack pierces an vital!", "Pierced Vital" },
                        new string[] { $"The {name} finds the attacked part hard to move!", "Damaged Area" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Slashing:
                    s = new string[][]
                    {
                        new string[] { $"The attack lobs a part off!", "Missing Part" },
                        new string[] { $"The {name} loses an appendage!", "Missing Appendage" },
                        new string[] { $"The attack rips open an outer layer!", "Internals Exposed" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Acid:
                    s = new string[][]
                    {
                        new string[] { $"The acid interferes with the {name}'s cognition!", "Cognitive Damage" },
                        new string[] { $"The {name}'s internals becomes exposed!", "Internals Exposed" },
                        new string[] { $"A portion of the {name}'s body melts!", "Body Damage" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Cold:
                    s = new string[][]
                    {
                        new string[] { $"An appendage on the {name} becomes difficult to move!", "Frozen Appendage" },
                        new string[] { $"The {name}'s movement begins to slow!", "Slowed Movement" },
                        new string[] { $"Ice crystals form on the {name}'s body!", "Crystal Covered" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Fire:
                    s = new string[][]
                    {
                        new string[] { $"A chunk of the {name}'s body burns clean off!", "Charred Body" },
                        new string[] { $"The {name}'s systems begins to melt!", "Melting Systems" },
                        new string[] { $"The {name} loses its ability to make sound!", "Silenced" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Force:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is thrown to the ground!", "Prone" },
                        new string[] { $"The {name}'s appendage breaks from force!", "Broken Appendage" },
                        new string[] { $"The {name} is pushed back significantly!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Lightning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} temporarily loses hearing!", "Deaf" },
                        new string[] { $"The {name}' body burns from shock!", "Burnt Body" },
                        new string[] { $"The {name} is overloaded with energy!", "Overloaded" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Necrotic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} begins to feel internally drained!", "Force Drained (Minor)" },
                        new string[] { $"The void where soul should reside grows!", "Soul Damage (Major)" },
                        new string[] { $"The {name}'s lack of soul becomes apparent!", "Soul Damage (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Poison:
                    s = new string[][]
                    {
                        new string[] { $"The {name} vomits something from inside!", string.Empty },
                        new string[] { $"The {name} feels a little disoriented!", "Dizzy" },
                        new string[] { $"The poison enters the {name}'s internals!", "Sickened" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Psychic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels a loss of mental cognition!", "Brain Damaged" },
                        new string[] { $"The {name} becomes extremely volatile!", "Psychic Degradation (Major)" },
                        new string[] { $"The {name} becomes slightly more volatile!", "Psychic Degradation (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Radiant:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels light purge their insides!", "Glowing" },
                        new string[] { $"The {name} feels the rage of the Gods", "Smitten (Major)" },
                        new string[] { $"The {name} feels the frowns of the Gods", "Smitten (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Thunder:
                    s = new string[][]
                    {
                        new string[] { $"Something explodes inside the {name}!", "Interal Damage" },
                        new string[] { $"An appendage from the {name} is blown clean off!", "Missing Appendage" },
                        new string[] { $"The {name} is pushed by the force!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
            }
            return s[severity];
        }
        private static string[] GetSubstanceString(string name, int severity, DamageType dmgType)
        {
            if (dmgType == DamageType.Generic)
            {
                int r = random.Next(3); // 0, 1, 2
                dmgType = (DamageType)r; // turn it blud, slash, or pierce
            }
            
            string[][] s = new string[1][];
            switch (dmgType)
            {
                case DamageType.Bludgeoning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is knocked over!", "Prone" },
                        new string[] { $"A chunk of the {name} falls off", "Missing Chunk" },
                        new string[] { $"The becomes dented", "Dented" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];

                case DamageType.Piercing:
                    s = new string[][]
                    {
                        new string[] { $"A hole is pierced into the {name}", "Pierced (Minor)" },
                        new string[] { $"The attack pierces an important part!", "Pierced (Major)" },
                        new string[] { $"The {name} extrudes some substance!", "Losing Substance" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Slashing:
                    s = new string[][]
                    {
                        new string[] { $"The attack splits the {name} in two!", "Split In Two" },
                        new string[] { $"The {name} loses a chunk of itself!", "Missing Chunk" },
                        new string[] { $"The attack leaves a gash!", "Body Wound" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Acid:
                    s = new string[][]
                    {
                        new string[] { $"The acid gets into the {name}'s substance!", "Acid Infected" },
                        new string[] { $"A chunk of the {name} melts off", "Missing Chunk" },
                        new string[] { $"The {name} begins to melt!", "Acid Wound (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Cold:
                    s = new string[][]
                    {
                        new string[] { $"A part of the {name} becomes difficult to move!", "Frozen Part" },
                        new string[] { $"A small part of the {name} turns to ice!", "Iced" },
                        new string[] { $"The {name} starts shaking uncontrollably!", "Shaking Cold" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Fire:
                    s = new string[][]
                    {
                        new string[] { $"A chunk of the {name} burns clean off!", "Burnt" },
                        new string[] { $"The {name} begins to melt!", "Melting" },
                        new string[] { $"The {name} swells up!", "Swelling Heat" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Force:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is thrown to the ground!", "Prone" },
                        new string[] { $"A part of the {name} is thrown off from the force!", "Missing Chunk" },
                        new string[] { $"The {name} is pushed back significantly!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Lightning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} temporarily loses hearing!", "Deaf" },
                        new string[] { $"The {name} burns from shock!", "Burnt Skin" },
                        new string[] { $"The {name}'s becomes imbued with electricity!", "Electrically Imbued" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Necrotic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} begins to feel drained!", "Lifeforce Drained (Minor)" },
                        new string[] { $"The {name}' soul begins to wither!", "Soul Damage (Major)" },
                        new string[] { $"The {name}'s soul dies, slightly!", "Soul Damage (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Poison:
                    s = new string[][]
                    {
                        new string[] { $"The {name} vomits out its innards!", string.Empty },
                        new string[] { $"The {name} feels a little dizzy!", "Dizzy" },
                        new string[] { $"The {name} feels sick!", "Sickened" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Psychic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels a loss of mental cognition!", "Brain Damaged" },
                        new string[] { $"The {name} cannot control its emotions!", "Psychic Degradation (Major)" },
                        new string[] { $"The {name} is offended, but doesn't know why!", "Psychic Degradation (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Radiant:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels light enter their systems!", "Glowing" },
                        new string[] { $"The {name} feels the rage of the Gods", "Smitten (Major)" },
                        new string[] { $"The {name} feels the frowns of the Gods", "Smitten (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Thunder:
                    s = new string[][]
                    {
                        new string[] { $"Something explodes inside the {name}!", "Interal Damage" },
                        new string[] { $"A chunk of the {name} is blown clean off!", "Missing Chunk" },
                        new string[] { $"The {name} is pushed by the force!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
            }
            return s[severity];
        }
        private static string[] GetPlantString(string name, int severity, DamageType dmgType)
        {
            if (dmgType == DamageType.Generic)
            {
                int r = random.Next(3); // 0, 1, 2
                dmgType = (DamageType)r; // turn it blud, slash, or pierce
            }
            
            string[][] s = new string[1][];
            switch (dmgType)
            {
                case DamageType.Bludgeoning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is knocked over!", "Prone" },
                        new string[] { $"The {name} loses an appendage!", "Missing Appendage" },
                        new string[] { $"Parts of the {name}'s body breaks!", "Broken Body" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];

                case DamageType.Piercing:
                    s = new string[][]
                    {
                        new string[] { $"The {name} begins gushing fluids!", "Bleeding (Major)" },
                        new string[] { $"The attack pierces an important bit!", "Pierced" },
                        new string[] { $"The {name} loses some fluid!", "Bleeding (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Slashing:
                    s = new string[][]
                    {
                        new string[] { $"The attack lobs off a piece of the {name}!", "Body Wound (Major)" },
                        new string[] { $"An appendage of the {name} is badly damaged!", "Wounded Appendage" },
                        new string[] { $"The causes fluid to leak!", "Bleeding (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Acid:
                    s = new string[][]
                    {
                        new string[] { $"The acid gets into the {name}'s conductive tissues!", "Acid Infected" },
                        new string[] { $"Part of the {name} withers away!", "Withering" },
                        new string[] { $"Part of the {name}'s leaves begins to melt!", "Body Wound (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Cold:
                    s = new string[][]
                    {
                        new string[] { $"An appendage on the {name} becomes difficult to move!", "Frozen Appendage" },
                        new string[] { $"The {name}'s fluid flow begins to slow!", "Freezing Internals" },
                        new string[] { $"The {name} starts shivering uncontrollably!", "Shivering Cold" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Fire:
                    s = new string[][]
                    {
                        new string[] { $"A chunk of the {name}'s body burns clean off!", "Charred Body" },
                        new string[] { $"The {name}'s outer layer begins to melt!", "Melting" },
                        new string[] { $"The {name} swells up!", "Swelling Heat" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Force:
                    s = new string[][]
                    {
                        new string[] { $"The {name} is thrown to the ground!", "Prone" },
                        new string[] { $"One of the {name}'s stem or branch breaks from force!", "Broken" },
                        new string[] { $"The {name} is pushed back significantly!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Lightning:
                    s = new string[][]
                    {
                        new string[] { $"The {name} temporarily loses hearing!", "Deaf" },
                        new string[] { $"The {name} burns from shock!", "Burnt" },
                        new string[] { $"The {name} lights on fire!", "On Fire" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Necrotic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} begins to feel drained!", "Lifeforce Drained (Minor)" },
                        new string[] { $"The {name}' soul begins to wither!", "Soul Damage (Major)" },
                        new string[] { $"The {name}'s soul dies, slightly!", "Soul Damage (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Poison:
                    s = new string[][]
                    {
                        new string[] { $"The {name} vomits chlorophyll!", string.Empty },
                        new string[] { $"The {name} feels a little dizzy!", "Dizzy" },
                        new string[] { $"The {name} feels diseased!", "Diseased" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Psychic:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels a loss of mental cognition!", "Brain Damaged" },
                        new string[] { $"The {name} cannot control its emotions!", "Psychic Degradation (Major)" },
                        new string[] { $"The {name} is offended, but doesn't know why!", "Psychic Degradation (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Radiant:
                    s = new string[][]
                    {
                        new string[] { $"The {name} feels light enter their body!", "Glowing" },
                        new string[] { $"The {name} feels the rage of the Gods", "Smitten (Major)" },
                        new string[] { $"The {name} feels the frowns of the Gods", "Smitten (Minor)" },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
                case DamageType.Thunder:
                    s = new string[][]
                    {
                        new string[] { $"Something explodes inside the {name}!", "Interal Damage" },
                        new string[] { $"An appendage from the {name} is blown clean off!", "Missing Appendage" },
                        new string[] { $"The {name} is pushed by the force!", string.Empty },
                        new string[] { $"Weak Spot! The {name} takes an additional 1d4 damage.", string.Empty }
                    };
                    return s[severity];
            }
            return s[severity];
        }
    }
}
