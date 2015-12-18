using Assets.Scripts.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ServerGameManager : NetworkBehaviour
    {
        public List<Player> Players = new List<Player>();
        public List<GameObject> PlayerTraits;
        public GameManager GameManager;
        public float TimePerLevel = 10f;

        public static int playerNumber;
        public int currentPlayers = 0;

        private int currentLevel = 0;
        private int[] levelOrder;

        public override void OnStartServer()
        {
            GameManager.playerNumber = playerNumber;
            var levelenum = Enumerable.Range(0, GameManager.Levels.Count);
            levelOrder = levelenum.OrderBy(x => UnityEngine.Random.value).ToArray();
            
            currentLevel = GetNextLevel();
            GameManager.LoadNextLevel(TimePerLevel, currentLevel);
        }
        

        public GameObject GetNextRandomTrait()
        {
            if (PlayerTraits.Count > 0)
            {
                var randomIndex = Mathf.RoundToInt(UnityEngine.Random.Range(0, PlayerTraits.Count - 1));
                var trait = PlayerTraits[randomIndex];
                PlayerTraits.RemoveAt(randomIndex);
                return trait;
            }
            else
                return null;
        }

        [Server]
        public void RegisterPlayer(Player player)
        {
            if (!isServer)
                return;

            Players.Add(player);
            currentPlayers++;
            GameManager.currentPlayers++;
            if (currentPlayers >= playerNumber)
            {
                int i = 0;
                foreach (Player p in Players)
                {
                    p.RpcReceiveTrait(GetNextRandomTrait(), i++);
                }
                GameManager.StartTimer();
            }
        }

        void Update()
        {
            if (GameManager.timeLeft <= 0)
            {
                Player pl = GameManager.GetChosenPlayer();
                GameManager.ChatInput.SendSpecificMessage("Player " + pl.NickName + " was chosen.", Color.red);
                
                var level = GetNextLevel();
                GameManager.LoadNextLevel(TimePerLevel, level);
            }
        }

        public int GetNextLevel()
        {
            return levelOrder[currentLevel++];
        }
        
    }
}
