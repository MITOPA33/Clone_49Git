
//"transform.eulerAngles" muestra el angulo de rotación de un GameObject en x,y,z.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eulerAngles_ : MonoBehaviour
{
    public float yRotation = 0.5f;
    void Start()
    {
       // Debug.Log(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        yRotation += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(0, yRotation, 0);
        Example();
    }
    
    void Example()
    {
        print(transform.eulerAngles.x);
        print(transform.eulerAngles.y);
        print(transform.eulerAngles.z);
    }
    
}
