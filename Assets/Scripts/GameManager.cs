using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets.Scripts.UI;
using Assets.Scripts.Traits;
using UnityEngine.Networking;
using System;
using Assets.Scripts.Rooms;
using Assets.Scripts.Chat;

namespace Assets.Scripts
{
    public class GameManager : NetworkBehaviour {

        public GameObject VotesPanel;
        public TraitIcons TraitIcons;
        public NetworkManager networkManager;
        public List<Level> Levels;
        public List<GameObject> PlayerTraits;
        public ChatInputBox ChatInput;

        [SyncVar]
        public int CurrentLevelIndex;
        

        public UIManager UI;
        
        public List<Player> Players = new List<Player>();
        public Player LocalPlayer;

        public bool loading = true;


        [SyncVar]
        public bool minigameUnderway = true;

        [SyncVar]
        public float timeLeft = 30.0f;

        [SyncVar]
        public bool Started = false;

        [SyncVar]
        public bool WaitingForPlayers = true;

        [SyncVar]
        public int playerNumber;

        [SyncVar]
        public int currentPlayers = 0;
       
        
        void Update()
        {
            if (loading)
            {
                if (isClient)
                {
                    if (allPlayersAssigned())
                    {
                        RegisterPlayers();
                        UI.SetVotingFrames();
                        loading = false;
                    }
                }
            }
            DecreaseTimer();
        }

        private void DecreaseTimer()
        {
            if (!isServer) //Only server should update
                return;

            if (!Started)
                return;


            if (timeLeft < 0)
                timeLeft = 0;
            else
                timeLeft -= Time.deltaTime;
        }

        public void StartTimer()
        {
            Started = true;
        }

        [Client]
        private void RegisterPlayers()
        {
            if (!isClient)
                return;

            IEnumerable<GameObject> players = GameObject.FindGameObjectsWithTag("Player");

            foreach (GameObject p in players)
            {
                var pl = p.GetComponent<Player>();
                if (pl.isLocalPlayer)
                    LocalPlayer = pl;
                else
                    Players.Add(pl);
            }
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

        private bool allPlayersAssigned()
        {
            if (currentPlayers < playerNumber)
                return false;

            IEnumerable<GameObject> players = GameObject.FindGameObjectsWithTag("Player");

            foreach (GameObject p in players)
            {
                var pl = p.GetComponent<Player>();
                if (pl.trait == null)
                    return false;
            }
            return true;
        }

        public Player GetPlayerById(int id)
        {
            if (LocalPlayer.id == id)
                return LocalPlayer;
            foreach (Player p in Players)
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void LoadNextLevel(float TimePerLevel, int levelIndex)
        {
            CurrentLevelIndex = levelIndex;
            timeLeft = TimePerLevel;
        }

        public Player GetChosenPlayer()
        {
            int maxVotes = LocalPlayer.Votes;
            Player chosenPlayer = LocalPlayer;

            foreach (Player p in Players)
            {
                if (p.Votes > maxVotes)
                {
                    chosenPlayer = p;
                    maxVotes = p.Votes;
                }
            }

            return chosenPlayer;
        }
    }
}
