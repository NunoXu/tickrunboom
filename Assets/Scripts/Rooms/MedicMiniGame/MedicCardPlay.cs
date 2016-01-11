using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Rooms.MedicMiniGame
{
    public class MedicCardPlay : Play
    {
       
        public override void PerformPlay(MiniGame miniGame, PlayContainer playContainer)
        {
            var medMiniGame = (MedicMiniGameManager)miniGame;

            medMiniGame.GameCards[playContainer.pieceId].Flip();
            medMiniGame.GameCards[playContainer.pieceId].FlipAdjacent();
        }
    }
}
