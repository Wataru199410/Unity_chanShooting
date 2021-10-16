using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackCtrl : MonoBehaviour
{
    private float delta = 0;
    private float AttackSpan = 2.0f;
    public GameObject EnemyBulletPrefab;//インスペクターからEnemyBulletを取得する


    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if(this.delta > AttackSpan){
            this.delta = 0;
            Instantiate(EnemyBulletPrefab , new Vector3(transform.position.x - 1.0f  , transform.position.y , transform.position.z ) , Quaternion.identity);
        }
    }
}
