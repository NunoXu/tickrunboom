using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class VoteButtonColor : MonoBehaviour {
    int color = 0;
    public void ButtonPressed()
    {
        
       Button b = GetComponent<Button>();
        if (color==0)
        {
            b.image.color = Color.green;
            color = 1;
        }
        else {
            color = 0;
            b.image.color = Color.white;
        }
    }
	
}
