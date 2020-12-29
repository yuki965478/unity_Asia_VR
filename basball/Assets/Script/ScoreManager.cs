using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn = 2;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        //音效來源=取得元件<音效來源>()
        aud = GetComponent<AudioSource>();
    }

    //OTE條件：
    //兩個碰撞物件 其中一個 必須勾選IsTrigger
    //要偵測此腳本子物件是否產生碰撞
    //必須添加鋼體Rigibody
    private void OnTriggerEnter(Collider other)
    {
        //果 碰撞物件的標籤為籃球 就加分
        if(other.tag=="籃球")
        {
            AddScore();
        }
        //如果碰撞的物件名稱為Player
        if(other.transform.root.name=="Player")
        {
            //玩家進入三分區域，將投進的分數改為三分
            scoreIn = 3;
        }
   
    }
    //當碰撞物件離開碰撞範圍時執行一次
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.root.name=="Player")
        {
            //將投進的分數改為兩分
            scoreIn = 2;
        }
    }
    /// <summary>
    /// 加分數
    /// </summary>
    private void AddScore()
    {
        score += scoreIn;                                                                   //分數遞增
        textScore.text = "分數" + score;                                         //更新介面
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));     //音效來源波(音效片段，音量)
    }

}
