using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class Move : MonoBehaviour {

    public string flagPos = "stop";
    Vector3 newPos;
    // Use this for initialization

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;
    public GameObject box7;
    public GameObject box8;
    public GameObject box9;
    public GameObject box10;

    public GameObject blackbox1;
    public GameObject blackbox2;
    public GameObject blackbox3;
    public GameObject blackbox4;
    public GameObject blackbox5;
    // public GameObject blackbox6;

    public bool wincon;
    public Text text;
    public ParticleSystem part;
    static int canCheck;


    void Start () {
        wincon = false;
    }

    // Update is called once per frame
    void Update()
    {
        winCon();
        GameObject g = GetComponent<GameObject>();



        if (Input.GetKeyDown(KeyCode.RightArrow))
            flagPos = "right";
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            flagPos = "left";
        if (Input.GetKeyDown(KeyCode.UpArrow))
            flagPos = "up";
        if (Input.GetKeyDown(KeyCode.DownArrow))
            flagPos = "down";

        if(flagPos != "stop" && text.GetComponent<boxWinCon>().winner == false)
        {
        
            newPos = transform.position + new Vector3((float)0.75, 0, 0);
            switch (flagPos)
            {
                case "right":                    
                   // Debug.Log("current: "+transform.position+"new pos: "+newPos + "current f: " + box1.transform.position);                   
                    if (colisao(newPos))
                    transform.position = newPos;
                    break;
                case "left":
                    newPos = transform.position + new Vector3((float)-0.75, 0, 0);
                    if (colisao(newPos))
                    transform.position = newPos;
                    break;
                case "up":
                    newPos = transform.position + new Vector3(0,(float)0.75, 0);
                   if (colisao(newPos))
                        transform.position = newPos;
                    break;
                case "down":
                    newPos = transform.position + new Vector3(0,(float)-0.75, 0);
                    if (colisao(newPos))
                        transform.position = newPos;
                    break;
            }
            if (colisao(newPos) && transform.position == newPos)
            {
                winCon();
                flagPos = "stop";
            }              
            }       
    }


    public bool colisao(Vector3 pos)
    {
        if (box1 == null)
            return false;


        if (Mathf.Approximately(newPos.x, box1.transform.position.x) && Mathf.Approximately(newPos.y, box1.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box2.transform.position.x) && Mathf.Approximately(newPos.y, box2.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box3.transform.position.x) && Mathf.Approximately(newPos.y, box3.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box4.transform.position.x) && Mathf.Approximately(newPos.y, box4.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box5.transform.position.x) && Mathf.Approximately(newPos.y, box5.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box6.transform.position.x) && Mathf.Approximately(newPos.y, box6.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box7.transform.position.x) && Mathf.Approximately(newPos.y, box7.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box8.transform.position.x) && Mathf.Approximately(newPos.y, box8.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box9.transform.position.x) && Mathf.Approximately(newPos.y, box9.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, box10.transform.position.x) && Mathf.Approximately(newPos.y, box10.transform.position.y))
            return false;
        //black

        if (Mathf.Approximately(newPos.x, blackbox1.transform.position.x) && Mathf.Approximately(newPos.y, blackbox1.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, blackbox2.transform.position.x) && Mathf.Approximately(newPos.y, blackbox2.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, blackbox3.transform.position.x) && Mathf.Approximately(newPos.y, blackbox3.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, blackbox4.transform.position.x) && Mathf.Approximately(newPos.y, blackbox4.transform.position.y))
            return false;
        if (Mathf.Approximately(newPos.x, blackbox5.transform.position.x) && Mathf.Approximately(newPos.y, blackbox5.transform.position.y))
            return false;


        //out of bounds
        if (pos.x > 1.5 || pos.x < -1.5 || pos.y > 1.5 || pos.y < -1.5)
            return false;

        return true;
    }


    public void winCon()
    {
        if (transform.position.x != 0 &&
            blackbox1.transform.position.x != 0 &&
            blackbox2.transform.position.x != 0 &&
            blackbox3.transform.position.x != 0 &&
            blackbox4.transform.position.x != 0 &&
            blackbox5.transform.position.x != 0)
        {
   
            wincon = true;
        }
        else { wincon = false; }
            

    }
}



