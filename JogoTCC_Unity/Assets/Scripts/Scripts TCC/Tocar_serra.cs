using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocar_serra : MonoBehaviour
{
 
    public GameObject pai;
    public GameObject obj_aux;
    Collider colisor;
    private void Start(){
        pai.transform.gameObject.SetActive(false);
        // pai.transform.GetChild(0).gameObject.SetActive(false);
        // pai.transform.GetChild(1).gameObject.SetActive(false);
        colisor = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Des1_serra")
        {
            colisor.enabled = !colisor.enabled;
            print("tocou");
            obj_aux.transform.gameObject.SetActive(false);
            pai.transform.gameObject.SetActive(true);
            // pai.transform.GetChild(0).gameObject.SetActive(true);
            // pai.transform.GetChild(1).gameObject.SetActive(true);

        }
    }

}
