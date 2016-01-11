using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.Rooms.ChildMiniGame
{
    public class ButtonVisibility : MonoBehaviour
    {

        public int id;

        bool found;
        public Button myBtn;
        public Button myBtn2;
        public Sprite sprite1;
        public Sprite sprite2;

        public ChildMiniGameManager gm;

        // Use this for initialization
        void Start()
        {
            found = false;
        }

        // Update is called once per frame
        void OnGUI()
        {

            if (myBtn != null && myBtn2 != null)
            {
                
                if (!found)
                {
                    myBtn.image.sprite = sprite1;
                    myBtn2.image.sprite = sprite1;
                }
                else
                {
                    myBtn.image.sprite = sprite2;
                    myBtn2.image.sprite = sprite2;
                }
            }
        }

        public void onClick()
        {
            PlayContainer pc = new PlayContainer();

            pc.pieceId = this.id;
            pc.playId = 0;

            gm.SendPlay(pc);
        }

        public void Find()
        {
            if (!found && !gm.IsWon())
            {
                found = true;
                gm.found++;
            }
        }
    }
}
