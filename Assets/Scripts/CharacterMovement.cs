﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    float timeLeft;
    float animTime = 5.0f;
    int initMove = 0;
    int hasMoved = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (hasMoved == 0)
        {
            GameObject t = GameObject.Find("Time");
            timeLeft = t.GetComponent<Timer>().getTimeLeft();

            if (timeLeft <= 0)
            {
                finalAnimation();
                
            }

            
        }
    }

    void finalAnimation()
    {
        if (animTime < 0.0f)
        {
            animTime = 0.0f;
        }
        else
        {
            animTime -= Time.deltaTime;
        }

        if(animTime < 4.0f && animTime > 0.0f && initMove == 0)
        {
            transform.Translate(4, 0, 0);
            initMove = 1;
        }
        else if(animTime <= 0.0f)
        {
            
            GameObject t = GameObject.Find("Text 3");
            Text instruction = t.GetComponent<Text>();

            int rightVote = int.Parse(instruction.text);
            if (rightVote == 1)
            {
                transform.Translate(6, 0, 0);
                transform.Rotate(0.0f, 180.0f, 0.0f);
            }
            else
            {
               transform.Translate(4, -3, 0);
                transform.Rotate(0.0f, 0.0f, 90.0f);
                
            }
            hasMoved = 1;
        }

    }
}