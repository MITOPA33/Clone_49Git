//"hierarchyCount" y "hierarchyCapacity" muestran la cantidad de hijos que exiasten en oda la jejarquía.
//No importa donde se ponga el script en la jerarquía el "Count" y la "Capacity" siempre es la misma.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hierarchyCount_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Conteo de hijos: " + transform.childCount);
        Debug.Log("Conteo de Jerarquía: " + transform.hierarchyCount);
        Debug.Log("Capacidad de Gerarquía: " + transform.hierarchyCapacity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
