using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
    
{
    // Start is called before the first frame update
    public GameObject gj;

    public GameObject scrimer1;
    public GameObject scrimer2;
    public GameObject scrimer3;
    public GameObject scrimer4;
    public GameObject scrimer5;
    public GameObject scrimer6;
    public GameObject off;
    public float n = 0;
    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.name == "Cub1"))
        {
            scrimer4.transform.position = gj.transform.position;
            scrimer4.transform.transform.rotation = gj.transform.rotation;
            scrimer1.SetActive(true);
            n = 1;
            off.SetActive(false);
        }
        if((other.gameObject.name == "Cub2"))
        {
            scrimer3.transform.position = gj.transform.position;
            scrimer3.transform.transform.rotation = gj.transform.rotation;
            scrimer2.SetActive(true);
            n = 1;
            off.SetActive(false);
        }
        if ((other.gameObject.name == "Ghost"))
        {
            scrimer5.transform.position = gj.transform.position;
            scrimer5.transform.transform.rotation = gj.transform.rotation;
            scrimer6.SetActive(true);
            n = 1;
            off.SetActive(false);
        }
        if (n >= 1)
        {
            n = n + Time.deltaTime;
        }
        if (n >= 2.9)
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.None;
        }

    }

}
