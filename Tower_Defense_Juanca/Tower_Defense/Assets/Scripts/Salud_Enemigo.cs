using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud_Enemigo : MonoBehaviour
{
    public int Salud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Salud <= 0)
        {
            Destroy(gameObject);
        } 
    }
}
