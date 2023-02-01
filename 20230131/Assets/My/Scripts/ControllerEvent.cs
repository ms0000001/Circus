using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEvent : MonoBehaviour
{
    GameObject player;
    PlayerController playerController;

    void Start()
    {
        player = GameObject.Find("Lion");
        playerController = player.GetComponent<PlayerController>();
    }

    void Update()
    {
    }
    public void RightbtnDown(){
        playerController.RightMove = true;
    }
    public void RightbtnUp(){
        playerController.RightMove = false;
    }
}
