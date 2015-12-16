using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

namespace Assets.Scripts.Chat
{
    public class ChatInputBox : NetworkBehaviour {

        const short ChatMessageTransmission = 1002;

        public InputField TextBox;
        public Transform TextPanel;
        public GameObject MessagePrefab;
        public GameManager GameManager;

        public Player player;


        private string[] randomMessages =
        {
            "[Animal Tamer]: Hello.",
            "[Child]: Greetings.",
            "[Doctor]: Vote for me.",
            "[Fire Fighter]: Vote for Doctor."
        };
        

        
        public void SendMessage()
        {
            if (TextBox.text.Length > 0)
            {
                player.SendMessage(TextBox.text);

                TextBox.text = "";
                TextBox.Select();
                TextBox.ActivateInputField();
            }
        }
        
        
        public void SendSpecificMessage(string message, Color c)
        {
            //GameObject clone = SpawnMessage();
            //clone.GetComponent<ChatMessage>().ShowEndMessage(message, c);
        }


        private GameObject CreateMessage()
        {
            GameObject clone = Instantiate(MessagePrefab);
            clone.transform.SetParent(TextPanel, false);
            clone.transform.SetAsFirstSibling();
            return clone;
        }

        void OnGUI()
        {
            if (TextBox.isFocused && TextBox.text != "" && (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter)))
            {
                SendMessage();
            }
        }
    }
}
