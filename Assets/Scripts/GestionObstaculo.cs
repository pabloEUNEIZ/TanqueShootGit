using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GestionObstaculo : MonoBehaviour
{
    public UnityEvent OnColisionDeBala;
    void OnCollisionExit(Collision collision)
    {
        // Verifica si el objeto que colisiona tiene el tag "Bala"
        if (collision.gameObject.CompareTag("Bala"))
        {
            OnColisionDeBala.Invoke();
            // Destruye el cubo
            Destroy(gameObject);
        }
    }
}
