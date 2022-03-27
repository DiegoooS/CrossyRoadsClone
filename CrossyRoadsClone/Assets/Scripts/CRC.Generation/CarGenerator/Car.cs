using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Generation
{
    public class Car : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody rigidBody;

        public void MoveCar(float moveForce)
        {
            Debug.Log(moveForce);
            rigidBody.AddForce(transform.forward * moveForce * Time.fixedDeltaTime, ForceMode.Force);  
        }
    } 
}
