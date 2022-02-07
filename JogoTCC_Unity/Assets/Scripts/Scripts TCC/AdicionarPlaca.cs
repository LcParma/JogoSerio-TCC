using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdicionarPlaca : MonoBehaviour
{
    public GameObject placaFonte, posFinal_placa, pnl_jaTemPlaca;
    public static bool placaPosicionada = false;


    // Start is called before the first frame update

    private void Awake()
    {
        pnl_jaTemPlaca.SetActive(false);
        
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(placaPosicionada == false)
        {
            MaquinaLigada.placaMetal = Instantiate(placaFonte,posFinal_placa.transform.position, posFinal_placa.transform.rotation);
            placaPosicionada=true;  
        }
        else
        {
            pnl_jaTemPlaca.SetActive(true);
        }
    }

    public void SairPnlJaTemPlaca()
    {
        pnl_jaTemPlaca.SetActive(false);
    }
}
