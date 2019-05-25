using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public ArrayList<Character> characterList;
    public Character[,] grid;



    // Start is called before the first frame update
    void Start()
    {
        characterList = new ArrayList();
        grid = new Character[3, 3];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool AddCharacter(Character c, int x, int y)
    {
        for(int i = 0; i < c.length-1; i++)
        {
            for(int j = 0; j < c.width-1; j++)
            {
                if(grid[x + i, y + j] != null)
                {
                    return false;
                }
            }
        }
        
        for(int i = 0; i < c.length-1; i++)
        {
            for(int j = 0; j < c.width-1; j++)
            {
                grid[x + i, y + j] = c;
            }
        }

        return true;
    }

}
