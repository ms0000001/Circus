using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyMoving : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Monkey_M();
    }

    void Monkey_M(){
        if(PlayerController.isDead == false){
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
            }
            if(touch.phase == TouchPhase.Moved){
            }
            if(touch.phase == TouchPhase.Stationary){
                animator.SetBool("Monkey_Move", true);
            }
            if(touch.phase == TouchPhase.Ended){
                animator.SetBool("Monkey_Move", false);
            }
        }
        }
    }
}
