using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public string levelSelect;

    private bool isPaused;
    public GameObject pauseMenuCanvas;
	
	// Update is called once per frame
	void Update () {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = false;
        }
	}

    public void Resume() {

        isPaused = false;

    }

    public void LevelSelect() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelSelect);
    }

    public void Quit()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }
}
