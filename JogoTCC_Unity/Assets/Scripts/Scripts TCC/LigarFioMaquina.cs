using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarFioMaquina : MonoBehaviour
{
    public GameObject seg1, seg2, seg3, seg4, seg5, tomada, Luz_maquina, pnl_MaquinaLigou;
    public GameObject portaFechada, portaAberta;
    public static bool maqOnOff = false;
    
    private int maqLigada = 0;

    private void Awake()
    {
        maqOnOff = false;
        pnl_MaquinaLigou.SetActive(false);  
        
    }


    private void Start()
    {
        maqLigada = 0;
        seg1.SetActive(false);
        seg2.SetActive(false);
        seg3.SetActive(false);
        seg4.SetActive(false);
        seg5.SetActive(false);
        tomada.SetActive(false);
        portaAberta.SetActive(false);
    }

    private void Update()
    {
        if(maqLigada == 6)
        {
            MaquinaLigou();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Segmento")
        {

            if(other.gameObject.name == "seg_maior2")
            {
                seg5.SetActive(true);
                other.gameObject.SetActive(false);
                maqLigada++;
            }
            else if (other.gameObject.name == "seg_maior2A")
            {
                seg4.SetActive(true);
                other.gameObject.SetActive(false);
                maqLigada++;
            }
            else if (other.gameObject.name == "seg_maior2B")
            {
                seg3.SetActive(true);
                other.gameObject.SetActive(false);
                maqLigada++;
            }
            else if (other.gameObject.name == "seg_maior2C")
            {
                seg2.SetActive(true);
                other.gameObject.SetActive(false);
                maqLigada++;
            }
            else if (other.gameObject.name == "seg_maior2D")
            {
                seg1.SetActive(true);
                other.gameObject.SetActive(false);
                maqLigada++;
            }
            else if (other.gameObject.name == "plugue_tomada")
            {
                if(ItemInventario.pegouTomada == true)
                {
                    Debug.Log("tomada entrou");
                    tomada.SetActive(true);
                    other.gameObject.SetActive(false);
                    maqLigada++;
                }
            }
            
        }
    }

    void MaquinaLigou()
    {
            maqOnOff = true;
            Luz_maquina.GetComponent<Renderer>().material.color = Color.red;
        if(maqLigada == 6)
        {
            maqLigada = 7;
            pnl_MaquinaLigou.SetActive(true);
        }

    }

    public void SairPnlMaqLigada()
    {
        pnl_MaquinaLigou.SetActive(false);
        Pontuacao.isDes2Completo = true;
        portaFechada.SetActive(false);
        portaAberta.SetActive(true);
    }
}
