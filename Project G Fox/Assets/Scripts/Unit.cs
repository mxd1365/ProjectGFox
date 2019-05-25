using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public List<CharacterIF> characterList;
    public CharacterIF[,] grid;
    public UnitIF enemy;
    public int gridLength, gridWidth;



    // Start is called before the first frame update
    void Start()
    {
        gridLength = 3;
        gridWidth = 3;
        characterList = new List<CharacterIF>();
        grid = new CharacterIF[gridLength, gridWidth];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool AddCharacterToGrid(CharacterIF c, int x, int y)
    {
        for(int i = 0; i < c.GetWidth(); i++)
        {
            for(int j = 0; j < c.GetLength(); j++)
            {
                if(grid[x + i, y + j] != null)
                {
                    return false;
                }
            }
        }
        
        for(int i = 0; i < c.GetWidth(); i++)
        {
            for(int j = 0; j < c.GetLength(); j++)
            {
                grid[x + i, y + j] = c;
            }
        }

        return true;
    }

    bool MoveCharacterInGrid(CharacterIF c, int x, int y)
    {
        var pos = FindCharacterInGrid(c); 
        if(pos.Item1 != -1)
        {
            if (x + c.GetLength() < gridLength && y + c.GetWidth < gridWidth)
            {
                for (int i = 0; i < c.GetWidth(); i++)
                {
                    for (int j = 0; j < c.GetLength(); j++)
                    {
                        if (grid[x + i, y + j] != null)
                        {
                           //reserves.send(character); 
                        }
                        grid[pos.Item1 + i, pos.Item2 + j] = null;
                    }
                }
            }

        }
        return false;
    }

    (int, int) FindCharacterInGrid(CharacterIF c)
    {
        for (int i = 0; i < gridLength; i++)
        {
            for (int j = 0; j < gridWidth; j++)
            {
               if(grid[i, j] == c)
                {
                    return (i, j);
                }
            }
        }

        return (-1, -1);
    }
    

}
