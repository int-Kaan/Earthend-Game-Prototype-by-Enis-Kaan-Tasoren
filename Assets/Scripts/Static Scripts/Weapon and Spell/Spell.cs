using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string type;

    //Difficulty requirement
    public int difficulty; //dahasi eklenecek.

    public int damage;
    public string elemental_effect; //dahasi eklenecek is_fire is_ice etc.
    public int mana_cost;
    public double miscast_chanse;
    public int attack_speed;

    //Requirements on item
    public int required_equipment; //staff wand hammer etc buraya eklenecek does_require_hammer = yes etc

    //target
    public int target; //buraya does_target_self ? target_enemy bool yes no// SELF PARTY ENEMY ?

    public int target_count; //how much allied or enemy targets
}
