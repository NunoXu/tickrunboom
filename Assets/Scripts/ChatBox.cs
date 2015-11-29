using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChatBox : MonoBehaviour {

    public Text TextBox;
    public Transform TextPanel;
    public GameObject MessagePrefab;

	public void SendMessage()
    {
        GameObject clone = Instantiate(MessagePrefab);
        clone.transform.SetParent(TextPanel);
        clone.transform.SetSiblingIndex(TextPanel.childCount - 1);
        //clone.GetComponent<>


    }
}
