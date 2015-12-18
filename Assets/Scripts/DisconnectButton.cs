using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace Assets.Scripts
{
    public class DisconnectButton : MonoBehaviour
    {
        public void Disconnect()
        {
            NetworkManager.singleton.StopHost();
        }
       
    }
}
