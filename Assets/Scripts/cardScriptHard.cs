using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections;


public class cardScriptHard : MonoBehaviour
{
    public int flag = 0;

    Vector3 card1;
    Vector3 card2;
    Vector3 card3;
    Vector3 card4;
    Vector3 card5;
    Vector3 card6;
    Vector3 card7;
    Vector3 card8;
    Vector3 card9;
    Vector3 card10;
    Vector3 card11;
    Vector3 card12;

    public Sprite[] cardSprites;
    public Button myBtn;


    // Use this for initialization
    void Start()
    {
         card1 = GameObject.Find("card_1").transform.position;
         card2 = GameObject.Find("card_2").transform.position;
         card3 = GameObject.Find("card_3").transform.position;
         card4 = GameObject.Find("card_4").transform.position;
         card5 = GameObject.Find("card_5").transform.position;
         card6 = GameObject.Find("card_6").transform.position;
         card7 = GameObject.Find("card_7").transform.position;
         card8 = GameObject.Find("card_8").transform.position;
         card9 = GameObject.Find("card_9").transform.position;
         card10 = GameObject.Find("card_10").transform.position;
         card11 = GameObject.Find("card_11").transform.position;
         card12 = GameObject.Find("card_12").transform.position;

        if (this.gameObject.transform.position == card2 ||
             this.gameObject.transform.position == card4 ||
             this.gameObject.transform.position == card6 ||
             this.gameObject.transform.position == card8 ||
             this.gameObject.transform.position == card10 ||
             this.gameObject.transform.position == card12)
        {
             flag = 1;
             myBtn.image.sprite = cardSprites[1];
        }
        else
        {
            flag = 0;
            myBtn.image.sprite = cardSprites[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("card_1").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_2").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_3").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_4").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_5").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_6").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_7").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_8").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_9").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_10").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_11").GetComponent<cardScriptHard>().flag == 1 ||
            GameObject.Find("card_12").GetComponent<cardScriptHard>().flag == 1) {
            //win con here
        }
    }

    public void flip()
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
        //card 1
        if (this.gameObject.transform.position == card1)
        {
            Button temp = GameObject.Find("card_2").GetComponent<Button>();
            if (GameObject.Find("card_2").GetComponent<cardScriptHard>().flag == 0){
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_2").GetComponent<cardScriptHard>().flag = 1;
            }else{
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_2").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_4").GetComponent<Button>();
            if (GameObject.Find("card_4").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_4").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_4").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 2
        if (this.gameObject.transform.position == card2)
        {
            Button temp = GameObject.Find("card_1").GetComponent<Button>();
            if (GameObject.Find("card_1").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_1").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_1").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_3").GetComponent<Button>();
            if (GameObject.Find("card_3").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_3").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_3").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_5").GetComponent<Button>();
            if (GameObject.Find("card_5").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 3
        if (this.gameObject.transform.position == card3)
        {
            Button temp = GameObject.Find("card_2").GetComponent<Button>();
            if (GameObject.Find("card_2").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_2").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_2").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_6").GetComponent<Button>();
            if (GameObject.Find("card_6").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_10").GetComponent<Button>();
            if (GameObject.Find("card_10").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_10").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_10").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 4
        if (this.gameObject.transform.position == card4)
            {
            Button temp = GameObject.Find("card_1").GetComponent<Button>();
            if (GameObject.Find("card_1").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_1").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_1").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_5").GetComponent<Button>();
            if (GameObject.Find("card_5").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_7").GetComponent<Button>();
            if (GameObject.Find("card_7").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_7").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_7").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 5
        if (this.gameObject.transform.position == card5)
        {
            Button temp = GameObject.Find("card_2").GetComponent<Button>();
            if (GameObject.Find("card_2").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_2").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_2").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_4").GetComponent<Button>();
            if (GameObject.Find("card_4").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_4").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_4").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_6").GetComponent<Button>();
            if (GameObject.Find("card_6").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_8").GetComponent<Button>();
            if (GameObject.Find("card_8").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_8").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_8").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 6
        if (this.gameObject.transform.position == card6)
        {
            Button temp = GameObject.Find("card_3").GetComponent<Button>();
            if (GameObject.Find("card_3").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_3").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_3").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_5").GetComponent<Button>();
            if (GameObject.Find("card_5").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_9").GetComponent<Button>();
            if (GameObject.Find("card_9").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_9").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_9").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_11").GetComponent<Button>();
            if (GameObject.Find("card_11").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_11").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_11").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 7
        if (this.gameObject.transform.position == card7)
        {
            Button temp = GameObject.Find("card_4").GetComponent<Button>();
            if (GameObject.Find("card_4").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_4").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_4").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_8").GetComponent<Button>();
            if (GameObject.Find("card_8").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_8").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_8").GetComponent<cardScriptHard>().flag = 0;
            }          
        }
        //card 8
        if (this.gameObject.transform.position == card8)
        {
            Button temp = GameObject.Find("card_7").GetComponent<Button>();
            if (GameObject.Find("card_7").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_7").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_7").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_5").GetComponent<Button>();
            if (GameObject.Find("card_5").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_5").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_9").GetComponent<Button>();
            if (GameObject.Find("card_9").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_9").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_9").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 9
        if (this.gameObject.transform.position == card9)
        {
            Button temp = GameObject.Find("card_8").GetComponent<Button>();
            if (GameObject.Find("card_8").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_8").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_8").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_6").GetComponent<Button>();
            if (GameObject.Find("card_6").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_12").GetComponent<Button>();
            if (GameObject.Find("card_12").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_12").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_12").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 10
        if (this.gameObject.transform.position == card10)
        {
            Button temp = GameObject.Find("card_3").GetComponent<Button>();
            if (GameObject.Find("card_3").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_3").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_3").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_11").GetComponent<Button>();
            if (GameObject.Find("card_11").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_11").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_11").GetComponent<cardScriptHard>().flag = 0;
            }      
        }
        //card 11
        if (this.gameObject.transform.position == card11)
        {
            Button temp = GameObject.Find("card_10").GetComponent<Button>();
            if (GameObject.Find("card_10").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_10").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_10").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_12").GetComponent<Button>();
            if (GameObject.Find("card_12").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_12").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_12").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_6").GetComponent<Button>();
            if (GameObject.Find("card_6").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_6").GetComponent<cardScriptHard>().flag = 0;
            }
        }
        //card 12
        if (this.gameObject.transform.position == card12)
        {
            Button temp = GameObject.Find("card_11").GetComponent<Button>();
            if (GameObject.Find("card_11").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_11").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_11").GetComponent<cardScriptHard>().flag = 0;
            }
            temp = GameObject.Find("card_9").GetComponent<Button>();
            if (GameObject.Find("card_9").GetComponent<cardScriptHard>().flag == 0)
            {
                temp.image.sprite = cardSprites[1];
                GameObject.Find("card_9").GetComponent<cardScriptHard>().flag = 1;
            }
            else {
                temp.image.sprite = cardSprites[0];
                GameObject.Find("card_9").GetComponent<cardScriptHard>().flag = 0;
            }
        }
    }

  
}
