using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_dor1 : MonoBehaviour
{
    public Transform trl;
    public GameObject gmj;
    public GameObject gj;
    public GameObject gjp;
    public float z0 = 0;
    public float z1 = 0;
   
    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gmj.SetActive (true);
        }
        
        if ((other.gameObject.name == "Player") && ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyUp(KeyCode.E))))
        { 
            gj.SetActive (true);
            z0 = 1;
        }
        if (z0 == 1)
        {
            z1 = z1 + 1;
            gj.transform.localScale = z1 * new Vector3(1, 1, 0) * Time.deltaTime * 5;

        }
        if ((z1 >= 70) && (z0 == 1))
        {
            z0 = 2;
            gjp.transform.position = trl.transform.position;
        }
        if (z0 == 2)
        {
            z1 = z1 - 1;
            gj.transform.localScale = z1 * new Vector3(1, 1, 0) * Time.deltaTime * 5;

        }
        if ((z1 <= 0) && (z0 == 2))
        {
            z0 = 0;
        }

        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gmj.SetActive(false);
        }
    }
}
