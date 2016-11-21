using UnityEngine;
using System.Collections;

public class achievement : MonoBehaviour {

    public string name;
    public enum Type { type_a, type_b, type_c };
    public Type type;
    GameObject g;

    public Sprite sprite;
	// Use this for initialization
	void Start ()
    {
        g = GameObject.Find("achimenu");
	}

    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print(gameObject.name);
            transform.parent.parent.parent.parent.GetComponent<text>().title = name;
            transform.parent.parent.parent.parent.GetComponent<text>().detail = type.ToString();
        }*/
    }
    
    public void onhit()
    {
        g.GetComponent<text>().title = name;
        g.GetComponent<text>().detail = type.ToString();
    }
}
