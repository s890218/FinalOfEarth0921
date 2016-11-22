using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition -= new Vector3(0, 0, 0.5f * Time.deltaTime* TStaticV.m_TotalSpeed);
    }
}
