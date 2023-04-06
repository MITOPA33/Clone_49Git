//"transform.eulerAngles" muestra el angulo de rotación de un GameObject "Cubo" en x,y,z respecto al "WorldSystem"
//"transform.LocalEulerAngles" muestra el angulo de rotación de un GameObject "Cubo" en x,y,z respecto al "Padre" "WorldSystem"
//Si es hijo de un GameObject "Cylinder" mostrará el ángulo respecto al GameObjec "Cylinder" del GameObject "Cube_II"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eulerAngles_ : MonoBehaviour
{
    //public float yRotation = 0.5f;
    void Start()
    {
       // Debug.Log(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        //yRotation += Input.GetAxis("Horizontal");
        //transform.eulerAngles = new Vector3(0, yRotation, 0);
        Example();
    }
    
    void Example()
    {
        Debug.Log("El transfor.eulerAngles.x es: " + transform.eulerAngles.x);  //Cuando es hijo de WorldSystem
        Debug.Log("El transfor.eulerAngles.y es: " + transform.eulerAngles.y);  //Cuando es hijo de WorldSystem
        Debug.Log("El transfor.eulerAngles.z es: " + transform.eulerAngles.z);  //Cuando es hijo de WorldSystem

        Debug.Log("El transfor.localEulerAngles.x es: " + transform.localEulerAngles.x);    //Cuando es hijo de un GameObject
        Debug.Log("El transfor.localEulerAngles.y es: " + transform.localEulerAngles.y);    //Cuando es hijo de un GameObject
        Debug.Log("El transfor.localEulerAngles.z es: " + transform.localEulerAngles.z);    //Cuando es hijo de un GameObject

    }
    
}
