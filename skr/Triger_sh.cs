using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Triger_sh : MonoBehaviour
{
    public float stamin1 = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.X)) && (stamin1>0)) //המכזום בûעü רטפע
        {
            transform.localScale = 50 * Vector3.one;

        }
        if ((Input.GetKeyUp(KeyCode.X)) || (stamin1 <= 0))//המכזום בûעü רטפע
        {
            transform.localScale = 1 * Vector3.one;

        }
        if ((stamin1 < 100) && !(Input.GetKey(KeyCode.X)))
        {
            stamin1 = stamin1 + Time.deltaTime;
        }
    }
}
