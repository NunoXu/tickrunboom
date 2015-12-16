using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Move : MonoBehaviour {

    string flagPos = "stop";

    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update()
    {

        Vector3 box1 = GameObject.Find("whiteBox").transform.position;
        Vector3 box2 = GameObject.Find("whiteBox_1").transform.position;
        Vector3 box3 = GameObject.Find("whiteBox_2").transform.position;
        Vector3 box4 = GameObject.Find("whiteBox_3").transform.position;
        Vector3 box5 = GameObject.Find("whiteBox_4").transform.position;
        Vector3 box6 = GameObject.Find("whiteBox_5").transform.position;
        Vector3 box7 = GameObject.Find("whiteBox_6").transform.position;
        Vector3 box8 = GameObject.Find("whiteBox_7").transform.position;
        Vector3 box9 = GameObject.Find("whiteBox_8").transform.position;
        Vector3 box10 = GameObject.Find("whiteBox_9").transform.position;

        Vector3 blackbox1 = GameObject.Find("blackBox").transform.position;
        Vector3 blackbox2 = GameObject.Find("blackBox_1").transform.position;
        Vector3 blackbox3 = GameObject.Find("blackBox_2").transform.position;
        Vector3 blackbox4 = GameObject.Find("blackBox_3").transform.position;
        Vector3 blackbox5 = GameObject.Find("blackBox_4").transform.position;
        Vector3 blackbox6 = GameObject.Find("blackBox_5").transform.position;


        if (Input.GetKeyDown(KeyCode.RightArrow))
            flagPos = "right";
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            flagPos = "left";
        if (Input.GetKeyDown(KeyCode.UpArrow))
            flagPos = "up";
        if (Input.GetKeyDown(KeyCode.DownArrow))
            flagPos = "down";

        if(flagPos == "right")
             while (transform.position.x < 4){
                Vector3 newPos = transform.position + new Vector3(2, 0, 0);

                if (newPos == box1)
                    break;
                if (newPos == box2)
                    break;
                if (newPos == box3)
                    break;
                if (newPos == box4)
                    break;
                if (newPos == box5)
                    break;
                if (newPos == box6)
                    break;
                if (newPos == box7)
                    break;
                if (newPos == box8)
                    break;
                if (newPos == box9)
                    break;
                if (newPos == box10)
                    break;
                if (newPos == blackbox1)
                    break;
                if (newPos == blackbox2)
                    break;
                if (newPos == blackbox3)
                    break;
                if (newPos == blackbox4)
                    break;
                if (newPos == blackbox5)
                    break;
                if (newPos == blackbox6)
                    break;

                transform.position = newPos;
            }

        if (flagPos == "left")
            while (transform.position.x > -4)
            {
                Vector3 newPos = transform.position + new Vector3(-2, 0, 0);

                if (newPos == box1)
                    break;
                if (newPos == box2)
                    break;
                if (newPos == box3)
                    break;
                if (newPos == box4)
                    break;
                if (newPos == box5)
                    break;
                if (newPos == box6)
                    break;
                if (newPos == box7)
                    break;
                if (newPos == box8)
                    break;
                if (newPos == box9)
                    break;
                if (newPos == box10)
                    break;
                if (newPos == blackbox1)
                    break;
                if (newPos == blackbox2)
                    break;
                if (newPos == blackbox3)
                    break;
                if (newPos == blackbox4)
                    break;
                if (newPos == blackbox5)
                    break;
                if (newPos == blackbox6)
                    break;

                transform.position = newPos;
            }

        if (flagPos == "up")
            while (transform.position.y < 4)
            {
                Vector3 newPos = transform.position + new Vector3(0, 2, 0);
                if (newPos == box1)
                    break;
                if (newPos == box2)
                    break;
                if (newPos == box3)
                    break;
                if (newPos == box4)
                    break;
                if (newPos == box5)
                    break;
                if (newPos == box6)
                    break;
                if (newPos == box7)
                    break;
                if (newPos == box8)
                    break;
                if (newPos == box9)
                    break;
                if (newPos == box10)
                    break;
                if (newPos == blackbox1)
                    break;
                if (newPos == blackbox2)
                    break;
                if (newPos == blackbox3)
                    break;
                if (newPos == blackbox4)
                    break;
                if (newPos == blackbox5)
                    break;
                if (newPos == blackbox6)
                    break;
                transform.position = newPos;
            }

        if (flagPos == "down")
            while (transform.position.y > -4)
            {
                Vector3 newPos = transform.position + new Vector3(0, -2, 0);
                if (newPos == box1)
                    break;
                if (newPos == box2)
                    break;
                if (newPos == box3)
                    break;
                if (newPos == box4)
                    break;
                if (newPos == box5)
                    break;
                if (newPos == box6)
                    break;
                if (newPos == box7)
                    break;
                if (newPos == box8)
                    break;
                if (newPos == box9)
                    break;
                if (newPos == box10)
                    break;
                if (newPos == blackbox1)
                    break;
                if (newPos == blackbox2)
                    break;
                if (newPos == blackbox3)
                    break;
                if (newPos == blackbox4)
                    break;
                if (newPos == blackbox5)
                    break;
                if (newPos == blackbox6)
                    break;
                transform.position = newPos;
            }
    }
}
