using UnityEngine;
using System.Collections;

public class PlaneManager : MonoBehaviour {

    private float m_Speed = 1;
    public GameObject[] m_TotalPlane = null;
    private int m_next = -200;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position += new Vector3(0, 0, -m_Speed* TStaticV.m_TotalSpeed * Time.deltaTime*1f);
        if (transform.position.z < m_next)
        {
            m_next -= 200;
            for (int i = 0; i < m_TotalPlane.Length; i++)
            {
                m_TotalPlane[i].transform.localPosition += new Vector3(0, 0, 200);
            }
        }
	}
}
