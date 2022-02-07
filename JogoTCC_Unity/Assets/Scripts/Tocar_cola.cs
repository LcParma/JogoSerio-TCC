using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocar_cola : MonoBehaviour
{
    public GameObject obj_pai;
    Collider colisor;

    // Start is called before the first frame update
    void Start()
    {
        obj_pai.transform.GetChild(2).gameObject.SetActive(false);
        colisor = GetComponent<Collider>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cubo_metade1")
        {
           // colisor.enabled = !colisor.enabled; //desativa o colisor do pai para que não tenha interação de novo
            print("tocou");
            obj_pai.transform.GetChild(0).gameObject.SetActive(false);
            obj_pai.transform.GetChild(1).gameObject.SetActive(false);
            obj_pai.transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
