using UnityEngine;
using System.Collections;

public class CreateManager : MonoBehaviour
{

    public static CreateManager _instance = null;

    public GameObject[] m_ArrayCloneObj = null;
    public GameObject[] m_ArrayTotalRock = null;
    private Vector3 m_StartPos = new Vector3(0, 0, 0);
    private Vector3 m_NextPos = new Vector3(0, 0, 40);

    private float m_CloneWallTime = 0;
    public void Awake()
    {
        _instance = this;
    }

    //TStaticV.m_NowIndex



    // Use this for initialization
    void Start()
    {
        CreateNext();
        TStaticV.m_GameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        float _math = 20 / (0.5f  * TStaticV.m_TotalSpeed);
        m_CloneWallTime += Time.deltaTime;
        if (m_CloneWallTime > _math)
        {
            m_CloneWallTime = 0;
            CreateNext();
        }
    }

    public void CreateNext()
    {
        if (m_ArrayCloneObj == null || m_ArrayCloneObj.Length == 0)
        {
            return;
        }
        TStaticV.m_NowIndex++;
        int ran_index = Random.Range(0, m_ArrayCloneObj.Length);
        Vector3 pos = m_StartPos + m_NextPos;// * TStaticV.m_NowIndex;
        GameObject obj_clone = Instantiate(m_ArrayCloneObj[ran_index], pos, Quaternion.identity) as GameObject;

        if (TStaticV.m_NowIndex % 8 == 0)
        {
            TStaticV.m_NowRockRank++;
        }
        if (obj_clone == null)
        {
            return;
        }

    }

}
