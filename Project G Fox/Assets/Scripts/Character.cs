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

    public float attackMoveTime = 1.0f;
    public float attackTime = .5f;
    private float timeSinceMove = 0;
    private float timeSinceAttack = 0;

    CharState state;

    Vector2 attackPos;
    Vector2 startPos;

    private bool returnAttack = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    
    void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime;
        print("Pos: " + transform.position + " state: " + state);

        if(Input.GetKeyDown("space") && state == CharState.idle)
        {
            Vector2 newPos = (Vector2)transform.position + Vector2.up;
            print("space pressed: new pos: " + newPos);

            Attack(null, 0, newPos);
        }

        if (state == CharState.moving)
        {
            timeSinceMove += delta;
            Vector2 newPos = Vector2.Lerp(startPos, attackPos, Math.Min(1.0f,timeSinceMove/attackMoveTime));
            transform.position = newPos;
            if(timeSinceMove >= attackMoveTime)
            {
                if (!returnAttack)
                    state = CharState.attacking;
                else
                    state = CharState.idle;

                timeSinceAttack = 0;
            }
        }
        else if(state == CharState.attacking)
        {
            timeSinceAttack += delta;
            if(timeSinceAttack >= attackTime)
            {
                state = CharState.moving;
                Vector2 p = startPos;
                startPos = attackPos;
                attackPos = p;
                timeSinceMove = 0;
                returnAttack = true;
            }
        }

    }

    public int TakeDamage(int damage)
    {
        int damageTaken = Math.Max(damage - defense, 0);
        currentHealth -= damageTaken;
        return damageTaken;
    }

    public void Attack(CharacterIF target, int row, Vector2 _attackPos)
    {
        attackPos = _attackPos;
        state = CharState.moving;
        timeSinceMove = 0;
        startPos = transform.position;
        returnAttack = false;
    }

    public int GetLength() { return length; }
    public int GetWidth() { return width; }

    public CharState GetState() { return state; }
}
