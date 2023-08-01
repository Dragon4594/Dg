using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stamin : MonoBehaviour
{
    private float stamin1 = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.X)) && (stamin1 != 0))  ///המכזום בûעü רטפע
        {
            stamin1 = stamin1 - 1;
            transform.localScale = stamin1 * new Vector3(0, 0, 1);
        }
        if ((stamin1 < 100) && !(Input.GetKey(KeyCode.X)))
        {
            stamin1 = stamin1 + Time.deltaTime;
        }

    }
}
