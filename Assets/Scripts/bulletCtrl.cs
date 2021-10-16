using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletCtrl : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    private Vector2 clickPosition;
    private GameObject Player;
    private PlayerCtrl PlayerScript;
    // Update is called once per frame

    void Start(){
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.Player = GameObject.Find("Player");
        this.PlayerScript = Player.GetComponent<PlayerCtrl>();

        this.clickPosition = this.PlayerScript.mousePosition;//このプレハブが作成された際にクリックした座標をPlayerObjectから取得

            this.clickPosition = Input.mousePosition;
            rigid2D.AddForce(new Vector2(5 , clickPosition.y * 0.02f) , ForceMode2D.Impulse);//クリックしたあたりに弾が飛ぶようになる   
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
