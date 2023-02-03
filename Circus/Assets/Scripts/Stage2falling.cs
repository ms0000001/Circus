using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2falling : MonoBehaviour
{
    BoxCollider2D box2d;
    void Start()
    {
        box2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(PlayerController.isDead==true){
            Destroy(box2d);
        }
    }
}
