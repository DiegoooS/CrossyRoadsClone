using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CRC.Generation
{
    public class LineGenerator : MonoBehaviour
    {
        // 1. Prefab do linii
        [SerializeField]
        private Line line;

        // Parent = refka do parent -> Dynamic
        [SerializeField]
        private GameObject parentObject;
        // Start pos = refka do start Pos -> obiekt start Pos
        [SerializeField]
        private GameObject startPosition;
        // Counter = ile linii juz wygenerowalem
        private int counter = 0;
        // delta/distance = distance miêdzy kolejnymi lanemami => 1.5
        private float distance = 1.5f;

        // 2. Generujemy linie
        public void GenerateLine()
        {       
            Vector3 newPos = startPosition.transform.position;
            newPos.x = newPos.x + distance * ++counter;

            var newLine = GameObject.Instantiate(line, newPos , startPosition.transform.rotation);
            newLine.transform.SetParent(parentObject.transform, true);
            
            newLine.SetColor(counter);
            newLine.InitializeLine();
        }

        public void GenerateLevel(int linesCount)
        {
            for (int l = 0; l < linesCount; l++)
            {
                GenerateLine();  
            }
        }
    }
}
