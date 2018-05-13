using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScreen : MonoBehaviour {

    private bool isPaused;
    public GameObject pauseControlsCanvas;

	// Update is called once per frame
	void Update () {

        if (isPaused)
        {
            pauseControlsCanvas.SetActive(true);
        }else
        {
            pauseControlsCanvas.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = false;
        }
	}
}
