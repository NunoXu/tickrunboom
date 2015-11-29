using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour {


        public GameObject votesPanel;
        public Player player;
        
        private List<GameObject> uiComponents;


        void Start() {
            player = new Player { NickName = "Anon" };

            this.uiComponents = GameObject.FindGameObjectsWithTag("VotingFrame").ToList();
        }
        

        void Update() {
            
        }
    }
}
