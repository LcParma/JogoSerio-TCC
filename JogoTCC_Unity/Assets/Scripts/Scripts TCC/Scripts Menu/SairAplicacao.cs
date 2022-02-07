using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SairAplicacao : MonoBehaviour
{
    public void SairGame()
    {
        Debug.Log("fechou o jogo");
        Application.Quit();
    }
}
