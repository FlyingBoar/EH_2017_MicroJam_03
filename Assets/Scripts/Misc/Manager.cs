using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public GameObject MainMenuPanel;
    public GameObject EndGamePanel;

    public Text ScoreText;

    public static Manager I;

	// Use this for initialization
	void Start () {
        if (I == null)
            I = this;
        else
            DestroyImmediate(gameObject);
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
