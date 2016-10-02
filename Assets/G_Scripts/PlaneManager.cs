using UnityEngine;
using System.Collections;

public class PlaneManager : MonoBehaviour {

    private float m_Speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, -m_Speed * Time.deltaTime*0.5f);
	}
}
