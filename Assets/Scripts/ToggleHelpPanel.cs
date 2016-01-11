using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleHelpPanel : MonoBehaviour {

    public GameObject panel;
    
	public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }
}
