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
    class CustomNetworkManager : NetworkManager
    {
        private ServerGameManager gameManager;
        
        public override void OnServerSceneChanged(string sceneName)
        {
            base.OnServerSceneChanged(sceneName);
            if (sceneName == onlineScene)
            {
                gameManager = GameObject.FindGameObjectWithTag("ServerGameManager").GetComponent<ServerGameManager>();
            }
        }
       
        public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
        {
            //base.OnServerAddPlayer(conn, playerControllerId);
            
            GameObject player = Instantiate(playerPrefab);
            Player playercomp = player.GetComponent<Player>();
            NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
            if (gameManager != null)
                gameManager.RegisterPlayer(playercomp);

            
        }

        

        public override void OnClientConnect(NetworkConnection conn)
        {
            if (string.IsNullOrEmpty(onlineScene) || (onlineScene == offlineScene))
            {
                ClientScene.Ready(conn);
                ClientScene.AddPlayer(conn, 0);
            }
            else
            {
                // player will be added when on-line scene finishes loading
            }
        }

        public override void OnClientSceneChanged(NetworkConnection conn)
        {
            // always become ready.
            ClientScene.Ready(conn);

           

            bool addPlayer = false;
            if (ClientScene.localPlayers.Count == 0)
            {
                // no players exist
                addPlayer = true;
            }

            bool foundPlayer = false;
            foreach (var playerController in ClientScene.localPlayers)
            {
                if (playerController.gameObject != null)
                {
                    foundPlayer = true;
                    break;
                }
            }
            if (!foundPlayer)
            {
                // there are players, but their game objects have all been deleted
                addPlayer = true;
            }
            if (addPlayer)
            {
                ClientScene.AddPlayer(conn, 0);
            }
        }
        
       
    }
}
