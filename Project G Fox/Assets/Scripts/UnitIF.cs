using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface UnitIF
{
    bool AddCharacterToGrid(CharacterIF c, int x, int y);
    bool MoveCharacterInGrid(CharacterIF c, int x, int y);
    (int, int) FindCharacterInGrid(CharacterIF c);
}
