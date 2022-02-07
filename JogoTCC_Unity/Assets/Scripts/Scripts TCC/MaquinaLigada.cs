using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaLigada : MonoBehaviour
{
    //private bool maquinaOn = false;
    public static GameObject placaMetal;

    public GameObject disco1, disco2, disco3, disco4, disco5, disco6, pai_discos;
    public GameObject pnl_ligMaqPrimeiro, pnl_ColoquePlacaPrim;

    //public GameObject personagem;
    public Camera cam_maq;
    Ray ray;
    RaycastHit hitInfo;

    GameObject obj_rayHit;

    private void Awake()
    {
        pnl_ligMaqPrimeiro.SetActive(false);    
        pnl_ColoquePlacaPrim.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        disco1.SetActive(false);
        disco2.SetActive(false);
        disco3.SetActive(false);
        disco4.SetActive(false);
        disco5.SetActive(false);
        disco6.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam_maq.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                obj_rayHit = hitInfo.collider.gameObject;
                if (obj_rayHit.transform.tag == "Botao1")
                {
                    if(LigarFioMaquina.maqOnOff == true)
                    {
                        if (AdicionarPlaca.placaPosicionada == false)
                        {
                            pnl_ColoquePlacaPrim.SetActive(true);
                        }
                        else
                        {
                            AcionarBtnMaq(obj_rayHit);
                        }
                    }
                    else
                    {
                        pnl_ligMaqPrimeiro.SetActive(true);
                        Debug.Log("eh preciso ligar a maquina primeiro");
                    }
                }
            }
        }
    }



    public void AcionarBtnMaq(GameObject botao)
    {
        GameObject disco;
        if(botao.transform.name == "Btn1")
        {
            Debug.Log(botao.transform.name);
            disco = Instantiate(disco1, disco1.transform.position, disco1.transform.rotation);
            disco.transform.SetParent(pai_discos.transform, false);
            disco.SetActive(true);
        }
        else if(botao.transform.name == "Btn2")
        {
            Debug.Log(botao.transform.name);
            disco = Instantiate(disco2, disco2.transform.position, disco2.transform.rotation);
            disco.transform.SetParent(pai_discos.transform, false);
            disco.SetActive(true);
        }
        else if (botao.transform.name == "Btn3")
        {
            Debug.Log(botao.transform.name);
            disco = Instantiate(disco3, disco3.transform.position, disco3.transform.rotation);
            disco.transform.SetParent(pai_discos.transform, false);
            disco.SetActive(true);
        }
        else if (botao.transform.name == "Btn4")
        {
            Debug.Log(botao.transform.name);
            disco = Instantiate(disco4, disco4.transform.position, disco4.transform.rotation);
            disco.transform.SetParent(pai_discos.transform, false);
            disco.SetActive(true);
        }
        else if (botao.transform.name == "Btn5")
        {
            Debug.Log(botao.transform.name);
            disco = Instantiate(disco5, disco5.transform.position, disco5.transform.rotation);
            disco.transform.SetParent(pai_discos.transform, false);
            disco.SetActive(true);
        }
        else if (botao.transform.name == "Btn6")
        {
            Debug.Log(botao.transform.name);
            disco = Instantiate(disco6, disco6.transform.position, disco6.transform.rotation);
            disco.transform.SetParent(pai_discos.transform, false);
            disco.SetActive(true);
        }

        Destroy(placaMetal);
        AdicionarPlaca.placaPosicionada = false;
    }

    public void SairPnlLigueMaqPrim()
    {
        pnl_ligMaqPrimeiro.SetActive(false);
    }

    public void SairPnlColoquePlacaPrim()
    {
        pnl_ColoquePlacaPrim.SetActive(false);
    }

}
