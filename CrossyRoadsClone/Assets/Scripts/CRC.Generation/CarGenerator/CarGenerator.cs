using CRC.Data;
using System;
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

        public void SpawnCar(Transform parentTransform)
        {
            // Zespawnuj losowy pojazd => Random.Range
            int randomCarNumber = UnityEngine.Random.Range(0, carsToSpawn.Length - 1);
            int randomDirection = UnityEngine.Random.Range(0, 2);

            GameObject startPoint;
            if (randomDirection == 0)
            {
                startPoint = spawnPoint1;
            }
            else
            {
                startPoint = spawnPoint2;
            }

            var car = GameObject.Instantiate(carsToSpawn[randomCarNumber].Prefab, startPoint.transform.position, startPoint.transform.rotation);
            car.transform.SetParent(parentTransform);

            car.MoveCar(carsToSpawn[randomCarNumber].BaseSpeed);
        }
    } 
}
