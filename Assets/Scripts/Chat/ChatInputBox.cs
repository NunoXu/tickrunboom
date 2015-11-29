using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts.Chat
{
    public class ChatInputBox : MonoBehaviour {

        private const float RANDOM_MESSAGE_DELAY = 2.0f;
        private float previousTime = 0.0f;
        private int nextMessage = 0;

        public InputField TextBox;
        public Transform TextPanel;
        public GameObject MessagePrefab;
        public GameManager GameManager;

        private string[] randomMessages =
        {
            "Lockhart: Hello.",
            "John: Greetings",
            "Mario: Vote for me.",
            "Princess: Vote for Mario"
        };

        public void SendMessage()
        {
            if (TextBox.text.Length > 0)
            {
                GameObject clone = Instantiate(MessagePrefab);
                clone.transform.SetParent(TextPanel);
                clone.transform.SetAsFirstSibling();
                clone.GetComponent<ChatMessage>().ShowMessage(GameManager.player, TextBox.text);
                TextBox.text = "";
                TextBox.Select();
                TextBox.ActivateInputField();
            }
        }

        public void SendRandomMessage()
        {
            GameObject clone = Instantiate(MessagePrefab);
            clone.transform.SetParent(TextPanel);
            clone.transform.SetAsFirstSibling();
            clone.GetComponent<ChatMessage>().ShowMessage(randomMessages[nextMessage]);
            nextMessage++;
            if (nextMessage >= randomMessages.GetLength(0))
                nextMessage = 0;
        }

        void OnGUI()
        {
            if (TextBox.isFocused && TextBox.text != "" && Input.GetKey(KeyCode.Return))
            {
                SendMessage();
            }
        }


        void Start()
        {
            previousTime = Time.realtimeSinceStartup;
        }

        void Update()
        {
            var timePassed = Time.realtimeSinceStartup - previousTime;
            if (timePassed > RANDOM_MESSAGE_DELAY)
            {
                SendRandomMessage();
                previousTime = Time.realtimeSinceStartup;
            }
        }
    }
}
