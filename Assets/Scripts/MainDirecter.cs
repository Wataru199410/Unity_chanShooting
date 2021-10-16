using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainDirecter : MonoBehaviour
{       
    private Slider playerHP;

    private GameObject[] enemyobjects;

    // Start is called before the first frame update
    void Start()
    {
        this.playerHP = GameObject.Find("Canvas/PlayerHP").GetComponent<Slider>();
    }


    // Update is called once per frame
    void Update()
    {
        enemyobjects = GameObject.FindGameObjectsWithTag("Enemy");
        //敵が全滅したらクリア画面へ
        if(enemyobjects.Length == 0){
            SceneManager.LoadScene("Clear");
        }

        //playerのHPがなくなったらゲームオーバー画面へ
        if(this.playerHP.value == 0){
            SceneManager.LoadScene("Gameover");
        }
    }
}



