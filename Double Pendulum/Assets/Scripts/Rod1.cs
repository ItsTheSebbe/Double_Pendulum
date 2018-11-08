using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod1 : MonoBehaviour {
    
    float x1,y1;
	// Use this for initialization
	void Start ()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        x1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().x1;
        y1 = GameObject.Find("Particle1").GetComponent<Behaviour_Particle_1>().y1;
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, new Vector3(0, 0, 0));
        lineRenderer.SetPosition(1, new Vector3(x1, y1, 0));
    }
}
