using CRC.Data;
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

        // Lista z dostepnymi pojazdami scritpable
        [SerializeField]
        private CarData[] carsToSpawn;

        public void SpawnCar()
        {
            // Zespawnuj losowy pojazd => Random.Range
            int randomCarNumber = Random.Range(0, carsToSpawn.Length - 1);
            var car = GameObject.Instantiate(carsToSpawn[randomCarNumber].Prefab, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
            car.transform.SetParent(spawnPoint2.transform.parent);

            car.MoveCar(carsToSpawn[randomCarNumber].BaseSpeed);
        }
    } 
}
