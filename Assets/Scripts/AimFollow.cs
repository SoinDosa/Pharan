using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimFollow : MonoBehaviour {
    public GameObject Ob;
    public Vector3 mPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mPos = Input.mousePosition;
        transform.position = Camera.main.ScreenToWorldPoint(mPos);
	}
}
