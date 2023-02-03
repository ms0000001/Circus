using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton1 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnPlayButton()
    {
        GFunc.LoadScene(GData.SCENE_NAME_PLAY2);
    }       //OnplayButoon()
    
}
