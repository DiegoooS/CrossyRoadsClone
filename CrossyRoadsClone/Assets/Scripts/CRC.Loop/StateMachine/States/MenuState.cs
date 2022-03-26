using CRC.GUI;
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
        MenuView menuView;

        public MenuState(UnityAction transitionToGameState, CrossyInput crossyInput, MenuView menuView)
        {
            this.transitionToGameState = transitionToGameState;
            this.crossyInput = crossyInput;
            this.menuView = menuView;
        }


        public override void InitState()
        {
            menuView?.ShowView();
            crossyInput.AddListenerOnClick(CrossyInputsValues.space, transitionToGameState);
        }

        public override void UpdateState()
        {
            Debug.Log("UPDATE MENU");
        }

        public override void DisposeState()
        {
            if (menuView != null)
                menuView?.HideView();
            crossyInput.ClearInputs();
        }
    } 
}
