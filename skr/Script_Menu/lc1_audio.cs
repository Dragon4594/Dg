using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject lc1;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        // When spacebar is hit
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate the fireball object
            Instantiate(lc1,
                new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
                new Quaternion(0, 0, 0, 0));

            // play the sound
            source.Play();
        }
    }

}