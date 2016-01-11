using Assets.Scripts.Chat;
using Assets.Scripts.Rooms;
using Assets.Scripts.Rooms.MedicMiniGame;
using Assets.Scripts.Rooms.PipeMiniGame;
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

        public int id;
        public string NickName;
        public GameObject MessagePrefab;
        public GameObject chatSpawn;

        private GameManager myGameManager;

        public GameManager gameManager
        {
            get
            {
                if (myGameManager != null)
                    return myGameManager;
                else
                {
                    myGameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    return myGameManager;
                }
            }
            set
            {
                myGameManager = value;
            }
        }

        public override void OnStartLocalPlayer() {
            NickName = Preferences.Nick;
            chatSpawn = GameObject.Find("Chat Box");
            GameObject.Find("Chat Input Box").GetComponent<ChatInputBox>().player = this;
        }

        [SyncVar]
        public int Votes = 0;

        [SyncVar]
        public bool Dead = false;
        
        public bool Voted = false;


        public Trait trait;

        
        [Command]
        public void CmdUpVote(int votedPlayerId)
        {
            gameManager.GetPlayerById(votedPlayerId).Votes++;
        }

        [Command]
        public void CmdDownVote(int votedPlayerId)
        {
            gameManager.GetPlayerById(votedPlayerId).Votes--;
        }

        [Command]
        public void CmdPlayMinigame(PlayContainer playObj)
        {
            gameManager.PerformPlay(playObj);
        }
        
        public void PlayMinigame (PlayContainer playObj)
        {
            CmdPlayMinigame(playObj);
        }


        [Command]
        public void CmdSendMessage(string sender, string senderTrait, string msg, GameObject chatSpawn)
        {
            
            GameObject clone = Instantiate(MessagePrefab);
            clone.transform.SetParent(chatSpawn.transform, false);
            clone.transform.SetAsFirstSibling();
            clone.GetComponent<ChatMessage>().ShowMessage(sender, senderTrait, msg);
            NetworkServer.Spawn(clone);
            RpcSyncOnce(clone, sender, senderTrait, msg, chatSpawn);
            
        }

        [ClientRpc]
        public void RpcSyncOnce(GameObject message, string sender, string senderTrait, string msg, GameObject parent)
        {
            message.transform.SetParent(parent.transform, false);
            message.transform.SetAsFirstSibling();
            message.GetComponent<ChatMessage>().ShowMessage(sender, senderTrait, msg);
        }

        [ClientRpc]
        public void RpcSyncSpecific(GameObject message, string msg, GameObject parent, Color c)
        {
            message.transform.SetParent(parent.transform, false);
            message.transform.SetAsFirstSibling();
            message.GetComponent<ChatMessage>().ShowEndMessage(msg, c);
        }


        [ClientRpc]
        public void RpcReceiveTrait(GameObject trait, int id)
        {
            Debug.Log("Assigned " + trait);
            this.trait = trait.GetComponent<Trait>();
            this.id = id;
        }


        public Sprite GetTraitImage()
        {
            return trait.TraitIcon;
        }

        [Client]
        public void SendChatMessage(string msg)
        {
            if (!isLocalPlayer) { return; }
            CmdSendMessage(NickName, trait.Name, msg, chatSpawn);
        }

        public void Reset()
        {
            Votes = 0;
        }
        
        public void SelectPlayer(int playerId)
        {
            CmdSelectPlayer(playerId);
        }

        [Command]
        public void CmdSelectPlayer (int playerId)
        {
            gameManager.ChosenPlayer = gameManager.Players[playerId];
        }
    }
}
