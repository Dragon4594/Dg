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

}
