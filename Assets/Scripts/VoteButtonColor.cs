using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class VoteButtonColor : MonoBehaviour {
    int color = 0;
    static int HasVoted = 0;
    float timeLeft;
    public void ButtonPressed()
    {
        GameObject t = GameObject.Find("Time");
        timeLeft = t.GetComponent<Timer>().getTimeLeft();

        if (timeLeft > 0)
        {
            Button b = GetComponent<Button>();
            if (color == 0 && HasVoted == 0)
            {
                b.image.color = Color.yellow;
                color = 1;
                HasVoted = 1;
            }
            else if (color == 1 && HasVoted == 1)
            {
                color = 0;
                HasVoted = 0;
                b.image.color = Color.white;
            }
        }
    }
	
}
