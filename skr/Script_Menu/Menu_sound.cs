using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_sound : MonoBehaviour
{
    float randomNumber = Random.Range(0, 2);
    public float Cube = 10;
    public GameObject menu1;
    public GameObject menu2;
    void Start()
    {
        Cube = Random.Range(0, 2);
        if (Cube == 0)
        {

            menu1.SetActive(true);

        }

        if (Cube == 1)
        { 

                   menu2.SetActive(true);

        }

    }

    void Update()
    {
      


    }

}
