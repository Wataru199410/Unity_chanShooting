using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletCtrl : MonoBehaviour
{
    private Rigidbody2D rigid2D;

    // Update is called once per frame

    void Start(){
        this.rigid2D = GetComponent<Rigidbody2D>();

        rigid2D.AddForce(new Vector2(5 , Input.mousePosition.y * 0.033f) , ForceMode2D.Impulse);//クリックしたあたりに弾が飛ぶようになる   


    }
     void Update()
    {           
        if(transform.position.x > Screen.width || transform.position.y > Screen.height || transform.position.x < -10 || transform.position.y < -3){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //敵の弾以外に当たったらObj削除
        if(other.gameObject.tag != "EnemyBullet"){
            Destroy(gameObject);
        }
    }
}
