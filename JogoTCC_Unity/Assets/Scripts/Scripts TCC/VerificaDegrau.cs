using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaDegrau : MonoBehaviour
{
    public GameObject degrau1, degrau2, degrau3, degrau4;
    public GameObject escadaDesmontada_pai, escadaPronta_pai, escadaErguida_pai, degrau_pai;

    public Color cor_obj;

    public GameObject callPanel_escaPronta, panel_sairEscada;

    public GameObject personagem;

    void Start()
    {
        escadaPronta_pai.SetActive(false);
        escadaErguida_pai.SetActive(false);
        callPanel_escaPronta.SetActive(false);
    }

    void Update()
    {
        if (DoisSensores.sensorA1_2 == true)
        {
            DragObj.DesligaSeg_onOff(degrau1);
            // degrau1.GetComponent<Rigidbody>().freezeRotation = false;
            degrau1.GetComponent<Rigidbody>().isKinematic = true;
            MudaCorObj(degrau1);
        }

        if (DoisSensores.sensorB1_2 == true)
        {
            DragObj.DesligaSeg_onOff(degrau2);
            degrau2.GetComponent<Rigidbody>().isKinematic = true;
            MudaCorObj(degrau2);
        }

        if (DoisSensores.sensorC1_2 == true)
        {
            DragObj.DesligaSeg_onOff(degrau3);
            degrau3.GetComponent<Rigidbody>().isKinematic = true;
            MudaCorObj(degrau3);
        }

        if (DoisSensores.sensorD1_2 == true)
        {
            DragObj.DesligaSeg_onOff(degrau4);
            degrau4.GetComponent<Rigidbody>().isKinematic = true;
            MudaCorObj(degrau4);
        }
        EscadaPronta();
    }

    void EscadaPronta()
    {
        if ((DoisSensores.sensorA1_2 && DoisSensores.sensorB1_2 && DoisSensores.sensorC1_2 && DoisSensores.sensorD1_2) == true)
        {
            personagem.SetActive(true);
            panel_sairEscada.SetActive(false);
            callPanel_escaPronta.SetActive(true);
            escadaDesmontada_pai.SetActive(false);
            degrau_pai.SetActive(false);
            escadaPronta_pai.SetActive(true);
            
        }
    }

    void MudaCorObj(GameObject obj)
    {
        obj.GetComponent<Renderer>().material.color = cor_obj;
    }

}
