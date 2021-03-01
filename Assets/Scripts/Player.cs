using UnityEngine;

public class Player : MonoBehaviour {
    private int HP = 5;
    private float _speed = 5.0f; // 기본속도
    private Animator playerAnim; // 애니메이터 객체 선언
    private float jumpForce = 300.0f; // 점프파워
    public int satus = 0;
    public Rigidbody2D playerRigidBody; // 리지드바디2d 객체 선언
    public bool isGround = true; // 땅에 있는지 아닌지 측정
    public GameObject GameOver;
    public GameObject Clear;
    public Collider2D mainbody;
    public AudioClip dieSound;
    public AudioClip Jumping;
            


    // Use this for initialization
    void Start () {
        playerAnim = GetComponent<Animator>(); // 애니메이터 객체에 애니메이터 컴퍼넌트를 받음
        playerRigidBody = GetComponent<Rigidbody2D>(); // 리지드바디2d 객체에 컴퍼넌트를 받음
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        Moving();
        Jump();
        Die();
    }
    void Moving()
    {
            if (Input.GetKey(KeyCode.A)) // A키가 입력되면
            {
                playerAnim.SetBool("0_walk", true); // 0_walk 가 활성화
                transform.localEulerAngles = new Vector3(0, -180, 0); // y축 방향 180도 회전
                transform.localScale = new Vector3(0.5f, 0.5f, -1); // z축 방향 사이즈를 -1로 변환
                transform.Translate(_speed * Time.deltaTime, 0, 0); // 이동속도로 이동
            }
            else if (Input.GetKey(KeyCode.D))
            {
                playerAnim.SetBool("0_walk", true);
                transform.localEulerAngles = new Vector3(0, 0, 0);
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
                transform.Translate(_speed * Time.deltaTime, 0, 0);
            }
            else
            {
                playerAnim.SetBool("0_walk", false); // 0_walk 비활성화
        }
    }
    void OnTriggerEnter2D(Collider2D col) // 접촉시 활성되는 트리거
    {
        if (col.gameObject.tag.Equals("Floor")) // 접촉한 물체의 태그가 "Floor"일 경우
        {
            isGround = true;
            playerAnim.SetBool("1_jump", false);
        }
        if (col.gameObject.tag.Equals("Die"))
        {
            transform.localEulerAngles = new Vector3(0, 0, 90);
            transform.position = new Vector3(0, 0, 0);
            HP--;
        }
        if (col.gameObject.tag.Equals("Stage1Portal"))
        {
            Clear.SetActive(true);
            Time.timeScale = 0;
        }

    }
    void OnTriggerExit2D(Collider2D col) // 탈출시 활성되는 트리거                                                                                   
    {
        if (col.gameObject.tag.Equals("Floor"))
        {
            isGround = false;
            playerAnim.SetBool("1_jump", true);
            GetComponent<AudioSource>().PlayOneShot(Jumping);
        }
        if (col.gameObject.tag.Equals("UpPower"))
        {
            isGround = false;
            playerRigidBody.AddForce(new Vector2(0, 500.0f));
            playerAnim.SetBool("1_jump", true);
            GetComponent<AudioSource>().PlayOneShot(Jumping);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            playerRigidBody.AddForce(new Vector2(0, jumpForce));
        }
    }

    void Die()
    {
        if(HP == 0)
        {
            GameOver.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(dieSound);
            Time.timeScale = 0;
            HP--;
        }
    }
}