using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DampeningOff : MonoBehaviour {
    float dampening;
    public void AdjustDampening()
    {
        dampening = 1;
        PlayerPrefs.SetFloat("dampening", dampening);
    }
}
