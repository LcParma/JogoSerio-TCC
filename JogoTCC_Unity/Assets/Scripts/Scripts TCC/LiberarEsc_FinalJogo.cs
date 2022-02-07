using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiberarEsc_FinalJogo : MonoBehaviour
{
    public static bool sensor_finalJogo = false;

    public GameObject escada_final, pnl_EscadaFimJogoApareceu;

    private void Awake()
    {
        pnl_EscadaFimJogoApareceu.SetActive(false);
    }

    private void Start()
    {
        escada_final.SetActive(false);  
    }

    private void Update()
    {
        if (UsarItem_Inventario.isEndGame == true)
        {
            AparecerEscada();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        sensor_finalJogo=true;
        Debug.Log("entrou");

    }
    private void OnTriggerExit(Collider other)
    {
        sensor_finalJogo=false;
        Debug.Log("saiu");
    }

    private void AparecerEscada()
    {
        UsarItem_Inventario.isEndGame = false;
        escada_final.SetActive(true);
        pnl_EscadaFimJogoApareceu.SetActive(true);
        Pontuacao.isDes3Completo = true;
    }

    public void SairPnlEscEndGame()
    {
        pnl_EscadaFimJogoApareceu.SetActive(false);
    }

}
