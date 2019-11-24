using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    GameObject player;
    GameObject hpGauge;

    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("Chu2Girl"); //追加
        this.hpGauge = GameObject.Find("hpGauge");

    }
	
	// Update is called once per frame
	void Update () {

    　　//フレームごとに等速で落下させる
        transform.Translate(0, -0.1f, 0);

        //画面外に出たらオブジェクトを破棄する
        if(transform.position.y < -2.2f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position; //矢の中心座標
        Vector2 p2 = this.player.transform.position;　//プレイヤの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //矢の半径
        float r2 = 0.5f; //プレイヤの半径

        if(d < r1 + r2)
        {
            //監督スクリプトにプレイヤと衝突したことを伝える
            GameObject boss = GameObject.Find("GameBoss");
            boss.GetComponent<GameBoss>().DecreaseHp();

            //衝突した場合は矢を消す
            Destroy(gameObject);
        }

        if (this.hpGauge.GetComponent<Image>().fillAmount == 0f)
        {
            GameObject.Find("GameBoss").GetComponent<GameBoss>().GameOver();
        }
    }
}
