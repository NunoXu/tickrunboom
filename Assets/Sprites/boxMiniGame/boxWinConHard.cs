using UnityEngine;
using System.Collections;

public class boxWinConHard : MonoBehaviour {
    public GameObject blackbox1;
    public GameObject blackbox2;
    public GameObject blackbox3;
    public GameObject blackbox4;
    public GameObject blackbox5;
    public GameObject blackbox6;
    public UnityEngine.UI.Text text;
    public ParticleSystem part;
    public bool winner;
    // Use this for initialization
    void Start () {
        winner = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*Debug.Log(blackbox1.GetComponent<Move>().wincon.ToString() +
                blackbox2.GetComponent<Move>().wincon.ToString() +
                blackbox3.GetComponent<Move>().wincon.ToString() +
                blackbox4.GetComponent<Move>().wincon.ToString() +
                blackbox5.GetComponent<Move>().wincon.ToString() +
                blackbox6.GetComponent<Move>().wincon.ToString());*/

          if (  blackbox1.GetComponent<MoveHard>().wincon == true &&
                blackbox2.GetComponent<MoveHard>().wincon == true &&
                blackbox3.GetComponent<MoveHard>().wincon == true &&
                blackbox4.GetComponent<MoveHard>().wincon == true &&
                blackbox5.GetComponent<MoveHard>().wincon == true &&
                blackbox6.GetComponent<MoveHard>().wincon == true)
        {
            if (text != null)
                text.text = "SUCCESS!";
            if (part != null)
                part.enableEmission = true;
            winner = true;

        }
    }
}
