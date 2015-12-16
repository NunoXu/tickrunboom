using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Chat
{
    class ChatBox : MonoBehaviour
    {
        public NetworkHash128 assetId { get; set; }
        public GameObject m_Prefab;
        public Transform TextPanel;

        public delegate GameObject SpawnDelegate(Vector3 position, NetworkHash128 assetId);
        public delegate void UnSpawnDelegate(GameObject spawned);

        void Start()
        {
            assetId = m_Prefab.GetComponent<NetworkIdentity>().assetId;
          
            ClientScene.RegisterSpawnHandler(assetId, SpawnObject, UnSpawnObject);
        }

        public GameObject SpawnObject(Vector3 position, NetworkHash128 assetId)
        {
            GameObject clone = Instantiate(m_Prefab);
            clone.transform.SetParent(TextPanel, false);
            clone.transform.SetAsFirstSibling();
            return clone;
        }

        public void UnSpawnObject(GameObject spawned)
        {
            
        }

    }
}
