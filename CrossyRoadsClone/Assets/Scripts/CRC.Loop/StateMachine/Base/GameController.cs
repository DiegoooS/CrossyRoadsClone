using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Loop
{
    public class GameController : MonoBehaviour
    {
        #region STATES
        private MenuState menuState;
        private BaseState currentlyActiveState;
        #endregion



        private void Start()
        {
            CreateStates();
            ChangeState(menuState);
        }

        private void Update()
        {
            currentlyActiveState?.UpdateState();
        }

        private void OnDestroy()
        {
            currentlyActiveState?.DisposeState();
        }

        private void ChangeState(BaseState newState)
        {
            currentlyActiveState?.DisposeState();
            currentlyActiveState = newState;
            currentlyActiveState.InitState();
        }

        private void CreateStates()
        {
            menuState = new MenuState();
        }
    } 
}
