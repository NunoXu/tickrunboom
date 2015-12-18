using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cardFlipOther : MonoBehaviour {

    int flag = 0;

    Vector3 card1;
    Vector3 card2;
    Vector3 card3;
    Vector3 card4;
    Vector3 card5;
    Vector3 card6;
    Vector3 card7;
    Vector3 card8;
    Vector3 card9;

    public Sprite[] cardSprites;
    public Button myBtn;


    // Use this for initialization
    void Start () {
        card1 = GameObject.Find("card_1").transform.position;
        card2 = GameObject.Find("card_2").transform.position;
        card3 = GameObject.Find("card_3").transform.position;
        card4 = GameObject.Find("card_4").transform.position;
        card5 = GameObject.Find("card_5").transform.position;
        card6 = GameObject.Find("card_6").transform.position;
        card7 = GameObject.Find("card_7").transform.position;
        card8 = GameObject.Find("card_8").transform.position;
        card9 = GameObject.Find("card_9").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void flipOther()
    {
        if (flag == 1)
        {
            flag = 0;
            myBtn.image.sprite = cardSprites[0];

        }
        else
        {
            flag = 1;
            myBtn.image.sprite = cardSprites[1];
        }
    }
}
