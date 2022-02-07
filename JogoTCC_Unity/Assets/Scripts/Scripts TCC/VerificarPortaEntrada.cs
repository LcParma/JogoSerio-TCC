using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarPortaEntrada : MonoBehaviour
{
    public static bool porta_disponivel = false;

    private void OnMouseDown() {
        if(!porta_disponivel){
            Debug.Log("n pode ser aberta ainda");
        }
    }
}
