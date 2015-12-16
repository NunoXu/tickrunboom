using Assets.Scripts.Chat;
using Assets.Scripts.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Player : NetworkBehaviour
    {
        public string NickName;
        public GameObject MessagePrefab;
        public GameObject chatSpawn;

        public override void OnStartLocalPlayer() {
            NickName = PlayerPrefs.GetString("Nickname", "Anon");
            chatSpawn = GameObject.Find("Chat Box");
            GameObject.Find("Chat Input Box").GetComponent<ChatInputBox>().player = this;
        }

        [SyncVar]
        public int Votes;

        public Trait trait;


        [Command]
        public void CmdVote()
        {
        }

        [Command]
        public void CmdSendMessage(string msg, GameObject chatSpawn)
        {
            
            GameObject clone = Instantiate(MessagePrefab);
            clone.transform.SetParent(chatSpawn.transform, false);
            clone.transform.SetAsFirstSibling();
            clone.GetComponent<ChatMessage>().ShowMessage(this, msg);
            NetworkServer.Spawn(clone);
            RpcSyncOnce(clone, msg, chatSpawn);
            
        }

        [ClientRpc]
        public void RpcSyncOnce(GameObject message, string msg, GameObject parent)
        {
            message.transform.SetParent(parent.transform, false);
            message.transform.SetAsFirstSibling();
            message.GetComponent<ChatMessage>().ShowMessage(this, msg);
        }

        public Sprite GetTraitImage()
        {
            return trait.TraitIcon;
        }

        [Client]
        public void SendMessage(string msg)
        {
            if (!isLocalPlayer) { return; }
            CmdSendMessage(msg, chatSpawn);

        }
        
        

    }
}
