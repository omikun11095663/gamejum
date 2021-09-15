using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource source;
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    source.Play();
        //}
        //if (Input.GetKeyUp(KeyCode.R))
        //{
        //    source.pitch = 1;
        //}
        //else if (Input.GetKey(KeyCode.R))
        //{
        //    source.pitch = -1;
        //}
        if (Input.GetButtonUp("Cancel"))
        {
            source.pitch = 1;
        }
        else if (Input.GetButton("Cancel"))
        {
            source.pitch = -1.5f;
        }
    }
}
