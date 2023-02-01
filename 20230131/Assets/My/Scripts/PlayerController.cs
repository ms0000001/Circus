using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public bool LeftMove = false;
    public bool RightMove = false;
    Vector3 velocity = Vector3.zero;
    float speed = 8f;

    void Start()
    {   
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
    }    

    public void Move(){
        if(RightMove == true){
            animator.SetBool("Move", true);
            velocity = new Vector3(1,0,0);
            transform.position += velocity *speed * Time.deltaTime;
        }
        Debug.Log("isMove?");
    }
}
