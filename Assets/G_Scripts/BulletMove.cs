using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public float m_Speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(0, 0, 5f * Time.deltaTime);
	}
}
