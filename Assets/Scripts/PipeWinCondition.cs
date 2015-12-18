using UnityEngine;
using System.Collections;

public class PipeWinCondition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (
            (GameObject.Find("Button_12").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_13").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_10").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_10").transform.rotation.eulerAngles.z < 91)) &&
            (GameObject.Find("Button_9").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_6").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_6").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_6").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_7").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_7").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_7").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_8").transform.rotation.eulerAngles.z == 180) &&
            ((GameObject.Find("Button_1").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_11").transform.rotation.eulerAngles.z < 91)) &&
            ((GameObject.Find("Button").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_2").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_3").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_4").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_4").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_4").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_5").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_5").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_5").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_17").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_17").transform.rotation.eulerAngles.z < 91)) &&
            (GameObject.Find("Button_16").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_16").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_15").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_18").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_19").transform.rotation.eulerAngles.z == 0))
        {
            Debug.Log("It's done, Jim.");
        }
    }
}
