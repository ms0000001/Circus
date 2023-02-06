using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public Transform background;    
    float speed = 3.5f;
    public static bool Rbuttondown = false;
    public static bool Lbuttondown = false;

    void Start()
    {
    }

    void Update()
    {
        if(PlayerController.isDead == false){
        // MapMove();
        Btn_Rmove();
        Btn_Lmove();
        }        
    }
    
    void MapMove(){
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
            }
            if(touch.phase == TouchPhase.Moved){
            }
            if(touch.phase == TouchPhase.Stationary){
                background.transform.position += 
                Vector3.left*speed*Time.deltaTime;
            }
            if(touch.phase == TouchPhase.Ended){
            }
        }
        // if(Input.GetMouseButton(0)){
        //     background.transform.position += 
        //     Vector3.left*speed*Time.deltaTime;
        // }
    }
    public void Btn_Rmove(){
        if(Rbuttondown == true){
            background.transform.position += 
            Vector3.left*speed*Time.deltaTime;
        }
    }
    public void Btn_Lmove(){
        if(Lbuttondown == true){
            background.transform.position -= 
            Vector3.left*speed*Time.deltaTime;
        }
    }
}