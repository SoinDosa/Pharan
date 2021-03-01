using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMving : MonoBehaviour {
    private float _speed = 5.0f;
    private int a = 1;
    void Update()
    {
        if(transform.localPosition.x < 1.0f)
        {
            a = 1;
        }
        else if(transform.localPosition.x > 9.0f)
        {
            a = -1;
        }
        transform.Translate(a*_speed * Time.deltaTime, 0, 0);
    }
}
