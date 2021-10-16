using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletCtrl : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    private GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Second);
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.Enemy = GameObject.Find("Enemy");
        rigid2D.AddForce(new Vector2(-200 , Random.Range(-50.0f , 50.0f))); //Randomを使うことで敵の弾の軌道を変える       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > Screen.width || transform.position.y > Screen.height || transform.position.x < -10 || transform.position.y < -3){
            Destroy(gameObject);
        }
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        //プレイヤーの弾以外に当たったら削除
        if(other.gameObject.tag != "PlayerBullet"){
            Destroy(gameObject);
        }
    }
}
