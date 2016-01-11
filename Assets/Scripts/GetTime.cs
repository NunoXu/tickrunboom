using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {

    public GameManager gm;
    public Text txt;
    public bool started;
    void OnGUI()
    {
        if (gm.timeLeft <= 0.5f)
            started = true;
        if (started)
            txt.text = "Started";
        else
            txt.text = gm.timeLeft.ToString();
    }
}
