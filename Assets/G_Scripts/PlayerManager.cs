using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager _instance = null;

    private float m_Speed = 1;

    private bool m_isLeft = false;
    private bool m_isRight = false;
    public GameObject m_GameOverUI = null;
    public Text m_LbLifeTime = null;
    public Text m_LbKillCount = null;
    public Text m_LbTotalScore = null;

    public Text m_LbLifeTime_His = null;
    public Text m_LbKillCount_His = null;
    public Text m_LbTotalScore_His = null;

    //private float[] m_TotalRankScore = null;
    private List<float> m_TotalRankScore = null;
    public GameObject m_RankObj = null;

    private bool isSpeedUp = false;
    public Image m_SpeedUpImg = null;

    public void Awake()
    {
        _instance = this;
    }


    // Use this for initialization
    void Start()
    {
        m_GameOverUI.gameObject.SetActive(false);
        GetRankScore();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.A))
        {
            m_isLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            m_isLeft = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_isRight = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            m_isRight = false;
        }
        if (Input.GetKeyDown(KeyCode.W)&&TStaticV.m_GameStart==true)
        {
            Time.timeScale = 1.7f;
        }
        if (Input.GetKeyUp(KeyCode.W) && TStaticV.m_GameStart == true)
        {
            Time.timeScale = 1f;
        }
#else
        if (Input.acceleration.x > 0.15f)
        {
            SetMobMove(Input.acceleration.x);
            m_isLeft = false;
            m_isRight = true;
        }
        else if (Input.acceleration.x < -0.15f)
        {
            SetMobMove(Input.acceleration.x);
            m_isLeft = true;
            m_isRight = false;
        }
        else
        {
            m_isLeft = false;
            m_isRight = false;
        }
#endif

        SetMove();
    }

    private void SetMove()
    {
        float now_Speed = 1.5f * m_Speed * Time.deltaTime * TStaticV.m_TotalSpeed;
        if (m_isLeft && transform.position.x > -2.1f)
        {
            gameObject.transform.position += new Vector3(-now_Speed, 0, 0);
        }
        if (m_isRight && transform.position.x < 2.1f)
        {
            gameObject.transform.position += new Vector3(now_Speed, 0, 0);
        }
    }

    private void SetMobMove(float acc)
    {
        if (acc > 0.6f)
        {
            acc = 0.6f;
        }
        else if (acc < -0.6f)
        {
            acc = -0.6f;
        }
        float now_Speed = 2.5f * m_Speed * Time.deltaTime * TStaticV.m_TotalSpeed* acc;
        if (m_isLeft && transform.position.x > -2.1f)
        {
            gameObject.transform.position += new Vector3(now_Speed, 0, 0);
        }
        if (m_isRight && transform.position.x < 2.1f)
        {
            gameObject.transform.position += new Vector3(now_Speed, 0, 0);
        }
    }

    public float GetSpeed()
    {
        return m_Speed;
    }

    public void SetSpeed(float _speed)
    {
        m_Speed = _speed;
    }

    public void SetGameOver()
    {
        float lf = Time.time - TStaticV.m_LifeTime;
        float H_lf = SaveDataManager._inter.GetLifeTime();

        if (lf > H_lf)
        {
            SaveDataManager._inter.SetLifeTime(lf);
            m_LbLifeTime_His.text = lf.ToString("0.0");
        }
        else
        {
            m_LbLifeTime_His.text = H_lf.ToString("0.0");
        }
        m_LbLifeTime.text = lf.ToString("0.0");
        


        int kc =  TStaticV.m_KillCount;
        int H_kc = SaveDataManager._inter.GetKillCount();

        if (kc > H_kc)
        {
            SaveDataManager._inter.SetKillCount(kc);
            m_LbKillCount_His.text = kc.ToString("0.0");
        }
        else
        {
            m_LbKillCount_His.text = H_kc.ToString("0.0");
        }
        m_LbKillCount.text = kc.ToString();
        m_LbKillCount_His.text = H_kc.ToString();


        float ts =  TStaticV.m_RealScore;
        float H_ts = SaveDataManager._inter.GetTotalScore();

        if (ts > H_ts)
        {
            SaveDataManager._inter.SetTotalScore(ts);
            m_LbTotalScore_His.text = ts.ToString("0.0");
        }
        else
        {
            m_LbTotalScore_His.text = H_ts.ToString("0.0");
        }
        m_LbTotalScore.text = ts.ToString("0.0");
        m_LbTotalScore_His.text = H_ts.ToString("0.0");
        CheckRankScore(ts);
        Time.timeScale = 0;
        TStaticV.m_GameStart = false;
        m_GameOverUI.gameObject.SetActive(true);
    }

    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }

    public void ShowRank()
    {
        RankManager._instance.SetRankInit(m_TotalRankScore);
        m_RankObj.gameObject.SetActive(true);
        m_GameOverUI.gameObject.SetActive(false);
    }

    public void HideRank()
    {
        m_RankObj.gameObject.SetActive(false);
        m_GameOverUI.gameObject.SetActive(true);
    }

    private void GetRankScore()
    {
        m_TotalRankScore = SaveDataManager._inter.GetRankScoreArray();
    }

    private void CheckRankScore(float now_score)
    {
        for (int i = 0; i < m_TotalRankScore.Count; i++)
        {
            if (now_score > m_TotalRankScore[i])
            {
                //有新紀錄
                
                m_TotalRankScore.Insert(i, now_score);
                ChangeRank();
                return;
            }
        }
    }

    private void ChangeRank()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i > m_TotalRankScore.Count)
            {
                return;
            }
            SaveDataManager._inter.SetRankScore(m_TotalRankScore[i], i);
        }
    }

    public void OnClickSpeedUp()
    {
        if ( TStaticV.m_GameStart == true&& isSpeedUp == false)
        {
            Time.timeScale = 1.7f;
            isSpeedUp = true;
            m_SpeedUpImg.color = Color.red;
        }
        else if (TStaticV.m_GameStart == true && isSpeedUp == true)
        {
            Time.timeScale = 1f;
            isSpeedUp = false;
            m_SpeedUpImg.color = Color.green;
        }
    }
}
