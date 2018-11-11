using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition1 : MonoBehaviour {

    public float x1; //properties p1
    public float y1;
    public float l1;
    public float m1;
    public float theta1;
    float scale1;

    // Use this for initialization
    void Start ()
    {
        l1 = 5;
        m1 = 5;
        theta1 = Mathf.PI / 2;
        scale1 = 1.5f * (m1 - 0.5f) / (49.5f) + 0.5f;
        PlayerPrefs.SetFloat("l1", l1);
        PlayerPrefs.SetFloat("m1", m1);
        PlayerPrefs.SetFloat("theta1", theta1);
        PlayerPrefs.SetFloat("scale1", scale1);
        transform.localScale = new Vector3(scale1, scale1, 1);
    }
	
	// Update is called once per frame
	void Update ()
    { 
        x1 = l1 * Mathf.Sin(theta1);
        y1 = -l1 * Mathf.Cos(theta1);
        transform.position = new Vector3(x1, y1, 0);
    }

    public void AdjustL1(float newL1)
    {
        l1 = newL1;
        PlayerPrefs.SetFloat("l1", l1);
    }
    public void AdjustM1(float newM1)
    {
        m1 = newM1;
        PlayerPrefs.SetFloat("m1", m1);
        scale1 = 1.5f * (m1 - 0.5f) / (49.5f) + 0.5f;
        transform.localScale = new Vector3(scale1,scale1, 1);
        PlayerPrefs.SetFloat("scale1", scale1);
    }
    public void AdjustTheta1(float newTheta1)
    {
        theta1 = newTheta1;
        PlayerPrefs.SetFloat("theta1", theta1);
    }
}
