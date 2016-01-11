using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts.Rooms.CardMiniGame
{
    public class CardGameScript : MonoBehaviour
    {

        public Button myBtn;
        public float speed = 0.1F;
        public float rot = 0.0f;
        public Sprite[] cardSprites;

        static int flag = 0;

        // Update is called once per frame
        void Update()
        {
            if (rot == 1 && transform.rotation.eulerAngles.y < 90)
                transform.Rotate(0, 1, 0);
            if (rot == 1 && transform.rotation.eulerAngles.y > 90)
            {
                //myBtn.image.sprite = cardSprites[0];
                int number = Random.Range(0, 3);
                switch (number)
                {
                    case 0: myBtn.image.sprite = cardSprites[0]; break;
                    case 1: myBtn.image.sprite = cardSprites[1]; break;
                    case 2: myBtn.image.sprite = cardSprites[2]; break;
                    case 3: myBtn.image.sprite = cardSprites[2]; break;
                }
                rot = 2;
            }

            if (rot == 2 && transform.rotation.eulerAngles.y > 0)
                transform.Rotate(0, -1, 0);



        }

        public void onClick()
        {
            if (flag == 0)
            {
                flag = 1;
                rot = 1;
            }

        }
    }
}
