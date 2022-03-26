using CRC.Input;
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

        #region INPUTS
        [SerializeField]
        CrossyInput crossyInput;
        #endregion



        private void Start()
        {
            CreateStates();
            ChangeState(menuState);

            crossyInput.OnMoveForward_AddListener(Test);
            crossyInput.OnMoveBackward_AddListener(Test);
            crossyInput.OnMoveRight_AddListener(Test);
            crossyInput.OnMoveLeft_AddListener(Test);
        }

        private void Test()
        {
            Debug.Log("TEST");
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
