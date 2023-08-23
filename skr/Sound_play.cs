using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_play : MonoBehaviour
{
    private float ran = 0;
    public GameObject soundPod;
    public GameObject soundPlay;
    public GameObject sound;
    
    private float tim=1;
    // Update is called once per frame
    void Update()
    {
        ran = Random.Range(0, 7);
        if ((ran == 6) && (tim == 0))
        {
            sound.SetActive(true);
            tim = tim + 1;
            PlayerPrefs.SetFloat("cam", 10000);
        }
        if (tim >= 1)
        {
            tim = tim + Time.deltaTime;
        }
        if (tim >= 110)
        {
            sound.SetActive(false);
            tim = 0;
        }
    }
        void OnTriggerStay(Collider other)
        {
            if ((other.gameObject.name == "Player"))
            {
                soundPod.SetActive(true );
                soundPlay.SetActive(false);
            }
        }
        void OnTriggerExit(Collider other)
        {
            
                soundPod.SetActive(false);
                soundPlay.SetActive(true);
            
        }

    
}
