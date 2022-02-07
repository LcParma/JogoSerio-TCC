using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDentroJogo : MonoBehaviour
{
    public GameObject pnlMenuJogo, pnlDicaDes1 , pnlDicaDes2, pnlDicaDes3;
    //private bool isMenuAberto = false;
    private void Awake()
    {
        pnlMenuJogo.SetActive(false);
        pnlDicaDes1.SetActive(false);
        pnlDicaDes2.SetActive(false);
        pnlDicaDes3.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SairPnlMenuJogo()
    {
        pnlMenuJogo.SetActive(false);
        Iniciar_jogo.iniciar_game = true;
        //isMenuAberto = false;
    }

    public void AbrirPnlMenuJogo()
    {
        if(Iniciar_jogo.iniciar_game == true)
        {
            pnlMenuJogo.SetActive(true);
            Iniciar_jogo.iniciar_game = false;
            //isMenuAberto = true;
        }
    }

    public void VoltarMenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AbrirPnlDicaDes1()
    {
        this.gameObject.SetActive(false);
        pnlDicaDes1.SetActive(true);
    }

    public void SairPnlDicaDes1()
    {
        pnlDicaDes1.SetActive(false);
        this.gameObject.SetActive(true);
    }
     public void AbrirPnlDicaDes2()
    {
        this.gameObject.SetActive(false);
        pnlDicaDes2.SetActive(true);
    }

    public void SairPnlDicaDes2()
    {
        pnlDicaDes2.SetActive(false);
        this.gameObject.SetActive(true);
    }
     public void AbrirPnlDicaDes3()
    {
        this.gameObject.SetActive(false);
        pnlDicaDes3.SetActive(true);
    }

    public void SairPnlDicaDes3()
    {
        pnlDicaDes3.SetActive(false);
        this.gameObject.SetActive(true);
    }

}
