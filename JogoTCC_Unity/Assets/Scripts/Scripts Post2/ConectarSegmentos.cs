using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConectarSegmentos : MonoBehaviour
{
    private Transform transf_aux;
    
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other);
        if(other.name == "sensor1" || other.name == "sensor2" )
        {
            other.gameObject.SetActive(false);
            //acessando o Transform do pai do Sensor para juntar depois
            gameObject.transform.SetParent(other.transform.parent.gameObject.transform, true);
            // other.transform.parent.gameObject.GetComponent<DragObj>().enabled = false;
            if(other.name == "sensor1")
            {
                //Salvo numa var aux o endereco do sensor 2
                transf_aux = other.transform.parent.GetChild(1);
                //Atribuo o valor dele pra null, isto é, ele perde parentesco
                other.transform.parent.GetChild(1).transform.parent = null;
                Debug.Log("trans_aux: "+transf_aux);
                Debug.Log("other.transform.parent.transform.parent: "+other.transform.parent.transform.parent);
                //Atribuo a var aux que salvei como filho do pai do outro segmento
                //de modo a ficar com o sensor 1 de um dos segmentos e o sensor 2 do outro
                transf_aux.SetParent(other.transform.parent.transform.parent,true);
                
            }
        }
    }
    
}
