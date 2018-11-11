using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition2 : MonoBehaviour {
    float x1, y1;
    float x2, y2;
    public float l2, m2;
    public float theta2;
    float scale2;

    private void Start()
    {
        l2 = 5;
        m2 = 5;
        theta2 = Mathf.PI / 2;
        scale2 = 1.5f * (m2 - 0.5f) / (49.5f) + 0.5f;
        PlayerPrefs.SetFloat("l2", l2);
        PlayerPrefs.SetFloat("m2", m2);
        PlayerPrefs.SetFloat("theta2", theta2);
        PlayerPrefs.SetFloat("scale2", scale2);
        transform.localScale = new Vector3(scale2, scale2, 1);
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
        scale2 = 1.5f * (m2 - 0.5f) / (49.5f) + 0.5f;
        transform.localScale = new Vector3(scale2, scale2, 1);
        PlayerPrefs.SetFloat("scale2", scale2);
    }
    public void AdjustTheta2(float newTheta2)
    {
        theta2 = newTheta2;
        PlayerPrefs.SetFloat("theta2", theta2);
    }
}
