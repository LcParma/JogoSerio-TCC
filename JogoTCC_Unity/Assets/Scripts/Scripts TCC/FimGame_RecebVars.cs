using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FimGame_RecebVars : MonoBehaviour
{
    public Text textoPontoFinal, tempo;
    private float tempoFinalizacao, minutes, seconds;

    private void Start()
    {
        textoPontoFinal.text = Pontuacao.PontuacaoFinal.ToString();
        tempoFinalizacao = Temporizador.tempoCorrendo;
        minutes = Mathf.FloorToInt(tempoFinalizacao / 60);
        seconds = Mathf.FloorToInt(tempoFinalizacao % 60);

        tempo.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
