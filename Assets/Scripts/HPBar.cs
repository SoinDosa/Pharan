using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour {
    public GameObject Hp1;
    public GameObject Hp2;
    public GameObject Hp3;
    public GameObject Hp4;
    public GameObject Hp5;
    public Sprite Heart;
    public Sprite EmptyHeart;
    public AudioClip hitSound;
    public GameObject player;
    public GameObject Camera;
    public Vector3 cameraPosition;
    int HP = 5;
    Image hpBarComponent1;
    Image hpBarComponent2;
    Image hpBarComponent3;
    Image hpBarComponent4;
    Image hpBarComponent5;


    void Start () {
        hpBarComponent1 = Hp1.GetComponent<Image>();
        hpBarComponent2 = Hp2.GetComponent<Image>();
        hpBarComponent3 = Hp3.GetComponent<Image>();
        hpBarComponent4 = Hp4.GetComponent<Image>();
        hpBarComponent5 = Hp5.GetComponent<Image>();
    }
    void OnTriggerEnter2D(Collider2D col) // 접촉시 활성되는 트리거
    {
        if (col.gameObject.tag.Equals("Die"))
        {
            if(HP == 5)
            {
                hpBarComponent1.sprite = EmptyHeart;
                GetComponent<AudioSource>().PlayOneShot(hitSound);
            }
            else if (HP == 4)
            {
                hpBarComponent2.sprite = EmptyHeart;
                GetComponent<AudioSource>().PlayOneShot(hitSound);
            }
            else if (HP == 3)
            {
                hpBarComponent3.sprite = EmptyHeart;
                GetComponent<AudioSource>().PlayOneShot(hitSound);
            }
            else if (HP == 2)
            {
                hpBarComponent4.sprite = EmptyHeart;
                GetComponent<AudioSource>().PlayOneShot(hitSound);
            }
            else if (HP == 1)
            {
                hpBarComponent5.sprite = EmptyHeart;
            }
            HP--;
        }
    }
}
