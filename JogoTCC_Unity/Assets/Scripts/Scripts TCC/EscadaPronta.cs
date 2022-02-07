using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscadaPronta : MonoBehaviour
{
    public GameObject escada_pronta;
    public GameObject escada_erguida;

    public static bool portao_habilitado = false;

    private void Start() {
        portao_habilitado = false;
    }

    private void OnMouseDown()
    {
        if (Intf_EscadaConcluida.liberarEscadaPronta == true)
        {
            portao_habilitado = true;
            escada_pronta.SetActive(false);
            escada_erguida.SetActive(true);
            VerificarPortaEntrada.porta_disponivel = true;
        }
    }
}
