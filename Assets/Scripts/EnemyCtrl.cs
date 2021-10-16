using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCtrl : MonoBehaviour
{
    private float delta = 0;
    private float AttackSpan = 1.0f;
    public GameObject EnemyBulletPrefab;
    private Slider enemyHP;

    // Start is called before the first frame update
    void Start()
    {
        this.enemyHP = transform.Find("Canvas/EnemyHP").GetComponent<Slider>();//このスクリプトがアタッチされているEnemyのHPゲージを取得
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.enemyHP.value <= 0){
            Destroy(gameObject);
        }

        if(this.delta > AttackSpan){
            this.delta = 0;
            Instantiate(EnemyBulletPrefab , new Vector3(transform.position.x - 1.0f  , transform.position.y , transform.position.z ) , Quaternion.identity);;
        }
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        //Playerの攻撃が当たったらHPを-1
        if(other.gameObject.tag == "PlayerBullet"){
            this.enemyHP.value -= 1.0f;
        }
    }

}
    



        

    
