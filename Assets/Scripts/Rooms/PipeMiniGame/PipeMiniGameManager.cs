using UnityEngine;
using System.Collections;
using Assets.Scripts.Rooms;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

namespace Assets.Scripts.Rooms.PipeMiniGame
{
    public class PipeMiniGameManager : MiniGame
    {

        public GameObject Pieces;
        public Image Background;
        public PipeScript[] Pipes;
        public PipeWinCondition PipeWinCondition;

        protected override void Initialize()
        {
            base.Initialize();
            plays = new Play[] { new PipeRotatePlay() };
            int i = 0;

            Pipes = Pieces.GetComponentsInChildren<PipeScript>();
            foreach (PipeScript pipe in Pipes)
            {
                pipe.id = i++;
            }
        }

        public override bool IsWon()
        {
            return PipeWinCondition.IsWon();
        }

    }
}
