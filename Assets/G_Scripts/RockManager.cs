using UnityEngine;
using System.Collections;

public class RockManager : MonoBehaviour {

    // Use this for initialization
    float m_RanSpeed = 1.05f;
    private int m_HP = 3;
    int m_Rock_Score = 4;
    void Start () {
        m_RanSpeed = Random.Range(0.95f, 1.55f);

    }
	
	// Update is called once per frame
	void Update () {
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
                TStaticV.m_KillScore += m_Rock_Score;
                Destroy(gameObject);
            }
        }
        else if (other.tag == "Player")
        {

        }
    }
}
