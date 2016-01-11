using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Rooms.ChildMiniGame
{
    class ChildPressButtonPlay : Play
    {
        public override void PerformPlay(MiniGame miniGame, PlayContainer playContainer)
        {
            ChildMiniGameManager childGM = (ChildMiniGameManager)miniGame;
            childGM.Buttons[playContainer.pieceId].Find();
        }
    }
}
