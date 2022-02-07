using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalJogo_Porta : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other);
        if (other.transform.tag == "Player")
        {
            SceneManager.LoadScene("JogoFinal");
        }
    }
    
}

