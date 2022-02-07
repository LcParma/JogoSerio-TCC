using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public static bool isDes1Completo = false, isDes2Completo = false, isDes3Completo = false;
    int pontoPorDesConclido = 1000;
        float pontos = 0f, pontAtual = 0f;
    public static int PontuacaoFinal;

    public Text textoPontos;

    void Start()
    {
        isDes1Completo = false;
    }

    void Update()
    {
        PontuacaoFinal = System.Convert.ToInt32(textoPontos.text);
        Debug.Log("pontos finais "+PontuacaoFinal);
        //Debug.Log("Pontos: " + textoPontos.text);
        if (isDes1Completo == true)
        {
            pontos = (int)(Temporizador.tempoCorrendo + pontoPorDesConclido);
            textoPontos.text = pontos.ToString();     //seta o texto no txt de pontos
            Debug.Log(pontos);
            isDes1Completo = false;
        }
        if(isDes2Completo == true)
        {
            pontos = (int)(Temporizador.tempoCorrendo + pontoPorDesConclido);
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            //pontAtual = System.Int32.Parse(textoPontos.ToString());
            pontAtual = pontAtual + pontos;
            textoPontos.text = pontAtual.ToString();//seta o texto no txt de pontos
            //textoPontos.SetText(pontAtual.ToString());
            isDes2Completo = false;
        }
        if(isDes3Completo == true)
        {
            pontos = (int)(Temporizador.tempoCorrendo + pontoPorDesConclido);
            //pontAtual = System.Int32.Parse(textoPontos.ToString());
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            pontAtual = pontAtual + pontos;
            textoPontos.text = pontAtual.ToString();//seta o texto no txt de pontos
            isDes3Completo = false;
        }
    }
}
