using UnityEngine;
using System.Collections;

public class PipeHardWinCondition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (
            (GameObject.Find("Button_9").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_12 (1)").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_12 (1)").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_12 (1)").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_9 (1)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_12 (7)").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12 (7)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_9 (12)").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_12 (21)").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_12 (21)").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_12 (21)").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_9 (13)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_12 (22)").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12 (22)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_9 (24)").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_9 (25)").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_9 (25)").transform.rotation.eulerAngles.z < 91)) &&

            (GameObject.Find("Button_9 (20)").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_9 (21)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_12 (14)").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12 (14)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_9 (30)").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_9 (31)").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_9 (31)").transform.rotation.eulerAngles.z < 91)) &&
            (GameObject.Find("Button_12 (15)").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12 (15)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_12 (12)").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12 (12)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_9 (16)").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_9 (15)").transform.rotation.eulerAngles.z == 0) &&
            (GameObject.Find("Button_9 (10)").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_12 (9)").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_12 (9)").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_12 (9)").transform.rotation.eulerAngles.z == 270))
        {
            Debug.Log("It's done, Jim.");
        }

    }
}
