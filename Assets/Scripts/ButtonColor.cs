using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class ButtonColor : MonoBehaviour {

    float timeLeft;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        GameObject t = GameObject.Find("Time");
        timeLeft = t.GetComponent<Timer>().getTimeLeft();

        Button b = GetComponent<Button>();
        Debug.Log(timeLeft.ToString(), b);

        if (timeLeft < 0)
        {
            
            if (b.image.color == Color.green)
            {
                b.image.color = Color.red;
            }
        }
	}
}
