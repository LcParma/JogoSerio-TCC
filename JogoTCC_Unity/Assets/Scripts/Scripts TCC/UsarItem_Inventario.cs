using UnityEngine;
using UnityEngine.UI;

public class UsarItem_Inventario : MonoBehaviour
{

    public GameObject panel_slots, aparecerItem, pnlErrouEngr, EngCorretaGirando;
    public static bool isEndGame = false; //var que inicia fim do jogo
    private bool isBotaoSlot_EndGame = false; //var que eh habilitada quando esta no collider do fim do jogo
    GameObject obj_clone;

    int penalidade = 200, pontAtual = 0;
    public Text textoPontos, txt_slot1, txt_slot3;

    private void Awake()
    {
        pnlErrouEngr.SetActive(false);

    }

    private void Start()
    {
        isEndGame = false;
        isBotaoSlot_EndGame = false;
        EngCorretaGirando.SetActive(false);
    }

    private void Update()
    {

        if (ItemInventario.fila_itens.Count == 0)
        {
            
            panel_slots.transform.GetChild(0).gameObject.SetActive(false);
            panel_slots.transform.GetChild(2).gameObject.SetActive(false);
        }

        if(LiberarEsc_FinalJogo.sensor_finalJogo == true)
        {
            isBotaoSlot_EndGame=true;
        }
        else
        {
            isBotaoSlot_EndGame=false;
        }

        //if(ItemInventario.isDisco4 == true)
        //{
        //    if(LiberarEsc_FinalJogo.sensor_finalJogo == true)
        //    {
        //        isBotaoSlot_EndGame = true;
        //    }
        //    else
        //    {
        //        isBotaoSlot_EndGame=false;
        //    }
        //}
    }

    public void UsarItemSlot1() //Slote dos degraus
    {
        if (ItemInventario.fila_itens.Count > 0)
        {
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            obj_clone.transform.position = aparecerItem.transform.position;
            obj_clone.SetActive(true);
            txt_slot1.text = ItemInventario.fila_itens.Count.ToString();
            Debug.Log(ItemInventario.fila_itens.Count);
        }
        else
        {
            panel_slots.transform.GetChild(0).gameObject.SetActive(false);
            txt_slot1.text = " ";
        }

    }

    public void UsarItemSlot2() // Slote do Plugue da tomada
    {

            obj_clone = ItemInventario.Itens_desafio;
            obj_clone.transform.position = aparecerItem.transform.position;
            obj_clone.SetActive(true);
            Debug.Log(ItemInventario.fila_itens.Count);
            panel_slots.transform.GetChild(1).gameObject.SetActive(false);

    }

    public void UsarItemSlot3() // Slote dos fios
    {
        //Debug.Log(ItemInventario.fila_itens.Count);
        if (ItemInventario.fila_itens.Count > 0)
        {
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            obj_clone.transform.position = aparecerItem.transform.position;
            obj_clone.SetActive(true);
            txt_slot3.text = ItemInventario.fila_itens.Count.ToString();
        }
        else if(ItemInventario.fila_itens.Count == 0)
        {
            panel_slots.transform.GetChild(2).gameObject.SetActive(false);
            txt_slot3.text = " ";
        }
    }

    public void UsarItemSlot1Engr() // da Engrenagem tamanho 1
    {

        if (isBotaoSlot_EndGame == true)
        {
            isEndGame = false;
            panel_slots.transform.GetChild(6).gameObject.SetActive(false);
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            //ItemInventario.fila_itens = null;
            Destroy(obj_clone);
            pnlErrouEngr.SetActive(true);
            
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            pontAtual = pontAtual - penalidade;
            textoPontos.text = pontAtual.ToString();

        }
        else
        {
            isEndGame = false;
        }
    }

    public void UsarItemSlot2Engr() // da Engrenagem tamanho 2
    {
        if (isBotaoSlot_EndGame == true)
        {
            isEndGame = false;
            panel_slots.transform.GetChild(7).gameObject.SetActive(false);
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            //ItemInventario.fila_itens = null;
            Destroy(obj_clone);
            pnlErrouEngr.SetActive(true);
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            pontAtual = pontAtual - penalidade;
            textoPontos.text = pontAtual.ToString();
        }
        else
        {
            isEndGame = false;
        }
    }
    public void UsarItemSlot3Engr() // da Engrenagem tamanho 3
    {
        if (isBotaoSlot_EndGame == true)
        {
            isEndGame = false;
            panel_slots.transform.GetChild(8).gameObject.SetActive(false);
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            //ItemInventario.fila_itens = null;
            Destroy(obj_clone);
            pnlErrouEngr.SetActive(true);
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            pontAtual = pontAtual - penalidade;
            textoPontos.text = pontAtual.ToString();
        }
        else
        {
            isEndGame = false;
        }
    }

    public void UsarItemSlot4Engr() // da Engrenagem tamanho 4
    {
        if (isBotaoSlot_EndGame == true && ItemInventario.isDisco4 == true)
        {
            isEndGame = true;
            panel_slots.transform.GetChild(9).gameObject.SetActive(false);
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            EngCorretaGirando.SetActive(true);
            //ItemInventario.fila_itens = null;
            Destroy(obj_clone);
            Debug.Log("abriu a escada");
        }
        else
        {
            isEndGame = false;
        }
    }

    public void UsarItemSlot5Engr() // da Engrenagem tamanho 5
    {
        if (isBotaoSlot_EndGame == true)
        {
            isEndGame = false;
            panel_slots.transform.GetChild(10).gameObject.SetActive(false);
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            //ItemInventario.fila_itens = null;
            Destroy(obj_clone);
            pnlErrouEngr.SetActive(true);
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            pontAtual = pontAtual - penalidade;
            textoPontos.text = pontAtual.ToString();
        }
        else
        {
            isEndGame = false;
        }
    }

    public void UsarItemSlot6Engr() // da Engrenagem tamanho 6
    {
        if (isBotaoSlot_EndGame == true)
        {
            isEndGame = false;
            panel_slots.transform.GetChild(11).gameObject.SetActive(false);
            obj_clone = (GameObject)ItemInventario.fila_itens.Dequeue();
            //ItemInventario.fila_itens = null;
            Destroy(obj_clone);
            pnlErrouEngr.SetActive(true);
            pontAtual = System.Convert.ToInt32(textoPontos.text);
            pontAtual = pontAtual - penalidade;
            textoPontos.text = pontAtual.ToString();
        }
        else
        {
            isEndGame = false;
        }
    }

    public void SairPnlErrouEngr()
    {
        pnlErrouEngr.SetActive(false);
    }

}
