using UnityEngine;
using System.Collections;

public class WallSelfManager : MonoBehaviour
{

    public GameObject Top_RockMakePos = null;
    private RockMakePos[] Total_Pos = null;
    private GameObject[] m_TotalRock = null;
    public void Awake()
    {
        if (Top_RockMakePos != null)
        {
            Total_Pos = Top_RockMakePos.GetComponentsInChildren<RockMakePos>();
        }
        
    }



    // Use this for initialization
    void Start()
    {
        m_TotalRock = CreateManager._instance.m_ArrayTotalRock;
        if (Total_Pos == null || Total_Pos.Length == 0|| m_TotalRock == null)
        {
            return;
        }
        for (int i = 0; i < Total_Pos.Length; i++)
        {
            int ran = Random.Range(0, 15);
            if (ran < TStaticV.m_NowRockRank)
            {
                int ran2 = Random.Range(0, m_TotalRock.Length);
                Instantiate(m_TotalRock[ran2], Total_Pos[i].gameObject.transform.position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
