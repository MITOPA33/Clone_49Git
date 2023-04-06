//Si es hijo de un GameObject "Cylinder" mostrará el ángulo respecto al GameObjec "Cylinder" del GameObject "Cube"
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localEulerAngles_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("El transfor.eulerAngles.y respecto a WCS es: " + transform.eulerAngles.y);
        Debug.Log("El transfor.localEulerAngles.y respecto a Cylinder es: " + transform.localEulerAngles.y);
    }
}
