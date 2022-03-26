using CRC.GUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Loop
{
    public class GameState : BaseState
    {
        private GameView gameView;

        public GameState(GameView gameView)
        {
            this.gameView = gameView;
        }

        public override void InitState()
        {
            gameView?.ShowView();
        }

        public override void UpdateState()
        {
            Debug.Log("UPDATE GAME STATE");
        }

        public override void DisposeState()
        {
            if(gameView != null)
                gameView?.HideView();
        }
    } 
}
