using UnityEngine;
using System.Collections;

public class WallCollider_Cube : MonoBehaviour
{
    int m_Wall_HP = 7;
    int m_Wall_Score = 5;
    // Use this for initialization
    void Start()
    {
        m_Wall_HP = 7 + Mathf.FloorToInt(TStaticV.m_TotalSpeed*6);
        m_Wall_Score = 5 + TStaticV.m_NowIndex / 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);//移除子彈
            //Debug.Log("被子彈打到 : " + gameObject.name);
            m_Wall_HP--;
            if (m_Wall_HP < 0)
            {
                TStaticV.m_KillScore += m_Wall_Score;
				TStaticV.m_KillCount++;
                Destroy(gameObject);
            }
        }
        else if (other.tag == "Player")
        {

        }
    }
}
