using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pipeScript : MonoBehaviour {
    public Button myBtn;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void onClick()
    {
        transform.Rotate(0, 0, 90);

    }
}
