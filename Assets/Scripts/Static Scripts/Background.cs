using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    
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
    void Update()
    {
        Debug.Log("RULERSHIP" + this.Rulership);
        
    }
        /// <summary>
        /// BACKGROUND MAIN INFORMATION
        /// </summary>
        string BackgroundName;
    ArrayList backgroundBonusses = new ArrayList(3);
    //Backgrounds have 3 bonusses.
    public Background(string name)
    {
        BackgroundName = name;

        switch (name)
        {
            case "Servant":
                this.Medicine = 1;
                this.Alchemy = 1;
                this.Stewardship = 1;
                break;
            case "Priest":
                this.Medicine = 1;
                this.Holy = 1;
                this.Religion = 1;
                break;
            case "Inquisitor":
                this.Dread = 1;
                this.Command = 1;
                this.Alchemy = 1;
                break;
            case "Miner":
                this.Smithing = 1;
                this.Determination = 1;
                this.Constitution = 1;
                break;
            case "Farmer":
                this.Harvesting = 1;
                this.Constitution = 1;
                this.Teamwork = 1;
                break;
            default:
                this.BackgroundName = "Commoner";
                this.Harvesting = 1;
                this.Hunting = 1;
                this.Bargaining = 1;
                break;
        }

    }
}
