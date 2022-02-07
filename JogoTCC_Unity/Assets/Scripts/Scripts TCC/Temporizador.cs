using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public float timeRemaining = 600;
    public static float tempoCorrendo = 0f;
    public static bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    public GameObject painel_timesOver;

    private void Start()
    {
        timerIsRunning = true;
        painel_timesOver.SetActive(false);
    }

    void Update()
    {
        if (Iniciar_jogo.iniciar_game)
        {
            if (timerIsRunning)
            {
                tempoCorrendo = timeRemaining;
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    DisplayTime(timeRemaining);
                }
                else
                {
                    Debug.Log("Time has run out!");
                    timeRemaining = 0;
                    timerIsRunning = false;
                    TerminouTempo();
                }
            }
        }
    }

    public void TerminouTempo()
    {
        painel_timesOver.SetActive(true);
        Iniciar_jogo.iniciar_game = false;
    }

    public void TerminouTempoVoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
