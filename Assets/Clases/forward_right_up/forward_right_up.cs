//forwars_right_up usado para moverse en los ejes Azul(forward)_rojo(right)_verde(up)
//haciendolos negativos se mueve al lado contrario.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward_right_up : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // rb.AddForce(transform.forward);
        rb.AddForce(-transform.right);
        //rb.AddForce(transform.up);
    }
}
