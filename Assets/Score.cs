using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public GameObject scoreText; //Text用変数
    private int score = 0; //スコア計算用変数


	// Use this for initialization
	void Start () 
        {
            //シーン中のGameOverTextオブジェクトを取得
            this.scoreText = GameObject.Find("ScoreText");
            score = 0;
            SetScore(); //初期スコアを代入して表示
        }

// 小さい星は+10点、大きい星は+20点、小さい雲は+5点、大きい雲は+１点
void OnCollisionEnter( Collision collision ) {
        string Ball = collision.gameObject.tag;
        if (Ball == "SmallStarTag")
        {
            score += 10;
        }
    else if (Ball == "LargeStarTag")
        {
            score += 20;
        }
    else if (Ball == "SmallCloudTag")
        {
            score += 5;
        }
    else if (Ball == "LargeCloudTag")
        {
            score += 1;
        }
        SetScore();
    }
    void SetScore()
    {
        scoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}
