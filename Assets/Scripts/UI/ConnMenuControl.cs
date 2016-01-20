﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Assets
{
    public class ConnMenuControl : MonoBehaviour
    {

        public InputField input;

        public void StartLocalGame()
        {
            NetworkManager.singleton.StartHost();
        }

        public void JoinLocalGame()
        {
            NetworkManager.singleton.networkAddress = input.text;
            NetworkManager.singleton.StartClient();
        }
            
           
    }
}
