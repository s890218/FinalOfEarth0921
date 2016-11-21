using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {
    public string title;
    public string detail;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.GetChild(0).GetChild(0).GetComponent<achitext>().reflesh();
    }
    /*
    public void textreflesh(buttom btm)
    {
        title = btm.GetComponent<achievement>().name;
        detail = btm.GetComponent<achievement>().type.ToString();
        
    }*/
}
