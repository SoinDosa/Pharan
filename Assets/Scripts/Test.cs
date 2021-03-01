using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public AudioClip select;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<AudioSource>().PlayOneShot(select);
        }
    }
}