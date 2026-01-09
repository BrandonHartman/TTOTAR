using System;
using Spectre.Console;

namespace TTOTAR
{
    public class Weapon
    {
        public WeaponPlacement Slot { get; set; }
        public WeaponType WeaponType { get; set; }

        public DamageType DamageType { get; set; }

        public WeaponRange WeaponRange { get; set; }

        public WeaponCategory WeaponCategory { get; set; }

        public WeaponRarity WeaponRarity { get; set; }

        public required int MinDamage { get; set; }
        public required int MaxDamage { get; set; }
        public required string Name { get; set; }

        public required string Description { get; set; }
        
        public int Weight { get; set; }

        public int Durability { get; set; } 

        public int Value { get; set; }



    }
    public enum WeaponPlacement
    {
        MainHand,
        OffHand,
        TwoHanded
    }

    public enum WeaponType
    {
        Melee,
        Ranged,
        Magic
    }

    public enum DamageType
    {
        Physical,
        Fire,
        Ice,
        Lightning,
        Poison,
        Arcane,
        Slashing,
        Piercing,
        Bludgeoning

    }
    public enum WeaponRange
    {
        Short,
        Medium,
        Long
    }
    public enum WeaponCategory
    {
        Axe,
        Staff,
        Bow,
        Crossbow,
        Wand,
        Dagger,
        Sword,
        Mace,
        Spear,
        Hammer,
        Fist
    }
    public enum WeaponRarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }
}