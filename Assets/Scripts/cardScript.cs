using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using Assets.Scripts;

public class cardScript : NetworkBehaviour
{
    [SyncVar]
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

    public Sprite[] cardSprites;
    public Button myBtn;
    public cardScript[] adjacentCards;
    public GameManager gm;
    public MedicMiniGameManager mgm;


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

        if (this.gameObject.transform.position == card2 ||
             this.gameObject.transform.position == card4 ||
             this.gameObject.transform.position == card6 ||
             this.gameObject.transform.position == card8){
             flag = 0;
        }
        else
        {
            flag = 1;
        }

    }

    public void CallCmdFlip()
    {
        if (mgm.activePlayerId != gm.LocalPlayer.id)
            return;

         gm.LocalPlayer.FlipCard(this.gameObject);
    }
    

    public void FlipAdjacent()
    {
        foreach (cardScript card in adjacentCards)
        {
            card.Flip();
        }
    }


    public void Flip()
    {
        if (flag == 1)
        {
            flag = 0;
        }
        else
        {
            flag = 1;
        }
    }

    void OnGUI()
    {
        myBtn.image.sprite = cardSprites[flag];
    }

  
}
