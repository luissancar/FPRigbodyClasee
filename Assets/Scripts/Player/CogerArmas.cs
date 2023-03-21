using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{


    public GameObject[] armas;

    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        //DesactivarBoxcolliderArmas();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarArma(int numero)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);
        player.conArma = true;
    }

    public void DesactivarArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }

        player.conArma = false;

    }

    
}
