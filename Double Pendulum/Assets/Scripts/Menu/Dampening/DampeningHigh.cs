using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DampeningHigh : MonoBehaviour {
    float dampening;
    public void AdjustDampening()
    {
        dampening = 0.90f;
        PlayerPrefs.SetFloat("dampening", dampening);
    }
}
