using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DampeningNormal : MonoBehaviour {
    float dampening;
    public void AdjustDampening()
    {
        dampening = 0.99f;
        PlayerPrefs.SetFloat("dampening", dampening);
    }
}
