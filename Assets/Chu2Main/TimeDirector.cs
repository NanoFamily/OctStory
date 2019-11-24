using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeDirector : MonoBehaviour
{
   
    // 走行距離テキスト
    private GameObject TimeDirectorText;

    float time1 = 0;//時間を記録する小数も入る変数.

    void Start()
    {
        // シーンビューからオブジェクトの実体を検索する
        this.TimeDirectorText = GameObject.Find("Timer");
    }

    void Update()
    {
        time1 += Time.deltaTime;//毎フレームの時間を加算.
        this.TimeDirectorText.GetComponent<Text>().text = "Time: " + time1.ToString("f1");  

        if (time1 > 60f)
        {
            GameObject.Find("GameBoss").GetComponent<GameBoss>().GameClear();
        }
    }
}
