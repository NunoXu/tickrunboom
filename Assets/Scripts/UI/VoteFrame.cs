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
        public Text VoteText;
        public Image ButtonImage;
        public float HasVoted;
        public List<Sprite> TraitIcons;

        private Player player;

        public void SetVote(int voteNumber)
        {
            VoteText.text = voteNumber.ToString();
        }

        public void RegisterPlayer(Player player)
        {
            this.player = player;
            ButtonImage.sprite = player.GetTraitImage();
            VoteText.text = player.Votes.ToString();
        }

        public void UpVote()
        {
            
        }
    }
}
