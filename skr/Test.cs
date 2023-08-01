using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
    
{
    // Start is called before the first frame update
    public GameObject gj;
    public float z0 = 0;
    public float z1 = 0;
    void Start()
    {
        gj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)&&(z0==0)))
        {
            gj.SetActive(true);
            z0 = 1;
        }
        if (z0 == 1)
        {
            z1 = z1 + 1;
            transform.localScale = z1 * new Vector3(1,1,0) * Time.deltaTime * 5;
            
        }

        if ((z1 >= 100) && (z0 == 1)) 
        {
            z0 = 2;

        }
        if (z0 == 2)
        {
            z1 = z1 - 1;
            transform.localScale = z1 * new Vector3(1, 1, 0) * Time.deltaTime * 5;
            
        }
        if ((z1 <= 0)&&(z0==2))
        {
            z0 = 0;
        }
    }
}
