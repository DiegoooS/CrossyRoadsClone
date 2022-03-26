using CRC.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CRC.Loop
{
    public class MenuState : BaseState
    {
        UnityAction transitionToGameState;
        CrossyInput crossyInput;

        public MenuState(UnityAction transitionToGameState, CrossyInput crossyInput)
        {
            this.transitionToGameState = transitionToGameState;
            this.crossyInput = crossyInput;
        }


        public override void InitState()
        {
            crossyInput.AddListenerOnClick(CrossyInputsValues.space, transitionToGameState);
        }

        public override void UpdateState()
        {
            Debug.Log("UPDATE MENU");
        }

        public override void DisposeState()
        {
            crossyInput.ClearInputs();
        }
    } 
}
