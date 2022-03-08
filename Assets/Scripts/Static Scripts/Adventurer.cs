using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    //Adventurer Stats
    int Level;
    //Bonus Types
    public int Melee;
    public int Ranged;
    /// <summary>
    /// Melee and ranged skills are awareness points in which they can increase the accuracy of the selected weapons.
    /// </summary>
    public int Sword;
    public int Shield;
    public int Hammer;
    public int Mace;
    public int Lance;
    public int Dagger;
    public int Bow;
    public int Crossbow;
    public int Wand;
    public int Staff;
    public int Potion;
    public int Fist;
    public int Throwing;
    //Lore
    public int Arcane; //Arcane Expertise 
    public int Fire;
    public int Ice;
    public int Holy;
    public int Nature;
    public int Necromancy;
    public int Summoning;
    public int Totemism;
    public int Decay;
    public int Illusion;
    public int Wind;
    public int Draconic;
    public int Vampire;
    public int Rune;
    public int Moon;
    //General
    public int Constitution;
    public int Determination;
    public int Bravery;
    public int Reflex;
    public int Vision;
    public int Concentration;
    public int Agility;
    public int Medicine;
    public int Knowledge;
    public int Alchemy;
    public int Harvesting;
    public int Hunting;
    public int Stealth;
    public int Religion;
    public int Dual;

    //Control
    public int Command;
    public int Teamwork;
    public int Sanity;
    public int Decisioning;
    public int Planning;
    public int Scouting;
    public int Lawfulness;
    public int Dread;
    public int Smithing;
    public int Crafting;
    public int Enchanting;
    public int Bargaining;
    public int Speech;
    public int Stewardship;
    public int Rulership;

    [SerializeField]
    string Adventurer_Name;

    //ARMOR
    HeadArmor HeadArmor;
    BodyArmor BodyArmor;
    Amulet Amulet;
    Cloak Cloak;
    Ring Ring;

    //Weapon Slots


    //Equipment Slots
    //1 2 3  4 5

    //Spell Slots
    //According to arcane level !

    //BACKGROUND
    Background AdventurersBackground;


    int HP;
    int Moral;

    //Hit and Defense Chanses
    int MeleeAttack;
    int MeleeDefense;
    int RangedAttack;
    int RangedDefense;
    int Spellcasting;
    //Mana
    int Mana;

    //Max Favor
    int GodsFavor;

    //Spellshield
    int SpellShield;

    //Armor
    int HeadArmorValue;
    int BodyArmorValue;
    int ArmorBonus;

    //Damage 
    int MeleeDamage;
    int RangedDamage;
    int ArmorPiercingDamage;
    int SpellDamage;

    //Dodge Chanse
    int DodgeChanse;

    //Initiative
    int Initiative;

    //Attack Speed
    int AttackSpeed;

    //Critical Chanse

    //Critical Damage Multiplayer

    //Immunities
    int FireImmunity;
    int IceImmunity;
    int BleedImmunity;
    int UnholyImmunity;
    int DecayImmunity;

    //Mark Count
    int AssasinationMarkCount;

    //Dual Wielding Innefficiency
    int DualInneficiency;
    bool doesBackgroundbonusUsed = false;
    void Update()
    {
        Level = Sword + Shield + Hammer + Mace + Lance + Dagger + Bow + Crossbow + Wand +
        Staff + Potion + Fist + Throwing + Arcane + Fire + Ice + Holy + Nature + Necromancy + Summoning +
        Totemism + Decay + Illusion + Wind + Draconic + Vampire + Rune + Moon + Constitution + Determination +
        Bravery + Reflex + Vision + Concentration + Agility + Medicine + Knowledge + Alchemy + Harvesting +
        Hunting + Stealth + Religion + Dual + Command + Teamwork + Sanity + Decisioning + Planning + Scouting +
        Lawfulness + Dread + Smithing + Crafting + Enchanting + Bargaining + Speech + Stewardship + Rulership;

        if(doesBackgroundbonusUsed == false)
        {
            if (AdventurersBackground != null)
            {
                getAdventurerBonusses();
            }
        }
    }


















































    void getAdventurerBonusses()
    {
        doesBackgroundbonusUsed = true;
        //WAR STATS
        if (AdventurersBackground.Melee != 0)
        {
            this.Melee += 1;
        }
        if (AdventurersBackground.Ranged != 0)
        {
            this.Ranged += 1;
        }
        if (AdventurersBackground.Sword != 0)
        {
            this.Sword += 1;
        }
        if (AdventurersBackground.Shield != 0)
        {
            this.Shield += 1;
        }
        if (AdventurersBackground.Hammer != 0)
        {
            this.Hammer += 1;
        }
        if (AdventurersBackground.Mace != 0)
        {
            this.Mace += 1;
        }
        if (AdventurersBackground.Lance != 0)
        {
            this.Lance += 1;
        }
        if (AdventurersBackground.Dagger != 0)
        {
            this.Dagger += 1;
        }
        if (AdventurersBackground.Bow != 0)
        {
            this.Bow += 1;
        }
        if (AdventurersBackground.Crossbow != 0)
        {
            this.Crossbow += 1;
        }
        if (AdventurersBackground.Wand != 0)
        {
            this.Wand += 1;
        }
        if (AdventurersBackground.Staff != 0)
        {
            this.Staff += 1;
        }
        if (AdventurersBackground.Potion != 0)
        {
            this.Potion += 1;
        }
        if (AdventurersBackground.Fist != 0)
        {
            this.Fist += 1;
        }
        if (AdventurersBackground.Throwing != 0)
        {
            this.Throwing += 1;
        }
        //LORE
        if (AdventurersBackground.Arcane != 0)
        {
            this.Arcane += 1;
        }
        if (AdventurersBackground.Fire != 0)
        {
            this.Fire += 1;
        }
        if (AdventurersBackground.Ice != 0)
        {
            this.Ice += 1;
        }
        if (AdventurersBackground.Holy != 0)
        {
            this.Holy += 1;
        }
        if (AdventurersBackground.Nature != 0)
        {
            this.Nature += 1;
        }
        if (AdventurersBackground.Necromancy != 0)
        {
            this.Necromancy += 1;
        }
        if (AdventurersBackground.Summoning != 0)
        {
            this.Summoning += 1;
        }
        if (AdventurersBackground.Totemism != 0)
        {
            this.Totemism += 1;
        }
        if (AdventurersBackground.Decay != 0)
        {
            this.Decay += 1;
        }
        if (AdventurersBackground.Illusion != 0)
        {
            this.Illusion += 1;
        }
        if (AdventurersBackground.Wind != 0)
        {
            this.Wind += 1;
        }
        if (AdventurersBackground.Draconic != 0)
        {
            this.Draconic += 1;
        }
        if (AdventurersBackground.Vampire != 0)
        {
            this.Vampire += 1;
        }
        if (AdventurersBackground.Rune != 0)
        {
            this.Rune += 1;
        }
        if (AdventurersBackground.Moon != 0)
        {
            this.Moon += 1;
        }
        //GENERAL
        if (AdventurersBackground.Constitution != 0)
        {
            this.Arcane += 1;
        }
        if (AdventurersBackground.Determination != 0)
        {
            this.Fire += 1;
        }
        if (AdventurersBackground.Bravery != 0)
        {
            this.Ice += 1;
        }
        if (AdventurersBackground.Reflex != 0)
        {
            this.Holy += 1;
        }
        if (AdventurersBackground.Vision != 0)
        {
            this.Nature += 1;
        }
        if (AdventurersBackground.Concentration != 0)
        {
            this.Necromancy += 1;
        }
        if (AdventurersBackground.Agility != 0)
        {
            this.Summoning += 1;
        }
        if (AdventurersBackground.Medicine != 0)
        {
            this.Totemism += 1;
        }
        if (AdventurersBackground.Knowledge != 0)
        {
            this.Decay += 1;
        }
        if (AdventurersBackground.Alchemy != 0)
        {
            this.Illusion += 1;
        }
        if (AdventurersBackground.Harvesting != 0)
        {
            this.Wind += 1;
        }
        if (AdventurersBackground.Hunting != 0)
        {
            this.Draconic += 1;
        }
        if (AdventurersBackground.Stealth != 0)
        {
            this.Vampire += 1;
        }
        if (AdventurersBackground.Religion != 0)
        {
            this.Rune += 1;
        }
        if (AdventurersBackground.Dual != 0)
        {
            this.Moon += 1;
        }
        //CONTROL
        if (AdventurersBackground.Command != 0)
        {
            this.Arcane += 1;
        }
        if (AdventurersBackground.Teamwork != 0)
        {
            this.Fire += 1;
        }
        if (AdventurersBackground.Sanity != 0)
        {
            this.Ice += 1;
        }
        if (AdventurersBackground.Decisioning != 0)
        {
            this.Holy += 1;
        }
        if (AdventurersBackground.Planning != 0)
        {
            this.Nature += 1;
        }
        if (AdventurersBackground.Scouting != 0)
        {
            this.Necromancy += 1;
        }
        if (AdventurersBackground.Lawfulness != 0)
        {
            this.Summoning += 1;
        }
        if (AdventurersBackground.Dread != 0)
        {
            this.Totemism += 1;
        }
        if (AdventurersBackground.Smithing != 0)
        {
            this.Decay += 1;
        }
        if (AdventurersBackground.Crafting != 0)
        {
            this.Illusion += 1;
        }
        if (AdventurersBackground.Enchanting != 0)
        {
            this.Wind += 1;
        }
        if (AdventurersBackground.Bargaining != 0)
        {
            this.Draconic += 1;
        }
        if (AdventurersBackground.Speech != 0)
        {
            this.Vampire += 1;
        }
        if (AdventurersBackground.Stewardship != 0)
        {
            this.Rune += 1;
        }
        if (AdventurersBackground.Rulership != 0)
        {
            this.Moon += 1;
        }
    }
}
