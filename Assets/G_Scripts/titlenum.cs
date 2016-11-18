using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class titlenum : MonoBehaviour {

    float a = 2;
    float b;
    public Text aa;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(notsofast());
	}
	
	// Update is called once per frame
	void Update () {
        //print(a);
	}
    IEnumerator notsofast()
    {
        while (a > 1)
        {
            a = Random.Range(1001, 9999);
            b = Random.Range(1001, 9999);
            aa.text = "Attenuation    " + a / 100 + "\nfrequency      " + b / 100;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
