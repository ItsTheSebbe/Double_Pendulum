using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition2 : MonoBehaviour {
    float x1, y1;
    float x2, y2;
    public float l2, m2;
    public float theta2;

    private void Start()
    {
        l2 = 5;
        m2 = 5;
        PlayerPrefs.SetFloat("l2", l2);
        PlayerPrefs.SetFloat("m2", m2);
    }
    void Update()
    {
        x1 = GameObject.Find("Particle1").GetComponent<StartPosition1>().x1;
        y1 = GameObject.Find("Particle1").GetComponent<StartPosition1>().y1;
        x2 = x1 + l2 * Mathf.Sin(theta2);
        y2 = y1 - l2 * Mathf.Cos(theta2);
        transform.position = new Vector3(x2, y2, 0);
    }

    public void AdjustL2(float newL2)
    {
        l2 = newL2;
        PlayerPrefs.SetFloat("l2", l2);
    }

    public void AdjustM2(float newM2)
    {
        m2 = newM2;
        PlayerPrefs.SetFloat("m2", m2);
    }
}
