using UnityEngine;
using System.Collections;

public class RockManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition -= new Vector3(0, 0, 0.5f * Time.deltaTime);
        transform.Rotate(0, 0, 20*Time.deltaTime);
	}
}
