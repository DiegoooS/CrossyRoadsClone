using CRC.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CRC.Loop
{
    public class GameController : MonoBehaviour
    {
        #region STATES
        private UnityAction transitionToGameState;

        private MenuState menuState;
        private GameState gameState;

        private BaseState currentlyActiveState;
        #endregion

        #region INPUTS
        [SerializeField]
        CrossyInput crossyInput;
        #endregion

        private void Start()
        {
            CreateTransitions();
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

        private void CreateTransitions()
        {
            transitionToGameState += () => ChangeState(gameState);
        }

        private void CreateStates()
        {
            gameState = new GameState();
            menuState = new MenuState(transitionToGameState, crossyInput);
        }
    } 
}
