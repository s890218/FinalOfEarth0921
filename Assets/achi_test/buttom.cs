using UnityEngine;
using System.Collections;

public class buttom : MonoBehaviour {
    public GameObject cabinet;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnClick()
    {
        cabinet.GetComponentInChildren<cabinetcontroller>()._achi();
        cabinet.SetActive(!cabinet.activeInHierarchy);
    }

    public void addaa(GameObject btm)
    {
        //print("1");
        achievementDB._instance.addachievement(btm.GetComponent<achievement>());
    }
}
