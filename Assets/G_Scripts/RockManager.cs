using UnityEngine;
using System.Collections;

public class RockManager : MonoBehaviour
{
    float m_RanSpeed = 1.05f;
    private int m_HP = 3;
    int m_Rock_Score = 4;

    void Start ()
    {
        m_RanSpeed = Random.Range(0.95f, 1.55f);
    }
	
	void Update ()
    {
        transform.localPosition -= new Vector3(0, 0, 0.5f * Time.deltaTime* m_RanSpeed * TStaticV.m_TotalSpeed);
        transform.Rotate(0, 0, 20*Time.deltaTime* m_RanSpeed * TStaticV.m_TotalSpeed);
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);//移除子彈
            m_HP--;
            if (m_HP < 0)
            {
                if (this.tag == "rock01" && PlayerPrefs.GetInt("rock01") == 0)
                {
                    PlayerPrefs.SetInt("rock01", 1);
                }
                if (this.tag == "rock02" && PlayerPrefs.GetInt("rock02") == 0)
                {
                    PlayerPrefs.SetInt("rock02", 1);
                }
                if (this.tag == "rock03" && PlayerPrefs.GetInt("rock03") == 0)
                {
                    PlayerPrefs.SetInt("rock03", 1);
                }
                if (this.tag == "rock04" && PlayerPrefs.GetInt("rock04") == 0)
                {
                    PlayerPrefs.SetInt("rock04", 1);
                }
                if (this.tag == "rock05" && PlayerPrefs.GetInt("rock05") == 0)
                {
                    PlayerPrefs.SetInt("rock05", 1);
                }

                TStaticV.m_KillScore += m_Rock_Score;
                Destroy(gameObject);
            }
        }
        else if (other.tag == "Player")
        {

        }
    }
}
