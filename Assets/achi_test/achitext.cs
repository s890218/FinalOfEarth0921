using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class achitext : MonoBehaviour
{
    public Transform tt;
    
	void Start ()
    {
        reflesh();
    }

    public void reflesh()
    {
        GetComponent<Text>().text.Replace("\\n", "\n");
        GetComponent<Text>().text = ("Name：" + tt.GetComponent<text>().title + "\n" + tt.GetComponent<text>().detail);
    }
}
