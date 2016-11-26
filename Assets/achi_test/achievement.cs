using UnityEngine;
using System.Collections;

public class achievement : MonoBehaviour {

    public string name;
    public enum Type { type_a, type_b, type_c, type_d, type_e};
    public Type type;
    GameObject g;

    public Sprite sprite;
	
	void Start ()
    {
        g = GameObject.Find("achimenu");
	}
    
    public void onhit()
    {
        g.GetComponent<text>().title = name;
        g.GetComponent<text>().detail = type.ToString();
    }
}
