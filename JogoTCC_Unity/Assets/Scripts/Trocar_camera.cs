using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trocar_camera : MonoBehaviour
{
    public Camera cam_prim, cam_secundaria;
    // private static bool cam_trocado = false;
    public GameObject col_entrarCamera2;
    public GameObject panel_sairCam2, panel_inventario, personagem;

    private void Awake()
    {
        cam_secundaria.gameObject.SetActive(false);
        // cam_trocado = false;
        // panel_sairCam2.SetActive(false);

    }
    // private void Start() {
    //     cam_secundaria.gameObject.SetActive(false);
    //     // cam_trocado = false;
    //     panel_sairCam2.SetActive(false);
    // }

    private void OnMouseDown()
    {
        CameraSecundaria();
    }

    public void SairCamera2()
    {
        CameraPrincipal();
    }

    void CameraPrincipal()
    {
        cam_secundaria.gameObject.SetActive(false);
        cam_prim.gameObject.SetActive(true);
        col_entrarCamera2.GetComponent<BoxCollider>().enabled = true;
        personagem.SetActive(true);
        Iniciar_jogo.iniciar_game = true;
        panel_sairCam2.SetActive(false);
        panel_inventario.SetActive(true);
    }
    void CameraSecundaria()
    {
        cam_secundaria.gameObject.SetActive(true);
        cam_prim.gameObject.SetActive(false);
        col_entrarCamera2.GetComponent<BoxCollider>().enabled = false;
        Iniciar_jogo.iniciar_game = false;
        panel_sairCam2.SetActive(true);
        panel_inventario.SetActive(false);
        personagem.SetActive(false);
    }

}
