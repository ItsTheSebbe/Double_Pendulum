using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSimulation : MonoBehaviour {

    public void ResetSim()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
}
