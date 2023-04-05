//"hasChanged" usado para detectar si ha ocurrido un cambio con el "transform"
//Con este ejemplo usamos el script "forward_right_up" para mover el cubo y determinar que se movió.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasChanged_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            print("El transform ha cambiado!");
            transform.hasChanged = false;
        }
    }
}
