﻿using UnityEngine;
using System.Collections;

public class achievement : MonoBehaviour {

    public string name;
    public enum Type { type_a, type_b, type_c };
    public Type type;

    public Sprite sprite;
	// Use this for initialization
	void Start ()
    {
	    
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseEnter()
    {
        transform.parent.parent.parent.parent.parent.GetComponent<text>().title = name;
        transform.parent.parent.parent.parent.parent.GetComponent<text>().detail = type.ToString();
    }
}