//"transform.childCount" muestra el número de hijos directos en el primer nivel (NO muestra los hijos de los hijos).
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childCount_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" El cubo tiene " + this.transform.childCount + " hijos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
