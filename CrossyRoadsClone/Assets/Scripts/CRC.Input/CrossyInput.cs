using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace CRC.Input
{
    public class CrossyInput : MonoBehaviour
    {
        [SerializeField]
        private PlayerInput playerInput;

        //1. Zdefiniowa� co� co pozwoli podi�� si� zewn�trzn� metod� do danego inputu
        private UnityAction onMoveForward_Actions;
        private UnityAction onMoveBackward_Actions;
        private UnityAction onMoveRight_Actions;
        private UnityAction onMoveLeft_Actions;

        //2. Zdefiniowa� metody umo�lwiaj�ce to podpi�cie
        public void OnMoveForward_AddListener(UnityAction action)
        {
            onMoveForward_Actions += action;
        }

        public void OnMoveBackward_AddListener(UnityAction action)
        {
            onMoveBackward_Actions += action;
        }

        public void OnMoveRight_AddListener(UnityAction action)
        {
            onMoveRight_Actions += action;
        }

        public void OnMoveLeft_AddListener(UnityAction action)
        {
            onMoveLeft_Actions += action;
        }

        //3. Wywo�a� to co� w momencie w kt�ym dostaniemy input
        //   tak aby przekazana metoda si� wywo�a�a

        public void OnMoveForward(InputAction.CallbackContext ctx)
        {
            if (ctx.action.WasPerformedThisFrame())
            {
                onMoveForward_Actions?.Invoke();
            }
        }

        public void OnMoveBackward(InputAction.CallbackContext ctx)
        {
            if (ctx.action.WasPerformedThisFrame())
            {
                onMoveBackward_Actions?.Invoke();
            }
        }
        public void OnMoveRight(InputAction.CallbackContext ctx)
        {
            if (ctx.action.WasPerformedThisFrame())
            {
                onMoveRight_Actions?.Invoke();
            }
        }

        public void OnMoveLeft(InputAction.CallbackContext ctx)
        {
            if (ctx.action.WasPerformedThisFrame())
            {
                onMoveLeft_Actions?.Invoke();
            }
        }
    } 
}
