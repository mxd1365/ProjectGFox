using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharState
{
    idle,
    moving,
    attacking

}

public interface CharacterIF
{

    CharState GetState();
    int GetLength();
    int GetWidth();
    int TakeDamage(int damage);
    void Attack(CharacterIF target, int row, Vector2 attackPos);
    

}
