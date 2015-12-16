using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets.Scripts.UI;
using Assets.Scripts.Traits;
using UnityEngine.Networking;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour {


        public Player LocalPlayer;
        public GameObject VotesPanel;
        public TraitIcons TraitIcons;
        public NetworkManager networkManager;

        private List<Trait> PlayerTraits = new List<Trait>();
        private IEnumerable<VoteFrame> voteFrames;
        


        void Start() {
            
            voteFrames = VotesPanel.GetComponentsInChildren<VoteFrame>();

            //Initiallize PlayerTraits
            PlayerTraits.Add(new AnimalHandler(TraitIcons.AnimalHandlerIcon));
            PlayerTraits.Add(new ComputerGuy(TraitIcons.ComputerGuyIcon));
            PlayerTraits.Add(new Fireman(TraitIcons.FiremanIcon));
            PlayerTraits.Add(new Kid(TraitIcons.KidIcon));
            PlayerTraits.Add(new Mechanic(TraitIcons.MechanicIcon));
            PlayerTraits.Add(new Medic(TraitIcons.MedicIcon));
            PlayerTraits.Add(new Strong(TraitIcons.StrongIcon));

            
        }
        

        void Update() {
            
        }
    }
}
