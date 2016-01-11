using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class ButtonVisibility: MonoBehaviour
{
  
    public Button myBtn;
    public Button myBtn2;
    float found;
    public Sprite sprite1;
    public Sprite sprite2;
    bool isWon;
   static int toWin;

    // Use this for initialization
    void Start()
    {
        found = 0;
        toWin = 3;
        isWon = false;

    }

    // Update is called once per frame
    void Update()
    {
        Button b = GetComponent<Button>();

        if (toWin < 0)
        {
            isWon = true;
        } else {

            if (found == 0)
            {
                b.image.sprite = sprite1;
                myBtn2.image.sprite = sprite1;
            }
            else
            {

                b.image.sprite = sprite2;
                myBtn2.image.sprite = sprite2;
               

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
