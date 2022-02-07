using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intf_EscadaConcluida : TrocarCameras
{
    TrocarCameras trocaCam;
    public GameObject panel_escaPronta, panel_inventario;
    public Camera camSec;
    Camera camPri; 
    public static bool liberarEscadaPronta = false;

    private void Awake()
    {
        camPri = personagem.GetComponentInChildren<Camera>();
    }

    public void FecharPnl_EscPronta(){
        VoltarCamPriPt1();
    }

    public override void VoltarCamPriPt1()
    {
        base.VoltarCamPriPt1();
        this.gameObject.SetActive(false);
        Iniciar_jogo.iniciar_game = true;
        liberarEscadaPronta = true;
        pnl_sairCamSec.SetActive(true);
        Debug.Log("fez certo");
        Pontuacao.isDes1Completo = true;
    }
}

// public class Intf_EscadaConcluida : MonoBehaviour
// {
//     TrocarCameras trocaCam;
//     public GameObject panel_escaPronta, personagem, panel_inventario;
//     public Camera camSec;
//     Camera camPri;
//     public static bool liberarEscadaPronta = false;

//     private void Awake()
//     {
//         camPri = personagem.GetComponentInChildren<Camera>();
//     }

//     public void FecharPanel_EscaPronta()
//     {
//         trocaCam.VoltarCamPriPt1();

//         // this.gameObject.SetActive(false);
//         // camPri.enabled = true;
//         // camSec.enabled = false;
//         // Iniciar_jogo.iniciar_game = true;
//         // liberarEscadaPronta = true;
//         // personagem.SetActive(true);
//         // panel_inventario.SetActive(true);
//     }
// }
