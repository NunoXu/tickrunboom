using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
    Text timer;
    float timeLeft = 60.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       timer = GetComponent<Text>();  
            if (timeLeft < 1)           
                timeLeft = 0;
            else
                timeLeft -= Time.deltaTime;
        timer.text = timeLeft.ToString();
    }
}

