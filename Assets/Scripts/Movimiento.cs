using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Movimiento : MonoBehaviour
{
    
    public Vector2 j1;
    public Vector2 j2;
    public InputActionProperty izquierda;
    public InputActionProperty derecha;
    public float velocidad;
    public Vector3 movimiento;
    public Vector3 direccion;
    void Start()
    {
        izquierda.action.Enable();
        derecha.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        j1 = izquierda.action.ReadValue<Vector2>();
        j2 = derecha.action.ReadValue<Vector2>();
        movimiento.x = j1.x;
        movimiento.z = j1.y;
        transform.Translate(movimiento * velocidad * Time.deltaTime,Space.World);
        direccion.x = j2.x;
        direccion.z= j2.y;
        if (direccion.sqrMagnitude>0)
        {
            transform.forward = direccion.normalized;
        }       
    }
}