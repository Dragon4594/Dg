using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class oscillator_trigger : MonoBehaviour
{
    public GameObject trigger;
    public GameObject ghost;
    public GameObject kill;
    public GameObject nad;
    public GameObject zv;
    public int ch = 0;
    public float tm=0;
    public float t = 0; 
    public float m = 0;
    public float rs = 100;
    public TextMeshProUGUI texti;
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.name == "Player") && (Input.GetKey(KeyCode.E)))
        {
            trigger.SetActive(true);
            zv.SetActive(true);
            tm = 0;
            ch = 0;
        }
        if ((other.gameObject.name == "Player") )
        {
            nad.SetActive(true);
            
        }
        if (other.gameObject.name == "ghost2")
        {
            rs = rs - Time.deltaTime;
        }
        tm =tm+ Time.deltaTime;
        if ((tm >= 5) && (tm<=25))
        {
            ch = Random.Range(5, 10);
            tm = 0;
        }
        if ((ch == 7))
        {
            trigger.SetActive(false);
            rs = rs - Time.deltaTime;
            tm = 26;
            texti.text = "hp: " + rs;
            zv.SetActive(false);
        }
        if ((ch == 2) || (ch==3) || (ch == 6))
        {
            tm = 26;
            t = 2;
            ch = 1;
        }
        if (t >= 2)
        {
            trigger.SetActive(false);
            t = t + 1;
            if ((t%3==0) || (t%5==0))
            {
                trigger.SetActive(true);
            }
            if (t == 22)
            {
                ch = 0;
                tm = 0;
                t = 0;
                trigger.SetActive(true);
            }
        }
        
        if (rs <= 0.002)
        {
            ghost.transform.position = kill.transform.position;
            rs = 1000;
        }

        if (PlayerPrefs.GetFloat("c") >= 0){
            rs = rs + PlayerPrefs.GetFloat("c");
        }
        if ((rs>= 1000000.0f) && (PlayerPrefs.GetFloat("c") == 0))
        {
            rs = 100;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.name == "Player"))
        {
            nad.SetActive(false);

        }
    }
}
