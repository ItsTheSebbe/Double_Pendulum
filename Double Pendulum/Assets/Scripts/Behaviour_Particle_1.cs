using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Particle_1 : MonoBehaviour
{
    public GameObject Particle1;
    public float l1; //properties p1
    public float m1;
    public float theta1;
    public float x1;
    public float y1;
    float v1;
    float a1;

    public float l2; //properties p2
    public float m2;
    public float theta2;
    float x2;
    float y2;
    float v2;
    float a2;

    float g; //used for calculations
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

        m1 = 100; //initial properties of p1
        l1 = 5;
        theta1 = 1; //in degrees
        v1 = 0;


        m2 = 100; //initial properties of p2
        l2 = 5;
        theta2 = 0; //in degrees
        v2 = 0;

        g = 100; //gravitational constant
    }
	
	void Update () {
        Acceleration();
        
        v1 = v1 + a1;
        theta1 = theta1 + v1;

        v2 = v2 + a2;
        theta2 = theta2 + v2;

        Position();
	}

    void Acceleration()
    {
        N1_1 = -g * (2 * m1 + m2) * Mathf.Sin(theta1 * Mathf.PI / 180);
        N2_1 = -m2 * g * Mathf.Sin((theta1 - 2 * theta2) * Mathf.PI / 180);
        N3_1 = -2 * Mathf.Sin((theta1 - theta2) * Mathf.PI / 180) * m2;
        N4_1 = v2 * v2 * l2 + v1 * v1 * l1 * Mathf.Cos((theta1 - theta2) * Mathf.PI / 180);
        D1_1 = l1 * (2 * m1 + m2 - m2 * Mathf.Cos((2 * theta1 - 2 * theta2) * Mathf.PI / 180));

        a1 = (N1_1 + N2_1 + N3_1*N4_1) / D1_1;

        N1_2 = 2 * Mathf.Sin((theta1 - theta2) * Mathf.PI / 180);
        N2_2 = v1 * v1 * l1 * (m1 + m2);
        N3_2 = g * (m1 + m2) * Mathf.Cos(theta1 * Mathf.PI / 180);
        N4_2 = v2*v2*l2*m2*Mathf.Cos((theta1-theta2) * Mathf.PI / 180);
        D1_2 = l2 * (2 * m1 + m2 - m2 * Mathf.Cos((2 * theta1 - 2 * theta2) * Mathf.PI / 180));
        
        a2 = N2_1*(N2_2+N3_2+N4_2)/D1_2;
    }

    void Position()
    {
        x1 = l1 * Mathf.Sin(theta1 * Mathf.PI/180);
        y1 = -l1 * Mathf.Cos(theta1 * Mathf.PI / 180);
        transform.position = new Vector3(x1, y1, 0);
    }
}
