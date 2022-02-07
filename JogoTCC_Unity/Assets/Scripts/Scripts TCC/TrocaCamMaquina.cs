using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaCamMaquina : MonoBehaviour
{
    Camera camPrimaria;
    public Camera camSecundaria;
    public GameObject personagem, pnl_sairCamSec, seg1, seg2, seg3, seg4, seg5, seg6;
    public Collider colisor, colSegHolder, col_ligandoFios;
    AudioListener audioPrim;
    //public AudioListener audioScriptHolder;

    // Start is called before the first frame update
    void Start()
    {
        col_ligandoFios.enabled = false;
        camPrimaria = personagem.GetComponentInChildren<Camera>();
        //audioPrim = personagem.GetComponentInChildren<AudioListener>();
        camSecundaria.GetComponent<Camera>().enabled = false;
        //camSecundaria.GetComponent<AudioListener>().enabled = false;
    }
    private void OnMouseDown()
    {
        //audioScriptHolder.enabled = true;
        AlternarCam();
    }
    void AlternarCam()
    {
        pnl_sairCamSec.transform.GetChild(1).gameObject.SetActive(true);
        colisor.enabled = false;
        camPrimaria.enabled = false;
        camSecundaria.GetComponent<Camera>().enabled = true;
        personagem.SetActive(false);
        //camSecundaria.GetComponent<AudioListener>().enabled = true;
        colSegHolder.enabled = false;
        col_ligandoFios.enabled = true;
        seg1.GetComponent<DragObj>().segurando_OnOff = true;
        seg2.GetComponent<DragObj>().segurando_OnOff = true;
        seg3.GetComponent<DragObj>().segurando_OnOff = true;
        seg4.GetComponent<DragObj>().segurando_OnOff = true;
        seg5.GetComponent<DragObj>().segurando_OnOff = true;
        seg6.GetComponent<DragObj>().segurando_OnOff= true;
    }
    public void VoltarCamPri()
    {
        pnl_sairCamSec.transform.GetChild(1).gameObject.SetActive(false);
        colisor.enabled = true;
        camPrimaria.enabled = true;
        camSecundaria.GetComponent<Camera>().enabled = false;
        personagem.SetActive(true);
        //camSecundaria.GetComponent<AudioListener>().enabled = false;
        colSegHolder.enabled=true;
        col_ligandoFios.enabled = false;
        //audioScriptHolder.enabled = false;

    }
}
