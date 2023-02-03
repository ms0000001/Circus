using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public Transform background;    
    float speed = 3.5f;
    void Start()
    {
    }

    void Update()
    {
        if(PlayerController.isDead == false){
        MapMove();
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
}