using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Data
{
    [CreateAssetMenu(menuName = "Crossy/Car/NewCar")]
    public class CarData : ScriptableObject
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float baseSpeed;
    } 
}
