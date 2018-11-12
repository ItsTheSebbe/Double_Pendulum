using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextL1 : MonoBehaviour
{

    Text L1;

	// Use this for initialization
	void Start () {
        L1 = GetComponent<Text>();
	}
	
    public void textUpdate(float l1)
    {
        L1.text = "Length 1 = " + Math.Round(GameObject.Find("Particle1").GetComponent<StartPosition1>().l1,2) + " m";
    }
}
