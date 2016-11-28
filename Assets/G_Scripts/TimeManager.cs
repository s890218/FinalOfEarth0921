using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public Text m_ScoreText = null; 

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (TStaticV.m_GameStart == false)
        {
            return;
        }

        TStaticV.m_TotalSpeed += Time.deltaTime * 0.015f;
		float score = TStaticV.m_TotalSpeed * 10 + TStaticV.m_KillScore + TStaticV.m_NowIndex-11.0f;
        TStaticV.m_RealScore = score;
        m_ScoreText.text = score.ToString("0.0");
    }
}
