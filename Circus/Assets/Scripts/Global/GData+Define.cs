using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class GData
{
    public const string SCENE_NAME_TITLE = "01.TttleScene";
    public const string SCENE_NAME_PLAY1 = "02.PlayScene";
    public const string SCENE_NAME_PLAY2 = "02.PlayScene2";

    public const string OBJ_NAME_CURRENT_LEVEL = "Level_1";
}

public enum PuzzleType
{
    NONE = -1, 
    PUZZLE_BIG_TRIANLE
}       //  PuzzleType