using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_IC : MonoBehaviour
{

    public void Btm_1Post(){
        SceneManager.LoadScene("Cena_Post1");
    }
    public void Btm_2Post(){
        SceneManager.LoadScene("Cena_Post2");
    }
    public void Btm_3Post(){
        SceneManager.LoadScene("Cena_Post3");
    }
    public void Btm_Info(){
        Debug.Log("Info");
    }
    public void Btm_Sair(){
        Debug.Log("Saiu");
        Application.Quit();
    }

}
