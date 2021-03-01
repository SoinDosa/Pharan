using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {
    // Use this for initialization
    public GameObject pistol;
    public GameObject me;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player") && Input.GetKey(KeyCode.A))
        {
            col.isTrigger = false;
            this.transform.parent = me.transform;
            this.transform.position = me.transform.position;
            this.transform.position = new Vector3(0.55f, 0.09f, -6);
            this.transform.localEulerAngles = new Vector3(0, 0, -16.895f);
            this.transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);        
        }
        if (col.gameObject.tag.Equals("Player") && Input.GetKey(KeyCode.D))
        {
            col.isTrigger = false;
            this.transform.parent = me.transform;
            this.transform.position = me.transform.position;
            this.transform.position = new Vector3(0.55f, 0.09f, 6);
            this.transform.localEulerAngles = new Vector3(0, 0, -16.895f);
            this.transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);
        }
    }
}
