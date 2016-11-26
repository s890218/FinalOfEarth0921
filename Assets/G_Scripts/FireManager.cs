using UnityEngine;
using System.Collections;

public class FireManager : MonoBehaviour {

    public GameObject m_CloneBullet = null;
    private float m_TimeCD = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.Space))
        {
            MakeBullet();
        }
#else
        if (Input.touchCount > 0)
        {
            MakeBullet();
            //Instantiate(m_CloneBullet,gameObject.transform.position, m_CloneBullet.transform.rotation);
        }
#endif

    }

    private void MakeBullet()
    {
        if (m_TimeCD < Time.time)
        {
            m_TimeCD = Time.time + 0.25f;
            Instantiate(m_CloneBullet, gameObject.transform.position, m_CloneBullet.transform.rotation);
        }
    }
}
