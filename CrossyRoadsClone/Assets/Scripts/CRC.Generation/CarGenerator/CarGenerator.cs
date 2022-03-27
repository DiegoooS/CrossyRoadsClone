using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Generation
{
    public class CarGenerator : MonoBehaviour
    {
        // refka do spawn pointa
        [SerializeField]
        private GameObject spawnPoint1;
        [SerializeField]
        private GameObject spawnPoint2;
        // refka do prefabu
        [SerializeField]
        private GameObject car;


        public void SpawnCar()
        {
            // Instantiate
            // Ustawi w pozycji
            GameObject.Instantiate(car, spawnPoint2.transform.position, spawnPoint2.transform.rotation); 
            // itd?? dafuq
        }

        private void Start()
        {
            SpawnCar();
        }
    } 
}
