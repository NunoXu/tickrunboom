using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class VoteFrame : MonoBehaviour
    {
        public Timer Timer;
        public Text VoteText;
        public Image ButtonImage;
        public float HasVoted;


        private bool Voted = false;
        private Player localPlayer;
        private Player player;

        public void SetVote(int voteNumber)
        {
            VoteText.text = voteNumber.ToString();
        }

        public void RegisterPlayer(Player player, Player localPlayer)
        {
            this.localPlayer = localPlayer;
            this.player = player;
            ButtonImage.sprite = player.GetTraitImage();
            VoteText.text = player.Votes.ToString();
        }

        public void UpVote()
        {
            if (!Voted)
            {
                localPlayer.CmdUpVote(player.id);
                Voted = true;
                ButtonImage.color = Color.red;
            } else
            {
                localPlayer.CmdDownVote(player.id);
                Voted = false;
                ButtonImage.color = Color.white;
            }
        }

        void OnGUI()
        {
            if (player != null)
                VoteText.text = player.Votes.ToString();
        }
    }
}
