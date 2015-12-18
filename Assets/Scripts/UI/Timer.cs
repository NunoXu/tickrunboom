using Assets.Scripts;
using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text timer;
    public GameManager gm;

    
    public void OnGUI()
    {
        int resultTime;
        resultTime = Mathf.CeilToInt(gm.timeLeft);
        if (resultTime == 60)
            timer.text = "1:00";
        else if (resultTime < 60 && resultTime > 9)
            timer.text = "0:" + resultTime.ToString();
        else
            timer.text = "0:0" + resultTime.ToString();
    }
}

