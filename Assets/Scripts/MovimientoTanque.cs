using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTanque : MonoBehaviour
{
    public float moveSpeed = 1f;        // Velocidad de movimiento adelante/atrás
    public float rotationSpeed = 100f;   // Velocidad de rotación
    public float rotationSpeedCabeza = 100f;
    public Transform cabeza;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // Si se pulsa la tecla Q, rota a la izquierda.
        if (Input.GetKey(KeyCode.Q))
        {
            cabeza.Rotate(0f, -rotationSpeed * Time.deltaTime, 0f,Space.Self);
        }
        
        // Si se pulsa la tecla E, rota a la derecha.
        if (Input.GetKey(KeyCode.E))
        {
            cabeza.Rotate(0f, rotationSpeed * Time.deltaTime, 0f,Space.Self);
        }
    }

    void FixedUpdate()
    {
        // Leemos los ejes de entrada
        float moveInput = Input.GetAxis("Vertical");   // Adelante y atrás
        float turnInput = Input.GetAxis("Horizontal");   // Rotación izquierda y derecha

        Vector3 force = transform.forward * moveInput * moveSpeed;
        rb.AddForce(force, ForceMode.VelocityChange);

        float turnTorque = turnInput * rotationSpeed;
        rb.AddTorque(Vector3.up * turnTorque, ForceMode.Force);
    }
}
