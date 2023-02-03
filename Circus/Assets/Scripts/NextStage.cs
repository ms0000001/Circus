using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        StageLoad();
    }
    void StageLoad()
    {
        SceneManager.LoadScene("02.PlayScene2");   
    }
}
