using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class achitext : MonoBehaviour {

    public Transform tt;
    
	// Use this for initialization
	void Start ()
    {
        reflesh();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void reflesh()
    {
        GetComponent<Text>().text.Replace("\\n", "\n");
        GetComponent<Text>().text = ("Name：" + tt.GetComponent<text>().title + "\n" + tt.GetComponent<text>().detail);
    }
}
