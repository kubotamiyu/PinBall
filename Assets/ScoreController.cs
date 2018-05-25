using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //  得点を表示するテキスト
    private GameObject scoreText;
    //  得点
    private int score = 0;

    //  Use this for initialization
    void Start()
    {
        //  シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

        this.scoreText.GetComponent<Text>().text = score.ToString();
    }

        //  衝突時に呼ばれる関数
        void OnCollisionEnter(Collision other)        {
        if (other.gameObject.tag == "LargeStarTag")//   衝突した相手のタグをチェックする
        {
            //  タグによって異なる値をscoreに足す
            score += 20; // scoreに20を足す
            this.scoreText.GetComponent<Text>().text = score.ToString();
            //  スコアの表示を更新する
        }
        if(other.gameObject.tag == "SmallStarTag")
        {
            score += 10;//  scoreに10を足す
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }
        if(other.gameObject.tag == "LargeCloudTag")
        {
            score += 100;// scoreに100を足す
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }
        if(other.gameObject.tag == "SmallCloudTag")
        {
            score += 30;//  scoreに30を足す
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }
        
        

        }
        
}
