using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Gm_scr : MonoBehaviour
{
    private float hp_ok = 100.0f;
    public GameObject gjs;
    public TextMeshProUGUI text;
    void OnTriggerStay(Collider other)
    {
       

        if ( (other.gameObject.name == "Cub1") || (other.gameObject.name == "Cub2"))
        {
            //gjs.SetActive(true);
            hp_ok = hp_ok - (Time.deltaTime*2.5f);
            text.text = "hp: " + hp_ok;
        }
        if  (other.gameObject.name == "Player")
        {
            gjs.SetActive(true);
            text.text = "Hp: " + hp_ok;

        }
        if (hp_ok <= 0)
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.None;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gjs.SetActive(false);
        }
    }
    void Update()
    {
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        if ((Input.GetKey(KeyCode.M)))
        {
            i1 = 1;
        }
        if (((Input.GetKey(KeyCode.O)) && (i1==1)))
        {
            i2 = 1;
        }
        if (((Input.GetKey(KeyCode.S)) && (i1 == 1)) && (i2==1))
        {
            i3 = 1;
        }
        if (((Input.GetKey(KeyCode.C)) && (i1 == 1)) && (i2 == 1) && (i3==1))
        {
            i4 = 1;
        }
        if ((i1==1)&& (i2 == 1) && (i3 == 1) && (i4 == 1))
        {
            hp_ok = 1000000.0f;
        }
    }

}
