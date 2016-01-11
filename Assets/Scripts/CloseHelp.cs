using UnityEngine;
using System.Collections;

public class CloseHelp : MonoBehaviour {


    public GameObject[] HelpPannels;

    public void Close()
    {
        foreach (GameObject obj in HelpPannels)
        {
            obj.SetActive(false);
        }
    }
}
