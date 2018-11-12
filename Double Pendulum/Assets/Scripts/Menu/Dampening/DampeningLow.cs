using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DampeningLow : MonoBehaviour {
    float dampening;
    public void AdjustDampening()
    {
        dampening = 0.999f;
        PlayerPrefs.SetFloat("dampening", dampening);
    }
}
