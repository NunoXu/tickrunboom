using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms
{
    public struct PlayContainer
    {
        /* Retarded struct to pass play arguments through the clients,
        because UNET is retarded and doesn't do abstract classes/interfaces */

        public int playId;
        public string playName;

        public int pieceId;
    }
}
