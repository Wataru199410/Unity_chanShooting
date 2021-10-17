using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody2D rigid2d;
    private Animator animator;
    public GameObject bulletPrefab;//弾のプレハブを取得するため
    public GameObject Aimprefab;//照準画像のプレハブを取得するため
    private float walkForce = 30.0f;
    private const float maxSpeed = 2.0f;

    private Vector2 worldMousePosition;

    private float delta = 3.0f;
    private const float attackSpanTime = 1.5f;
    // private float Speed;
    private Slider playerHP;

    private const float jumpHeightLimit = -2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2d = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.playerHP = transform.Find("Canvas/PlayerHP").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        float speedx = Mathf.Abs(this.rigid2d.velocity.x);
        
        //アニメーション管理用フラグ
        bool attackFlag = false;
        bool jumpFlag = false;

        if(Input.GetMouseButtonUp(0) && this.delta >= attackSpanTime){
            this.delta = 0;
            attackFlag = true;
            worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bulletPrefab , new Vector3(transform.position.x + 0.5f , transform.position.y + 0.3f , transform.position.z) , Quaternion.identity);
            Instantiate(Aimprefab , worldMousePosition , Quaternion.identity);//クリックしたところに照準の画像をだす
        }


        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y <= jumpHeightLimit){
            jumpFlag = true;
            this.rigid2d.AddForce(transform.up * 500.0f);
        }
        this.animator.SetBool("JumpFlag" , jumpFlag);

        if(speedx < maxSpeed){
            if(Input.GetKey(KeyCode.RightArrow)){
                this.rigid2d.AddForce(transform.right * 1 * this.walkForce);
            }
            if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10){
                this.rigid2d.AddForce(transform.right * -1 * this.walkForce);
            }
        }
        this.animator.SetFloat("Speed" , speedx);
        this.animator.SetBool("AttackFlag" , attackFlag);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "EnemyBullet"){
            this.playerHP.value -= 1.0f;
            Debug.Log(this.playerHP.value);
        }
    }
}
