using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Rooms.PipeMiniGame
{
    public class PipeRotatePlay : Play
    {
        public override void PerformPlay(MiniGame miniGame, PlayContainer playContainer)
        {
            PipeMiniGameManager pipeMG = (PipeMiniGameManager)miniGame;

            pipeMG.Pipes[playContainer.pieceId].Rotate();
        }
    }
}
