using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CharacterIF : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth = 100;
    public int strength = 10;
    public int defense = 5;

    public int TakeDamage(int damage);
    public void Attack(int row);
    

}
