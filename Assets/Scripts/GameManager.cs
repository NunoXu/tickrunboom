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
        public PlayContainer PlayContainer;
        public string CardMinigameScene;
        public Player ChosenPlayer;
        
        public UIManager UI;
        
        public List<Player> Players = new List<Player>();
        public Player LocalPlayer;

        public bool loading = true;

        public MiniGame CurrentMiniGame;

        public Level CurrentLevel
        {
            get
            {
                return Levels[CurrentLevelIndex].GetComponent<Level>();
            }
        }

        [SyncVar]
        public int CurrentLevelIndex;

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

        [SyncVar]
        public int activePlayerId = 0;


        void Update()
        {
            if (loading)
            {
                if (isClient)
                {
                    if (AllPlayersAssigned())
                    {
                        RegisterPlayers();
                        UI.SetVotingFrames();
                        loading = false;
                    }
                }
            }
            DecreaseTimer();
        }

        public void SendPlay(PlayContainer play)
        {
            if (activePlayerId == LocalPlayer.id)
            {
                LocalPlayer.PlayMinigame(play);
            }
        }

        public void PerformPlay(PlayContainer playObj)
        {
            if (!isClient)
                return;


            RpcPerformPlay(playObj);
        }

        [ClientRpc]
        private void RpcPerformPlay (PlayContainer playObj)
        {
            CurrentMiniGame.PerformPlay(playObj);
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

        private bool AllPlayersAssigned()
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
            RpcCleanLevel();
        }

        [ClientRpc]
        public void RpcCleanLevel()
        {
            UI.SetLevelBackground(true);
            UI.ResetVotingFrames();
            LocalPlayer.Voted = false;
        }

        public void SendLoadMiniGame(string minigameScene)
        {
            if (!isServer)
                return;

            RpcLoadMiniGame(minigameScene);
        }

        [ClientRpc]
        public void RpcLoadMiniGame(string minigameScene)
        {
            UI.SetLevelBackground(false);
            Application.LoadLevelAdditive(minigameScene);
        }

        public void CleanMiniGame()
        {
            if (!isServer)
                return;

            RpcCleanMiniGame();
        }

        [ClientRpc]
        public void RpcCleanMiniGame()
        {
            Destroy(CurrentMiniGame.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("MiniGameContainer"));
            CurrentMiniGame = null;
        }

        public void RegisterMiniGame(MiniGame miniGame)
        {
            CurrentMiniGame = miniGame;
            UI.SetMiniGameOnCanvas(miniGame.gameObject);
        }

        public void SetMiniGamePlayer(int id)
        {
            RpcSetMiniGamePlayer(id);
        }

        [ClientRpc]
        public void RpcSetMiniGamePlayer(int id)
        {
            if (!isClient)
                return;

            activePlayerId = id;
        }

        
        public void DisableVoteFrames()
        {
            RpcDisableVoteFrames();
        }

        [ClientRpc]
        public void RpcDisableVoteFrames()
        {
            UI.LockVoteFrames();
        }

        public void EnableVoteFrames()
        {
            RpcEnableVoteFrames();
        }

        [ClientRpc]
        public void RpcEnableVoteFrames()
        {

            UI.UnlockVoteFrames();
        }

        public void SetVoteFramesInSelection(int playerId)
        {
            RpcSetVoteFramesInSelection(playerId);
        }

        [ClientRpc]
        public void RpcSetVoteFramesInSelection(int Playerid)
        {
            if (LocalPlayer.id == Playerid)
                UI.SetVoteFramesInSelection();
        }
        
    }
}
  