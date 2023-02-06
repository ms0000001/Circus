using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float JumpForce = 378f;
    bool isGrounded = false;
    public static bool isDead = false;
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    void Start()
    {
        isDead = false;
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator.SetBool("Grounded", isGrounded);

    }

    void Update()
    {
        Move();
    }
    public void Btn_Jump(){
        if(isGrounded == true){
            animator.SetBool("Move", false);
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(new Vector2(0,JumpForce));
            animator.SetBool("Grounded", isGrounded);
            animator.SetBool("Move", false);            
        }
    }

    void Move(){    
        if(isDead == false){
            animator.SetBool("Grounded", isGrounded);
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Began){
                    }
                if(touch.phase == TouchPhase.Moved){

                    }
               if(touch.phase == TouchPhase.Stationary){
                    animator.SetBool("Grounded", isGrounded);
                    animator.SetBool("Move", true);
                    //앞으로 이동
                    }            
                if(touch.phase == TouchPhase.Ended){   
                    animator.SetBool("Move", false);            

                    //점프
                }            
            }
            // if(Input.GetMouseButtonDown(0)){
            //     animator.SetBool("Grounded", isGrounded);
            //     animator.SetBool("Move", true);
            // }
            // if(Input.GetMouseButtonUp(0)){
            //     animator.SetBool("Move", false);
            //     if(isGrounded == true){
            //             rigidbody2D.velocity = Vector2.zero;
            //             rigidbody2D.AddForce(new Vector2(0,JumpForce));
            //             animator.SetBool("Grounded", isGrounded);
            //             animator.SetBool("Move", false);
            //         }
            // }            
        }    
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ring"){
            animator.SetTrigger("Die");
            isDead = true;
            Destroy(rigidbody2D);
            Debug.Log("작동확인사망");
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.EndGame();
        }
        if(other.tag == "Monkey"){
            animator.SetTrigger("Die");
            isDead = true;
            Debug.Log("작동확인사망");
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.EndGame();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.contacts[0].normal.y>0.7f){
            isGrounded = true;
            Debug.Log("작동확인땅붙");
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        isGrounded = false;        
        Debug.Log("작동확인땅떨");
    }
}
