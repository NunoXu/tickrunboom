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
        public bool Locked;
        public bool InSelection = false;

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
            if (player.Dead || localPlayer.Dead || Locked)
                return;

            if (InSelection)
            {
                localPlayer.SelectPlayer(player.id);
                Voted = true;
            }

            if (!Voted)
            {
                if (localPlayer.Voted)
                {
                    return;
                }
                    
                localPlayer.CmdUpVote(player.id);
                Voted = true;
                localPlayer.Voted = true;
            } else
            {
                localPlayer.CmdDownVote(player.id);
                Voted = false;
                localPlayer.Voted = false;
            }
        }

        void OnGUI()
        {
            if (player != null)
            {
                VoteText.text = player.Votes.ToString();
                if (player.Dead)
                    ButtonImage.color = Color.grey;
                else if (Voted)
                    ButtonImage.color = Color.red;
                else
                    ButtonImage.color = Color.white;
            }
        }

        public void Reset()
        {
            Voted = false;
        }

        public void Lock()
        {
            Locked = true;
        }

        public void UnLock()
        {
            Locked = false;
        }

    }
}
