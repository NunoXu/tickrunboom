using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
    Text timer;
    float timeLeft = 30.0f;
    // Use this for initialization

    public float getTimeLeft()
    {
        return timeLeft;
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        int resultTime;
       timer = GetComponent<Text>();  
            if (timeLeft < 0)           
                timeLeft = 0;
            else
                timeLeft -= Time.deltaTime;
        resultTime = Mathf.CeilToInt(timeLeft);
        if (resultTime == 60)
        {
            timer.text = "1:00";
        }
        else if (resultTime < 60 && resultTime > 9)
        {
            timer.text = "0:" + resultTime.ToString();
        }
        else
        {
            timer.text = "0:0" + resultTime.ToString();
        }
    }
}

