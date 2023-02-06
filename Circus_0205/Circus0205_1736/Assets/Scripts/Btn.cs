using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RButtonDown(){
        MapController.Rbuttondown = true;
    }
    public void RButtonUp(){
        MapController.Rbuttondown = false;
    }
    public void LButtonDown(){
        MapController.Lbuttondown = true;
    }
    public void LButtonUp(){
        MapController.Lbuttondown = false;
    }
}
