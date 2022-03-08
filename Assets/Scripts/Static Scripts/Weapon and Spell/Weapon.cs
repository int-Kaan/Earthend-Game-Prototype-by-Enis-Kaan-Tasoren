using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int Difficulty; //BURAYA EKLENECEK.
    //Type ?
    public string Type;

    //is it ranged ?
    public bool isRanged; //Can be Melee or Ranged // false -> Melee true -> Ranged

    //Damage Values
    public int ArmorPiercingDamage;
    public int WeaponDamage;
    public int MagicalDamage;
    public int TotalDamage;

    //Accuracy and evasion
    public int MeleeAttack; //0- 100
    public int MeleeDefense;
    public int RangedAttack;
    public int RangedDefense;

    //Stun Chanse
    public int StunChanse;

    //Attack Speed
    public int AttackSpeed;

    //Protection Bonus
    public int Protection;

    //Critical Chanses
    public int CriticalChanses;
    public int CriticalDamageMultiplayer;

    //Effects
    //>>>>>>>>>>>>> BURAYA EKLENECEK <<<<<<<<<<<<<

    //Elemental Affinity

    //Grip
    public bool isTwoHanded; //Two handed mi degil mi False -> One Handed True - > Two Handed

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
