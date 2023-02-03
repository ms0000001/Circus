using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    private bool isGameover;
    void Start()
    {
        isGameover = false;
    }

    void Update()
    {
        SecneLoad();
    }

    void SecneLoad(){
        if(isGameover ==true){
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
                SceneManager.LoadScene("02.PlayScene");
            }
            if(touch.phase == TouchPhase.Moved){
            }
            if(touch.phase == TouchPhase.Stationary){                
            }
            if(touch.phase == TouchPhase.Ended){
            }
        }
        // if(Input.GetMouseButtonDown(0)){
        //         SceneManager.LoadScene("02.PlayScene");
        //     }
        }   
    }

    public void EndGame(){
        isGameover = true;
        gameoverText.SetActive(true);
    }
}
