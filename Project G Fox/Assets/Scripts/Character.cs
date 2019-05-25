using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Character : MonoBehaviour, CharacterIF
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    public int strength = 10;
    public int defense = 5;
    public int length;
    public int width;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int TakeDamage(int damage)
    {
        int damageTaken = Math.Max(damage - defense, 0);
        currentHealth -= damageTaken;
        return damageTaken;
    }

    public void Attack(CharacterIF target, int row)
    {
        target.TakeDamage(strength);
    }

    public int GetLength() { return length; }
    public int GetWidth() { return width; }
}
