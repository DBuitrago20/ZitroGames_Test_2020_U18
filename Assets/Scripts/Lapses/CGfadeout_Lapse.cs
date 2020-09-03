using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGfadeout_Lapse : MonoBehaviour
{
    //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
    //////---------------------------------CANVAS-GROUP-FADE-OUT--------------------------------////////
    //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
    CanvasGroup cg;
    private float timer;
    private float speed;
    private void Loading_Parameters()
    {
        cg = GetComponent<CanvasGroup>();
        cg.interactable = false;
        cg.blocksRaycasts = false;
        timer = 1;
        speed = 1.5f;
    }
    
    private void Update_Canvas_Group_Fade_Out_Progress()
    {
        timer -= Time.deltaTime * speed;
        cg.alpha = timer;
        if(timer <= 0)
        {
            cg.alpha = 0;
            Destroy(GetComponent<CGfadeout_Lapse>());
        }
    }





    //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
    //////----------------------------------AWAKE/START/UPDATE----------------------------------////////
    //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
    private void Awake()
    {
        Loading_Parameters();
    }

    private void Update()
    {
        Update_Canvas_Group_Fade_Out_Progress();
    }
}
