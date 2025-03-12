using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoTanque : MonoBehaviour
{
    [Header("Configuración del Proyectil")]
    public GameObject projectilePrefab;         // Prefab del proyectil a disparar
    public Transform projectileSpawnPoint;      // Punto de spawn (por ejemplo, la boca del cañón)
    public float projectileSpeed = 20f;           // Velocidad inicial del proyectil
    public float fireRate = 1f;                   // Intervalo mínimo entre disparos (en segundos)

    private float nextFireTime = 0f;

    void Update()
    {
        // Comprueba si se pulsa el botón de disparo y si ha transcurrido el tiempo suficiente
        if (Input.GetButtonDown("Jump") && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            FireProjectile();
        }
    }

    void FireProjectile()
    {
        // Instanciamos el proyectil en el punto de spawn, con la rotación del cañón
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        
        // Si el proyectil tiene un Rigidbody, le asignamos la velocidad inicial
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = projectileSpawnPoint.forward * projectileSpeed;
        }
    
    
        StartCoroutine(DestroyAfterSeconds(projectile, 4f));
    }

    IEnumerator DestroyAfterSeconds(GameObject obj, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(obj);
    }
}
