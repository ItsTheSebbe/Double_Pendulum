using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod1 : MonoBehaviour {

    float length;
    float x1;
    float y1;
    float theta1;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        x1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().x1;
        y1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().y1;
        theta1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().theta1;
        length = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().l1;
        transform.localScale = new Vector3(0.15f, length / 2, 1);
        transform.position = new Vector3(x1/ (length / 2), y1/ (length / 2), 0);
        transform.eulerAngles = new Vector3(0, 0, theta1 * 180 / Mathf.PI);
	}
}
