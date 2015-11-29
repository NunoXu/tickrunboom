using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour {


        public GameObject votesPanel;
        
        private List<GameObject> uiComponents;
        private 


        void Start() {
            this.uiComponents = GameObject.FindGameObjectsWithTag("VotingFrame").ToList();
        }
        

        void Update() {
            
        }
    }
}
