using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSimulation : MonoBehaviour {

    public void Start_Sim()
    {
        SceneManager.LoadScene("Scenes/Pendulum");
    }
}
