using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Generation
{
    public class Line : MonoBehaviour
    {
        [SerializeField]
        private CarGenerator carGenerator;
        [SerializeField]
        private MeshRenderer meshRenderer;

        [SerializeField]
        private Color brightColor;
        [SerializeField]
        private Color darkColor;

        public void SetColor(int counter)
        {
            if (counter % 2 != 0)
            {
                meshRenderer.material.color = brightColor;
            }
            else
            {
                meshRenderer.material.color = darkColor;
            }
        }

        public void InitializeLine()
        {
            StartCoroutine(GenerateCar(5f));
        }

        private IEnumerator GenerateCar(float timeBetweenSpawns)
        {
            while (true)
            {
                carGenerator.SpawnCar(transform.parent);
                yield return new WaitForSeconds(timeBetweenSpawns);
            }
        }
    } 
}
