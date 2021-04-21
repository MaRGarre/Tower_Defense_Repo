using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño_Bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            --collision.gameObject.GetComponent<Salud_Enemigo>().Salud;

        }

        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);


    }
}       

      
