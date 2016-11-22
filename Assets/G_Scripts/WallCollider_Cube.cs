using UnityEngine;
using System.Collections;

public class WallCollider_Cube : MonoBehaviour
{
    int m_Wall_HP = 5;
    int m_Wall_Score = 5;
    // Use this for initialization
    void Start()
    {

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
                Destroy(gameObject);
            }
        }
        else if (other.tag == "Player")
        {

        }
    }
}
