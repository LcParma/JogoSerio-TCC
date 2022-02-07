using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPortao : MonoBehaviour
{
    public Animator An_abre_portao1, An_abre_portao2;
    public GameObject chavePortao, pnl_MonteEscPrimeiro;
    public bool portaoOnOff = false;

    private void Start()
    {
        pnl_MonteEscPrimeiro.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EscadaPronta.portao_habilitado)
        {
            if (portaoOnOff)
            {
                An_abre_portao1.SetBool("aberto1_onOff", true);
                An_abre_portao2.SetBool("aberto2_onOff", true);

            }
        }
        else
        {
            Debug.Log("escada n esta pronta, montar ela primeiro");
        }
    }
    private void OnMouseDown()
    {

        if (EscadaPronta.portao_habilitado)
        {
            portaoOnOff = true;
        }
        else
        {
            pnl_MonteEscPrimeiro.SetActive(true);
        }

    }

    public void SairPnlMontEscPrim()
    {
        pnl_MonteEscPrimeiro.SetActive(false);
    }
}
