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
        public float TimePerLevel = 60f;
        private const float TIME_PER_MINIGAME = 30f;
        private const float TIME_PER_WAIT= 5f;
        public string DemoEndScene;
        private bool WaitTime = false;
        private bool BeginTime = true;

        public static int playerNumber;
        public int currentPlayers = 0;

        private bool MinigameTime = false;
        private Player MinigamePlayer;
        private MiniGame CurrentMinigame;

        public int currentLevel = 0;
        private int[] levelOrder;
        private int currentLevelInOrder = 0;
        private bool HardLevel = false;
        private bool JokerLevel = false;
        private Player ChosenPlayer;


        private bool GameOver = false;

        public override void OnStartServer()
        {
            GameManager.playerNumber = playerNumber;
            var levelenum = Enumerable.Range(0, GameManager.Levels.Count);
            levelOrder = levelenum.OrderBy(x => UnityEngine.Random.value).ToArray();
            
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
            if (GameOver)
                return;


            if (GameManager.timeLeft <= 0)
            {
                if (BeginTime)
                {
                    BeginTime = false;
                    GameManager.timeLeft = TimePerLevel;
                    return;
                }

                if (!MinigameTime)
                {

                    if (!WaitTime)
                    {
                        MinigamePlayer = GetChosenPlayer();
                        GameManager.ChatInput.SendSpecificMessage("Player " + MinigamePlayer.NickName + " was chosen.", Color.red);
                        WaitTime = true;
                        GameManager.timeLeft = TIME_PER_WAIT;
                        return;
                    }
                    if (WaitTime)
                    {
                        LaunchMiniGame();
                        WaitTime = false;
                    }
                } else
                {
                    PlayerOutOfTime();
                }
            }
           

            if(MinigameTime && CurrentMinigame && CurrentMinigame.IsWon())
            {
                GameManager.ChatInput.SendSpecificMessage("Player " + MinigamePlayer.NickName + " has won the challenge!.", Color.red);
                CleanMinigame();
                
                ResetLevel();
                MinigameTime = false;
            }
        }

        void LaunchCardGame()
        {

           //TODO

        }

        void LaunchMiniGame()
        {
            GameManager.DisableVoteFrames();
            if (MinigamePlayer.trait == GameManager.CurrentLevel.SolvingTrait)
            {
                LoadMinigame(GameManager.CurrentLevel.EasyMiniGamScene);
                HardLevel = false;
            }
            else
            {
                LoadMinigame(GameManager.CurrentLevel.HardMiniGameScene);
                HardLevel = true;
            }
            GameManager.ChatInput.SendSpecificMessage("You have got " + TIME_PER_MINIGAME + " seconds.", Color.red);
            GameManager.timeLeft = TIME_PER_MINIGAME;
            MinigameTime = true;
        }

        void PlayerOutOfTime()
        {
            MinigamePlayer.Dead = true;
            GameManager.ChatInput.SendSpecificMessage("Player " + MinigamePlayer.NickName + " didn't make it in time.", Color.red);
            CleanMinigame();
            MinigameTime = false;
            ResetLevel();
        }



        void ResetLevel()
        {
            if (currentLevelInOrder >= levelOrder.Length)
            { 
                //DemoOver
                GameOver = true;
                GameManager.UI.RpcGameOver();
                return;
            }
            GameManager.EnableVoteFrames();
            var level = GetNextLevel();
            GameManager.LoadNextLevel(TimePerLevel, level);
            foreach (Player p in Players)
            {
                p.Reset();
            }
        }

        void CleanMinigame()
        {
            GameManager.CleanMiniGame();
            CurrentMinigame = null;
        }

        public int GetNextLevel()
        {
            return levelOrder[currentLevelInOrder++];
        }

        public Player GetChosenPlayer()
        {
            int maxVotes = Players[0].Votes;
            Player chosenPlayer = Players[0];

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

        private void LoadMinigame(string minigame)
        {
            GameManager.SendLoadMiniGame(minigame);

        }

        public void RegisterMiniGame(MiniGame miniGame)
        {
            if (!isServer)
                return;

            var chosenPlayerId = GetChosenPlayer().id;
            CurrentMinigame = miniGame;

            GameManager.SetMiniGamePlayer(chosenPlayerId);

        }
        
    }
}
