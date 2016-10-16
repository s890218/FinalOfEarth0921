using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (TStaticV.m_GameStart == false)
        {
            return;
        }

        TStaticV.m_TotalSpeed += Time.deltaTime * 0.01f;

    }
}
