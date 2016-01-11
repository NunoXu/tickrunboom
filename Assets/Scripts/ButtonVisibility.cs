using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class ButtonVisibility: MonoBehaviour
{
  
    public Button myBtn;
    public Button myBtn2;
    public Text myScore;
    float found;
    public Sprite sprite1;
    public Sprite sprite2;
    bool isWon;
    static int toWin;
    int score;

    // Use this for initialization
    void Start()
    {
        found = 0;
        toWin = 3;
        isWon = false;
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(myScore != null )
        {
            if(toWin > 0)
                 myScore.text = ("Differences Found: " + (3 - toWin)).ToString();
            else
                myScore.text = ("Task Complete!").ToString();

        }
           


        if(myBtn != null && myBtn2 != null) { 
       // Button b = GetComponent<Button>();
        if (toWin < 0)
        {
            isWon = true;
        } else {
            if (found == 0)
            {
                myBtn.image.sprite = sprite1;
                myBtn2.image.sprite = sprite1;
            }
            else
            {
                myBtn.image.sprite = sprite2;
                myBtn2.image.sprite = sprite2;
               

            }
         }
        }
    }

    public void onClick()
    {


        if (found == 0 && isWon == false) { 
            found = 1;
        toWin--;
        }


    }
}
