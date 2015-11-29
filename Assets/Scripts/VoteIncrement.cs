using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class VoteIncrement : MonoBehaviour {
    int Vote = 0;
    Text instruction;
    public void UpVote()
    {
        instruction = GetComponent<Text>();

        if (Vote == 0)
        {
            instruction.text = (int.Parse(instruction.text) + 1).ToString();
            Vote = 1;
        }
        else
        {
            instruction.text = (int.Parse(instruction.text) - 1).ToString();
            Vote = 0;
        }
    }

}

