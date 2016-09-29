using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class achitext : MonoBehaviour {

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
        GetComponent<Text>().text = ("名稱：" + transform.parent.parent.GetComponent<text>().title + "\n詳細：" + transform.parent.parent.GetComponent<text>().detail);
    }
}
