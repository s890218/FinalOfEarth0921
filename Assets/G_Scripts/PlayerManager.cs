using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

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

    public void Awake()
    {
        _instance = this;
    }


    // Use this for initialization
    void Start()
    {
        m_GameOverUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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

        Time.timeScale = 0;
        TStaticV.m_GameStart = false;
        m_GameOverUI.gameObject.SetActive(true);
    }

    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
    }

}
