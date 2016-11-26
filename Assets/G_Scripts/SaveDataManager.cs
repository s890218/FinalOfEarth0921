using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SaveDataManager : MonoBehaviour
{

    public static SaveDataManager _inter = null;

    public void Awake()
    {
        if (_inter == null)
        {
            _inter = this;
        }
    }

    public void SetLifeTime(float lf)
    {
        PlayerPrefs.SetFloat("LifeTime", lf);
    }

    public float GetLifeTime()
    {
        float lf = PlayerPrefs.GetFloat("LifeTime", 0);
        return lf;
    }

    public void SetKillCount(int kc)
    {
        PlayerPrefs.SetFloat("KillCount", kc);
    }

    public int GetKillCount()
    {
        int kc = PlayerPrefs.GetInt("KillCount", 0);
        return kc;
    }

    public void SetTotalScore(float ts)
    {
        PlayerPrefs.SetFloat("TotalScore", ts);
    }

    public float GetTotalScore()
    {
        float ts = PlayerPrefs.GetFloat("TotalScore", 0);
        return ts;
    }

    public void SetRankScore(float score, int index)
    {
        PlayerPrefs.SetFloat("RankScore"+ index, score);
    }

    public float GetRankScore( int index)
    {
        //排行榜分數 會帶0~9 表示1~10名
        float score = PlayerPrefs.GetFloat("RankScore" + index, 0);
        return score;
    }

    public List<float> GetRankScoreArray()
    {
        List<float> f_array_score = new List<float>();

        for (int i = 0; i < 10; i++)
        {
            f_array_score.Add(GetRankScore(i));
        }
        return f_array_score;
    }
}
