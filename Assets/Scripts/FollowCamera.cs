using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    private float _speed = 2.0f;
    public GameObject player;
    public Vector3 cameraPosition;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        cameraPosition.x = player.transform.position.x ;
        cameraPosition.y = player.transform.position.y + 1;
        cameraPosition.z = -10;
        transform.position = cameraPosition;
    }
}
