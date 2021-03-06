﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Particle_2 : MonoBehaviour {

    float x1, y1;
    public float x2, y2;
    float l2;
    float theta2;
    float scale2;

    private void Start()
    {
        scale2 = PlayerPrefs.GetFloat("scale2");
        transform.localScale = new Vector3(scale2, scale2, 1);
    }

    void Update () {
        x1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().x1;
        y1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().y1;
        l2 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().l2;
        theta2 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().theta2;
        x2 = x1 + l2 * Mathf.Sin(theta2);
        y2 = y1 - l2 * Mathf.Cos(theta2);
        transform.position = new Vector3(x2, y2, 0);
        LineRenderer line2 = GetComponent<LineRenderer>();
        line2.SetPosition(0, new Vector3(x1, y1, 0));
        line2.SetPosition(1, new Vector3(x2, y2, 0));
    }
}
