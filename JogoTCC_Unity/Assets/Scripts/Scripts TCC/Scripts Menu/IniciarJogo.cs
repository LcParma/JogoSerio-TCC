using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJogo : MonoBehaviour
{
    public GameObject pnl_info;

    private void Awake()
    {
        pnl_info.SetActive(false);
    }

    public void IniciarGame()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void AbrirInfo()
    {
        pnl_info.SetActive(true);
    }
    public void SairInfo()
    {
        pnl_info.SetActive(false );
    }
}
