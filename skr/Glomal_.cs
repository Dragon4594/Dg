using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using TMPro;

public class Glomal_ : MonoBehaviour
{
    public GameObject gmj;
    public Transform t1;
    public Transform t2;
    public Transform t3;
    public Transform t4;
    public Transform t5;
    public Transform t6;
    public Transform t7;
    public Transform t8;
    public float i=6 ;
    public int c = 0;
    public int rn = 0; 
    public int l = 0;
    public float s = 0;
    public TextMeshProUGUI text;
    private float t = 0;
    private  float g = 100;
    private float t12 = 0;
    private float t13 = 10;
    void OnTriggerStay(Collider other)
    {
       
        
        int ran=1;
         if (c==0) 
        {
            ran = Random.Range(0,7);
            rn = ran;
            
        }
         if ((c==1) && (l==1))
        {
            i=i-Time.deltaTime;
        }
        
        
        if ((c == 0) && (rn==0) )
         {
            c = 1; 
            transform.localPosition = t1.transform.position;
            gmj.transform.position = t1.transform.position;
            transform.localScale = 0 * Vector3.one;
            transform.localScale = 5 * Vector3.one;
            
        }
            if ((rn == 1) && (c == 0))
            {
                c = 1;
            
            transform.localPosition = t2.transform.position;
                gmj.transform.position = t2.transform.position;
                transform.localScale = 0 * Vector3.one;
                transform.localScale = 5 * Vector3.one;
                
            }
            if ((rn == 2) && (c == 0))
            {
                c = 1;
            
            transform.localPosition = t3.transform.position;
                gmj.transform.position = t3.transform.position;
                transform.localScale = 0 * Vector3.one;
                transform.localScale = 5 * Vector3.one;
                
            }
            if ((rn == 3) && (c == 0))
            {
            c = 1;
            
            transform.localPosition = t4.transform.position;
                gmj.transform.position = t4.transform.position;
                transform.localScale = 0 * Vector3.one;
                transform.localScale = 5 * Vector3.one;
                
            }
            if ((rn == 4) && (c == 0))
            {
                c = 1;
            
            transform.localPosition = t5.transform.position;
                gmj.transform.position = t5.transform.position;
                transform.localScale = 0 * Vector3.one;
                transform.localScale = 5 * Vector3.one;
                
            }
            if ((rn == 5) && (c == 0))
            {   
                c = 1;
                transform.localPosition = t6.transform.position;
                gmj.transform.position = t6.transform.position;
                transform.localScale = 0 * Vector3.one;
                transform.localScale = 5 * Vector3.one;
                
            }
            if ((rn == 6) && (c == 0) )
            {
                c = 1;
                transform.localPosition = t7.transform.position;
                gmj.transform.position = t7.transform.position;
                transform.localScale = 0 * Vector3.one;
                transform.localScale = 5 * Vector3.one;
                
            }


            if ((other.gameObject.name == "Player") && (Input.GetKey(KeyCode.E)))
        {
            i = 14;
            c = 1;
            l = 1;
            transform.localPosition = t8.transform.position; 
            gmj.transform.position = t8.transform.position;
        }
        if (i < 0)
        {
            c = 0;
            i = 13;
            l = 0;
        }
        
        

    }
    
    private void Update()
    {
        
        s = s + Time.deltaTime;
        
        if (s >= g)
        {
            t = t + 1;
            g = g + 60;

        }
        if (s>= t13)
        {
            t12 = t12 + 10;
            t13 = t13 + 10;
        }
        if (t12 == 0)
        {
            text.text = "time" + t + ":00/6:00";
        }
        if (t12 > 0)
        {
            text.text = "time" + t + ":" + t12 + "/6:00";
        }
            
        if (s >= 60)
       
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(2);
            }
    }
}
