using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBoss : MonoBehaviour
{

    GameObject hpGauge;

    // 走行距離テキスト
    private GameObject TimeDirectorText;

    // ゲームオーバテキスト
    private GameObject gameOverText;

    // ゲームオーバの判定
    private bool isGameOver = false;

    // ゲームクリアテキスト
    private GameObject gameClearText;

    // ゲームクリアの判定
    private bool isGameClear = false; 

    // Use this for initialization
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");

        this.gameOverText = GameObject.Find("GameOver");

        this.gameClearText = GameObject.Find("GameClear");

        this.TimeDirectorText = GameObject.Find("Timer");
    }

    void Update()
    {
        // ゲームオーバになった場合
        if (this.isGameOver == true)
        {
            //Time.timeScale = 0;
            GameObject target = GameObject.Find("Timer");
            Destroy(target);

            // クリックされたらシーンをロードする（追加）
            if (Input.GetMouseButtonDown(0))
            {
                //GameSceneを読み込む（追加）
                SceneManager.LoadScene("Chu2Revoir");
            }
        }

        // ゲームクリアになった場合
        if (this.isGameClear == true)
        {
            //Time.timeScale = 0;
            GameObject target2 = GameObject.Find("EnemyGenerator");
            Destroy(target2);

            GameObject target= GameObject.Find("Timer");
            Destroy(target);

            // クリックされたらシーンをロードする（追加）
            if (Input.GetMouseButtonDown(0))
            {
                //GameSceneを読み込む（追加）
                SceneManager.LoadScene("Chu2Merci");
            }

        }
    }

        public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.21f;
    }

    public void GameOver()
    {
        // ゲームオーバになったときに、画面上にゲームオーバを表示する
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }

    public void GameClear()
    {
        // ゲームクリアになったときに、画面上にゲームクリアを表示する
        this.gameClearText.GetComponent<Text>().text = "Game Clear";
        this.isGameClear = true;
    }
}