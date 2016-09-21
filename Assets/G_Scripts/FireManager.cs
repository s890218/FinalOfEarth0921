using UnityEngine;
using System.Collections;

public class FireManager : MonoBehaviour {

    public GameObject m_CloneBullet = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(m_CloneBullet,gameObject.transform.position,Quaternion.identity);
        }

	}
}
