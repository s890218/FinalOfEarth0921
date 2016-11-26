using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LeaderBoard : MonoBehaviour {
    public Text m_Ranker = null;
    public Text m_Score = null;

    private bool isNeedInit = true;

	// Use this for initialization
	void Start () {
        if (m_Score != null&& isNeedInit==true)
        {
            m_Ranker.text = "--";
            m_Score.text = "0";
        }
    }

    public void SetScore(int ranker , float score)
    {
        m_Ranker.text = "NO." + (ranker+1);
        m_Score.text = "" + score.ToString("0.0");
        isNeedInit = false;
    }
}
