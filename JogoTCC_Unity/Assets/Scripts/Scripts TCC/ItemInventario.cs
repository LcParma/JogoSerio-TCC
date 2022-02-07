using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventario : MonoBehaviour
{

    public Text txt_slot1, txt_slot3;

    public GameObject panel_slots, personagem, plugue_tomada;
    Camera cam_principal;
    Ray ray;
    RaycastHit hitInfo;

    GameObject obj_rayHit;
    public static Queue fila_itens = new Queue();
    //public static int qtdItem_des1 = 0, qtdItem_des3 = 0;
    public static GameObject Itens_desafio;
    public static bool pegouTomada = false, isDisco1, isDisco2, isDisco3, isDisco4, isDisco5, isDisco6;

    [SerializeField] float raio = 10f;

    void Start()
    {
        cam_principal = personagem.GetComponentInChildren<Camera>();
        //qtdItem_des1 = -1;
        //qtdItem_des3 = -1;

        isDisco1 = false;
        isDisco2 = false;
        isDisco3 = false;
        isDisco4 = false;
        isDisco5 = false;
        isDisco6 = false;
        plugue_tomada.GetComponent<DragObj>().segurando_OnOff = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ray = cam_principal.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                obj_rayHit = hitInfo.collider.gameObject;
                if (obj_rayHit.GetComponent<Item_Target>() != null)
                {
                    if ((Vector3.Distance(personagem.transform.position, obj_rayHit.transform.position)) > raio)
                    {
                        Debug.Log("nao alcanca o obj");
                    }
                    else
                        PegarItem();
                }
            }
        }

    }

    public void PegarItem()
    {
        Debug.Log("Nome do item " + hitInfo.transform.name);
        if (obj_rayHit.tag == "desafio1")
        {
            // if (hitInfo.collider.gameObject.name == "degrau1")
            // {
            // Destroy(hitInfo.collider.gameObject);
            fila_itens.Enqueue(obj_rayHit);
            obj_rayHit.SetActive(false);
            // if (qtdItem_des1 == -1)
            //     qtdItem_des1 = 0;
            // else
            // {
            //     qtdItem_des1 ++;
            txt_slot1.text = fila_itens.Count.ToString();
            // }
            panel_slots.transform.GetChild(0).gameObject.SetActive(true);
            // }
        }
        else if (obj_rayHit.tag == "desafio2")
        {
            
        }
        else if (obj_rayHit.tag == "Segmento")
        {
            if(obj_rayHit.name == "plugue_tomada")
            {
                Itens_desafio = obj_rayHit; //permite o inventario_slot acessar o GameObject do item
                obj_rayHit.SetActive(false);
                obj_rayHit.GetComponent<DragObj>().segurando_OnOff = true;
                panel_slots.transform.GetChild(1).gameObject.SetActive(true);
                pegouTomada = true;
            }
            else
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                txt_slot3.text = fila_itens.Count.ToString();
                panel_slots.transform.GetChild(2).gameObject.SetActive(true);
            }
            
        }
        else if (obj_rayHit.tag == "desafio3")
        {
            if(obj_rayHit.transform.name == "Engr1_83")
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                panel_slots.transform.GetChild(6).gameObject.SetActive(true);
                isDisco1 = true;

            }
            if(obj_rayHit.transform.name == "Engr2_73")
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                panel_slots.transform.GetChild(7).gameObject.SetActive(true);
                isDisco2 = true;

            }
            if(obj_rayHit.transform.name == "Engr3_53")
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                panel_slots.transform.GetChild(8).gameObject.SetActive(true);
                isDisco3 = true;

            }
            if(obj_rayHit.transform.name == "Engr4_63")
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                panel_slots.transform.GetChild(9).gameObject.SetActive(true);
                isDisco4 = true;

            }
            if(obj_rayHit.transform.name == "Engr5_43")
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                panel_slots.transform.GetChild(10).gameObject.SetActive(true);
                isDisco5 = true;

            }
            if(obj_rayHit.transform.name == "Engr6_40")
            {
                fila_itens.Enqueue(obj_rayHit);
                obj_rayHit.SetActive(false);
                panel_slots.transform.GetChild(11).gameObject.SetActive(true);
                isDisco6 = true;

            }

        }

    }

}
