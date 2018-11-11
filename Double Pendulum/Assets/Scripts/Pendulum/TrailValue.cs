using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailValue : MonoBehaviour {

    public void ToggleTrail()
    {
        TrailRenderer trail1 = GameObject.Find("Particle1").GetComponent<TrailRenderer>();
        TrailRenderer trail2 = GameObject.Find("Particle2").GetComponent<TrailRenderer>();

        trail1.enabled = !trail1.enabled;
        trail2.enabled = !trail2.enabled;
    }
}
