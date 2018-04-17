using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public GameObject MainMenuPanel;
    public GameObject EndGamePanel;

    public Text ScoreText;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}

    public void SetScore(int _score)
    {
        ScoreText.text = "SCORE : " + _score;
    }

    public void Play()
    {
        MainMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        EndGamePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
