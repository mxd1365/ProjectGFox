using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public List<CharacterIF> characterList;
    public CharacterIF[,] grid;



    // Start is called before the first frame update
    void Start()
    {
        characterList = new List<CharacterIF>();
        grid = new CharacterIF[3, 3];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool AddCharacter(CharacterIF c, int x, int y)
    {
        for(int i = 0; i < c.GetLength()-1; i++)
        {
            for(int j = 0; j < c.GetWidth()-1; j++)
            {
                if(grid[x + i, y + j] != null)
                {
                    return false;
                }
            }
        }
        
        for(int i = 0; i < c.GetLength()-1; i++)
        {
            for(int j = 0; j < c.GetWidth()-1; j++)
            {
                grid[x + i, y + j] = c;
            }
        }

        return true;
    }

}
