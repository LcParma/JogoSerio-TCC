using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarDesFinal : MonoBehaviour
{
    public GameObject pnl_MostraDesFinal;

    private void Awake()
    {
        pnl_MostraDesFinal.SetActive(false);
    }

    private void OnMouseDown()
    {
        pnl_MostraDesFinal.SetActive(true);
        Iniciar_jogo.iniciar_game = false;
    }

    public void SairPnlMostraDesFinal()
    {
        pnl_MostraDesFinal.SetActive(false);
        Iniciar_jogo.iniciar_game = true;
    }
}
