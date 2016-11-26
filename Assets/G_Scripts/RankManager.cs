using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class RankManager : MonoBehaviour
{

    public static RankManager _instance = null;

    public GridLayoutGroup m_Grid = null;
    public Transform m_traGrid = null;
    public GameObject m_Unit = null;
    private GameObject[] m_TotalUnit = null;
    public void Awake()
    {
        _instance = this;
        gameObject.SetActive(false);
        gameObject.transform.localPosition = Vector3.zero;
    }

    public void SetRankInit(List<float> total_score)
    {
        if (m_TotalUnit == null || m_TotalUnit.Length < 10)
        {
            m_TotalUnit = new GameObject[10];
            for (int i = 0; i < 10; i++)
            {
                GameObject _clone = Instantiate(m_Unit) as GameObject;
                //_clone.transform.parent = m_traGrid;
                _clone.transform.SetParent(m_traGrid);
                _clone.transform.localScale = Vector3.one;
                m_TotalUnit[i] = _clone;
                LeaderBoard lb = _clone.GetComponent<LeaderBoard>();
                if (lb != null&& total_score[i]!=0)
                {
                    lb.SetScore(i,total_score[i]);
                }
            }
        }
    }


}
