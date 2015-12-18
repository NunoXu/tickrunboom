using Assets.Scripts.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UIManager : NetworkBehaviour
    {
        public GameObject LocalPlayerVotePanel;
        public GameObject PlayersVotePanel;
        public GameObject VotingFrame;
        public GameManager GM;
        public Timer Timer;

        public GameObject MinigamePanel;
        public GameObject PuzzlePanel;


        public Text LevelText;
        public Image LevelBackground;

        private List<VoteFrame> votingFrames = new List<VoteFrame>();
        

        public void SetVotingFrames()
        {
            IEnumerable<Player> players = GM.Players;


            LocalPlayerVotePanel.GetComponent<VoteFrame>().RegisterPlayer(GM.LocalPlayer, GM.LocalPlayer);
            LocalPlayerVotePanel.SetActive(true);


            foreach (Player p in players)
            {  
                GameObject frame = Instantiate(VotingFrame);
                frame.GetComponent<VoteFrame>().RegisterPlayer(p, GM.LocalPlayer);
                votingFrames.Add(frame.GetComponent<VoteFrame>());

                frame.transform.SetParent(PlayersVotePanel.transform, false);
                frame.transform.SetAsFirstSibling();
            }
        }
        

        void OnGUI()
        {
            LevelText.text = GM.Levels[GM.CurrentLevelIndex].LevelText.text;
            LevelBackground.sprite = GM.Levels[GM.CurrentLevelIndex].LevelBackground;
        }

        [ClientRpc]
        public void RpcResetVotingFrames()
        {
            LocalPlayerVotePanel.GetComponent<VoteFrame>().Reset();
            foreach (VoteFrame vf in votingFrames)
            {
                vf.Reset();
            }
        }

        public void SetLevelBackground(bool enabled)
        {
            LevelBackground.enabled = enabled;
        }
    }
}
