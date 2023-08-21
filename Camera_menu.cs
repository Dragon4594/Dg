using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_menu : MonoBehaviour
{
    public float t=450;
    public float t2=370;
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if ((t >= 450) && (t2==370))
        {
            t = t + Time.deltaTime;
            transform.localPosition += transform.right * speed *Time.deltaTime;

        }
        if ((t >= 475) && (t2==370))
        {
            t2 = 394;
            t = 480;
            transform.Rotate( 90.0f * new Vector3(0,1,0));
            transform.localPosition = 0*new Vector3(1, 1, 1);
            transform.localPosition += 1.6f * new Vector3(0,1,0);
            transform.localPosition += t2 * new Vector3(0, 0, 1);
            transform.localPosition += t * new Vector3(1, 0, 0);

        }
        if ((t>=480) && (t2==394))
        {
            t = t + Time.deltaTime;
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if ((t >= 490) && (t2 == 394))
        {
            t2 = 386;
            t = 480;
            transform.localPosition = 0 * new Vector3(1, 1, 1);
            transform.localPosition += 5.4f * new Vector3(0, 1, 0);
            transform.localPosition += t2 * new Vector3(0, 0, 1);
            transform.localPosition += t * new Vector3(1, 0, 0);

        }
        if ((t >= 480) && (t2 == 386))
        {
            t = t + Time.deltaTime;
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if ((t >= 490) && (t2 == 386))
        {
            t = 450;
            t2 = 370;
            transform.Rotate(270 * new Vector3(0, 1, 0));
            transform.localPosition = 0 * new Vector3(1, 1, 1);
            transform.localPosition += 2.5f * new Vector3(0, 1, 0);
            transform.localPosition += t2 * new Vector3(0, 0, 1);
            transform.localPosition += t * new Vector3(1, 0, 0);
            
        }
    }
}
