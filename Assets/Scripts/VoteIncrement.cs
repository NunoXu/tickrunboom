using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class VoteIncrement : MonoBehaviour {
    int Vote = 0;
    static int HasVoted = 0;
    float timeLeft;
    Text instruction;
    public void UpVote()
    {
        instruction = GetComponent<Text>();
        GameObject t = GameObject.Find("Time");
        timeLeft = t.GetComponent<Timer>().getTimeLeft();
        if (timeLeft > 0)
        {
            if (Vote == 0 && HasVoted == 0)
            {
                instruction.text = (int.Parse(instruction.text) + 1).ToString();
                Vote = 1;
                HasVoted = 1;
            }
            else if (Vote == 1 && HasVoted == 1)
            {
                instruction.text = (int.Parse(instruction.text) - 1).ToString();
                Vote = 0;
                HasVoted = 0;
            }
        }
    }

}

