using UnityEngine;
using System.Collections;

public class text : MonoBehaviour
{
    public string title;
    public string detail;
	
	void Update ()
    {
        transform.GetChild(0).GetChild(0).GetComponent<achitext>().reflesh();
    }
}
