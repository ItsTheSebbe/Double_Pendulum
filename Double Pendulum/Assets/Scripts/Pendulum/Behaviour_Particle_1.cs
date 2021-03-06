﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Particle_1 : MonoBehaviour
{
    public float x1; //properties p1
    public float y1;
    public float l1; 
    public float m1;
    public float theta1;
    float v1;
    float a1;
    float scale1;

    public float l2; //properties p2
    public float m2;
    public float theta2;
    float v2;
    float a2;

    float g; //used for calculations
    float framerate = 60;
    float dt;
    float dampening;
    float N1_1;
    float N2_1;
    float N3_1;
    float N4_1;
    float D1_1;
    float N1_2;
    float N2_2;
    float N3_2;
    float N4_2;
    float D1_2;

    void Start () {
        m1 = PlayerPrefs.GetFloat("m1"); //initial properties of p1
        l1 = PlayerPrefs.GetFloat("l1");
        theta1 = PlayerPrefs.GetFloat("theta1", theta1); ;
        v1 = 0;
        scale1 = PlayerPrefs.GetFloat("scale1");
        transform.localScale = new Vector3(scale1, scale1, 1);


        m2 = PlayerPrefs.GetFloat("m2"); //initial properties of p2
        l2 = PlayerPrefs.GetFloat("l2");
        theta2 = PlayerPrefs.GetFloat("theta2");
        v2 = 0;

        g = 9.81f; //gravitational constant
        dt = 0.16f / framerate;
        dampening = PlayerPrefs.GetFloat("dampening");
    }
	
	void Update () {
        Acceleration();
        v1 = v1 + a1 *dt;
        v2 = v2 + a2 * dt;
        theta1 = theta1 + v1;
        theta2 = theta2 + v2;
        v1 = v1 * dampening;
        v2 = v2 * dampening;

        Position();

	}
    void Acceleration()
    {
        N1_1 = -g * (2 * m1 + m2) * Mathf.Sin(theta1);
        N2_1 = -m2 * g * Mathf.Sin(theta1 - 2 * theta2);
        N3_1 = -2 * Mathf.Sin(theta1 - theta2) * m2;
        N4_1 = v2 * v2 * l2 + v1 * v1 * l1 * Mathf.Cos(theta1 - theta2);
        D1_1 = l1 * (2 * m1 + m2 - m2 * Mathf.Cos(2 * theta1 - 2 * theta2));

        a1 = (N1_1 + N2_1 + N3_1*N4_1) / D1_1;

        N1_2 = 2 * Mathf.Sin(theta1 - theta2);
        N2_2 = v1 * v1 * l1 * (m1 + m2);
        N3_2 = g * (m1 + m2) * Mathf.Cos(theta1);
        N4_2 = v2*v2*l2*m2*Mathf.Cos(theta1-theta2);
        D1_2 = l2 * (2 * m1 + m2 - m2 * Mathf.Cos(2 * theta1 - 2 * theta2));
        
        a2 = N1_2*(N2_2+N3_2+N4_2)/D1_2;
    }

    void Position()
    {
        x1 = l1 * Mathf.Sin(theta1);
        y1 = -l1 * Mathf.Cos(theta1);
        transform.position = new Vector3(x1, y1, 0);
        LineRenderer line1 = GetComponent<LineRenderer>();
        line1.SetPosition(0, new Vector3(0, 0, 0));
        line1.SetPosition(1, new Vector3(x1, y1, 0));
    }
    
}
