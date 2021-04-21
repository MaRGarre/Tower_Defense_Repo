using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Bala : MonoBehaviour
{
    [Tooltip("Velocidad de la bala")]
    public float bulletSpeed;

    public GameObject Enemigo;

    void Start()
    {
        // La bala se destruirá a los 3 segundos para evitar problemas de memoria
        Destroy(gameObject, 3);
    }

    void Update()
    {
       // if (Enemigo != null)
       // {
            transform.position = Vector3.MoveTowards(transform.position, Enemigo.transform.position, bulletSpeed);

       // } else {
         //   Destroy(gameObject);
       // }
            // Movimiento de la bala en el eje Y según la velocidad especificada
            //transform.Translate(0, bulletSpeed, 0);
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }




}
