//"transform.localPosition" es con respecto a cubo rosa (que ha rotado 90º CCW) = (5,0,0) [el eje principal esta sobre "Z" WCS].
//"transform.position" es con respecto a WCS = (-5,0.5,-5)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localPosition_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localPosition Vs transform.position
        Debug.Log("El transform.localPosition del cubo verde respecto al cubo rosa es: " + transform.localPosition);
        Debug.Log("El transform.position del cubo verde respecto al cubo rosa es: " + transform.position);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
