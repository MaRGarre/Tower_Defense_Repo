using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Torre : MonoBehaviour
{
    [Tooltip("Referencia al prefab de la bala")]
    public GameObject bulletPrefab;

    public GameObject Enemigo;

    public float Altura;

    public float Ratio;

    private void Start()
    {
        InvokeRepeating("Disparo", 3, Ratio);

    }

    private void Disparo()
    {
        
        if (Enemigo != null)
        {
            GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, Altura, 0), Quaternion.identity);
            bala.GetComponent<Movimiento_Bala>().Enemigo = Enemigo;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Enemigo = other.gameObject;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Enemigo = null;
    }
}
