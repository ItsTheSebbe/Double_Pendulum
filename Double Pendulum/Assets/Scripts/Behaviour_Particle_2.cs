﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Particle_2 : MonoBehaviour {

    float x1, y1;
    float x2, y2;
    float l2;
    float theta2;
	void Start () {
		
	}
	
	void Update () {
        x1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().x1;
        y1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().y1;
        l2 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().l2;
        x2 = x1 + l2 * Mathf.Sin(theta2 * Mathf.PI / 180);
        y2 = y1 - l2 * Mathf.Cos(theta2 * Mathf.PI / 180);
        transform.position = new Vector3(x2, y2, 0);
    }
}
