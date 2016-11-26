using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class titlenum : MonoBehaviour {

    float a = 2;
    float b;
    public Text aa;
    
	void Start ()
    {
        StartCoroutine(notsofast());
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
