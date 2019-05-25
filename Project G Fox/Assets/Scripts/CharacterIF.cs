using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CharacterIF
{
    int TakeDamage(int damage);
    void Attack(CharacterIF target, int row);
    

}
