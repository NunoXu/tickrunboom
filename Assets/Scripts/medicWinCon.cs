using UnityEngine;
using System.Collections;

public class medicWinCon : MonoBehaviour {

    
    public object textbox;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (GameObject.Find("card_1").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_2").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_3").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_4").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_5").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_6").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_7").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_8").GetComponent<cardScript>().flag == 0 &&
            GameObject.Find("card_9").GetComponent<cardScript>().flag == 0)
        {
            textbox = "win";
        }
    }
}
