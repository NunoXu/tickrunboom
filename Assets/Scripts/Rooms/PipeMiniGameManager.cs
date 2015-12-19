using UnityEngine;
using System.Collections;
using Assets.Scripts.Rooms;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

namespace Assets.Scripts
{
    public class PipeMiniGameManager : MiniGame
    {

        public GameObject pieces;
        public Image Background;
        
        public override bool IsWon()
        {
            
            return (GameObject.Find("Button_12").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_12").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_13").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_10").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_10").transform.rotation.eulerAngles.z < 91)) &&
            (GameObject.Find("Button_9").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_6").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_6").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_6").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_7").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_7").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_7").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_8").transform.rotation.eulerAngles.z == 180) &&
            ((GameObject.Find("Button_1").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_11").transform.rotation.eulerAngles.z < 91)) &&
            ((GameObject.Find("Button_p").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_p").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_p").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_2").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_3").transform.rotation.eulerAngles.z == 0) &&
            ((GameObject.Find("Button_4").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_4").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_4").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_5").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_5").transform.rotation.eulerAngles.z < 91) || GameObject.Find("Button_5").transform.rotation.eulerAngles.z == 270) &&
            ((GameObject.Find("Button_17").transform.rotation.eulerAngles.z > 89) && (GameObject.Find("Button_17").transform.rotation.eulerAngles.z < 91)) &&
            (GameObject.Find("Button_16").transform.rotation.eulerAngles.z == 0 || GameObject.Find("Button_16").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_15").transform.rotation.eulerAngles.z == 270) &&
            (GameObject.Find("Button_18").transform.rotation.eulerAngles.z == 180) &&
            (GameObject.Find("Button_19").transform.rotation.eulerAngles.z == 0);
        }

        [ClientRpc]
        public override void RpcActivate()
        {
            Background.enabled = true;
            foreach (Image img in pieces.GetComponentsInChildren<Image>())
            {
                img.enabled = true;
            }
            foreach (Button btn in pieces.GetComponentsInChildren<Button>())
            {
                btn.enabled = true;
            }
            foreach (Text txt in pieces.GetComponentsInChildren<Text>())
            {
                txt.enabled = true;
            }
        }

        [ClientRpc]
        public override void RpcDeactivate()
        {
            Background.enabled = false;
            foreach (Image img in pieces.GetComponentsInChildren<Image>())
            {
                img.enabled = false;
            }
            foreach (Button btn in pieces.GetComponentsInChildren<Button>())
            {
                btn.enabled = false;
            }
            foreach (Text txt in pieces.GetComponentsInChildren<Text>())
            {
                txt.enabled = false;
            }
        }
    }
}
