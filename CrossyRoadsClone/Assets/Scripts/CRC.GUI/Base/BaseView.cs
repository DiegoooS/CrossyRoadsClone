using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.GUI
{
    public abstract class BaseView : MonoBehaviour
    {
        public void ShowView()
        {
            this.gameObject.SetActive(true);
        }

        public void HideView()
        {
            this.gameObject.SetActive(false);
        }
    } 
}
