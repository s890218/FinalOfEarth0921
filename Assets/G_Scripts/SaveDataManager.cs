using UnityEngine;
using System.Collections;

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
}
