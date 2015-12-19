using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using Assets.Scripts;

public class cardScript : NetworkBehaviour
{
    [SyncVar]
    public int flag = 0;

    public Sprite[] cardSprites;
    public Button myBtn;
    public cardScript[] adjacentCards;
    public GameManager gm;
    public MedicMiniGameManager mgm;


    
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
