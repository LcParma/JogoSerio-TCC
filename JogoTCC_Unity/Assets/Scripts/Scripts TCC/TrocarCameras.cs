using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarCameras : MonoBehaviour
{
    Camera camPrimaria;
    public GameObject camSecundaria;
    public GameObject pnl_invent, pnl_sairCamSec, personagem;
    public Collider colisor;


    Ray ray;
    RaycastHit hitInfo;

    // TrocarCamerasFilho trocaCamFilho;

    void Start()
    {
        //audioPrim = personagem.GetComponentInChildren<AudioListener>();
        camPrimaria = personagem.GetComponentInChildren<Camera>();
        camSecundaria.GetComponent<Camera>().enabled = false;
        //camSecundaria.GetComponent<AudioListener>().enabled = false;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = camPrimaria.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Collider>() == colisor)
                {
                    if(colisor.tag == "sairCam_pt1")
                    {
                        AlternarCamerasPt1();
                    }
                    else if(colisor.tag == "sairCam_pt2")
                    {
                        AlternarCamerasPt2();
                    }
                        // trocaCamFilho.AlternarCameras();
                }
            }
        }
    }
    public void AlternarCamerasPt1()
    {
        // if (colisor.tag == "sairCam_pt1")
        // {
        pnl_sairCamSec.transform.GetChild(0).gameObject.SetActive(true);
        // }
        // else if(colisor.tag == "sairCam_pt2"){
        // }
        colisor.enabled = false;
        //camPrimaria.enabled = false;
        camSecundaria.GetComponent<Camera>().enabled = true;
        personagem.SetActive(false);
        pnl_invent.SetActive(false);
        //camSecundaria.GetComponent<AudioListener>().enabled = true;

    }
    public virtual void VoltarCamPriPt1()
    {
        // if (colisor.tag == "sairCam_pt1")
        // {
        pnl_sairCamSec.transform.GetChild(0).gameObject.SetActive(false);
        // }
        // else if(colisor.tag == "sairCam_pt2"){
        // }
        colisor.enabled = true;
        //camPrimaria.enabled = true;
        camSecundaria.GetComponent<Camera>().enabled = false;
        personagem.SetActive(true);
        pnl_invent.SetActive(true);
        //camSecundaria.GetComponent<AudioListener>().enabled = false;
    }

    public void AlternarCamerasPt2()
    {
        pnl_sairCamSec.transform.GetChild(1).gameObject.SetActive(true);
        colisor.enabled = false;
        //camPrimaria.enabled = false;
        camSecundaria.GetComponent<Camera>().enabled = true;
        personagem.SetActive(false);
        pnl_invent.SetActive(false);
        //camSecundaria.GetComponent<AudioListener>().enabled = true;

    }
    public void VoltarCamPriPt2()
    {
        pnl_sairCamSec.transform.GetChild(1).gameObject.SetActive(false);
        colisor.enabled = true;
        //camPrimaria.enabled = true;
        camSecundaria.GetComponent<Camera>().enabled = false;
        personagem.SetActive(true);
        pnl_invent.SetActive(true);
        //camSecundaria.GetComponent<AudioListener>().enabled = false;
    }

}
    