using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chu2Controller : MonoBehaviour {

    //左ボタン押下の判定（追加）
    private bool isLButtonDown = false;
    //右ボタン押下の判定（追加）
    private bool isRButtonDown = false;

    //左右の移動できる範囲(追加)
    private float movableRange = 3.8f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //矢印キーまたはボタンに応じて左右に移動させる（追加）
                if ((Input.GetKey(KeyCode.LeftArrow) || this.isLButtonDown) && -this.movableRange < this.transform.position.x)
        {
            //左に移動
            transform.Translate(-0.1f, 0, 0); //左に動かす
            transform.eulerAngles = new Vector3(0, 360, 0);
        }
        else if ((Input.GetKey(KeyCode.RightArrow) || this.isRButtonDown) && this.transform.position.x < this.movableRange)
        {
            //右に移動
            transform.Translate(-0.1f, 0, 0); //右に動かす
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
                
	}

    //左ボタンを押し続けた場合の処理（追加）
    public void GetMyLeftButtonDown()
    {
        this.isLButtonDown = true;
    }
    //左ボタンを離した場合の処理（追加）
    public void GetMyLeftButtonUp()
    {
        this.isLButtonDown = false;
    }

    //右ボタンを押し続けた場合の処理（追加）
    public void GetMyRightButtonDown()
    {
        this.isRButtonDown = true;
    }
    //右ボタンを離した場合の処理（追加）
    public void GetMyRightButtonUp()
    {
        this.isRButtonDown = false;
    }
}
