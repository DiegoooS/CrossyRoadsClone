using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Loop
{
    public class MenuState : BaseState
    {
        public override void InitState()
        {
            Debug.Log("INIT MENU");
        }

        public override void UpdateState()
        {
            Debug.Log("UPDATE MENU");
        }

        public override void DisposeState()
        {
            
        }
    } 
}
