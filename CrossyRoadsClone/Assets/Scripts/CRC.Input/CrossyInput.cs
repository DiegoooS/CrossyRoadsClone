using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace CRC.Input
{
    public enum CrossyInputsValues
    {
        forward,
        backward,
        right,
        left,
        space
    }

    public class CrossyInput : MonoBehaviour
    {
        [SerializeField]
        private PlayerInput playerInput;

        //1. Zdefiniowa� co� co pozwoli podi�� si� zewn�trzn� metod� do danego inputu
        private UnityAction onMoveForward_Actions;
        private UnityAction onMoveBackward_Actions;
        private UnityAction onMoveRight_Actions;
        private UnityAction onMoveLeft_Actions;
        private UnityAction onSpaceClick_Actions;

        //2. Zdefiniowa� metody umo�lwiaj�ce to podpi�cie
        public void AddListenerOnClick(CrossyInputsValues values, UnityAction action)
        {
            switch (values)
            {
                case CrossyInputsValues.forward:
                    onMoveForward_Actions += action;
                    break;
                case CrossyInputsValues.backward:
                    onMoveBackward_Actions += action;
                    break;
                case CrossyInputsValues.right:
                    onMoveRight_Actions += action;
                    break;
                case CrossyInputsValues.left:
                    onMoveLeft_Actions += action;
                    break;
                case CrossyInputsValues.space:
                    onSpaceClick_Actions += action;
                    break;
            }
        }

        public void ClearInputs()
        {
            onMoveForward_Actions = null;
            onMoveBackward_Actions = null;
            onMoveLeft_Actions = null;
            onMoveRight_Actions = null;
            onSpaceClick_Actions = null;
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

        public void OnSpaceClick(InputAction.CallbackContext ctx)
        {
            if (ctx.action.WasPerformedThisFrame())
            {
                onSpaceClick_Actions?.Invoke();
            }
        }
    } 
}
