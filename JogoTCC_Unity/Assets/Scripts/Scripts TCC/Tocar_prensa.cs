using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocar_prensa : MonoBehaviour
{
    public GameObject objPai;

    private void Start(){
        //Objeto prensado começa inativo
        objPai.transform.GetChild(0).gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        //Caso o obj a ser prensado colida com a prensa
        // ele sera inativado enquanto o objeto ja prensado aparece
        if (other.gameObject.tag == "prensa")
        {
            objPai.transform.GetChild(1).gameObject.SetActive(false);
            objPai.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
