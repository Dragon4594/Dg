using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class razum : MonoBehaviour
{
    public GameObject texti;

    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.name == "Player"))
        {
            texti.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            texti.SetActive(false);
        }
    }
}
