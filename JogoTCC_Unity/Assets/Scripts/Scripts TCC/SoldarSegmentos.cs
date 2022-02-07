using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldarSegmentos : MonoBehaviour
{
    public GameObject segMaior1, segMaior2;
    static bool segM1 = false;

    private void Start()
    {
        segM1 = false;
        segMaior1.SetActive(false);
        segMaior2.SetActive(false);
        // segMaior3.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other);
        if (other.name == "sensor1" || other.name == "sensor2")
        {
            LigarFios(other);
        }
        // else if (other.name == "sensor1A" || other.name == "sensor2A")
        // {
        //     LigarFios(other);
        // }
    }

    void LigarFios(Collider other)
    {
        if (segM1 == false)
        {
            other.transform.parent.gameObject.SetActive(false);
            gameObject.SetActive(false);
            segMaior1.SetActive(true);
            segM1 = true;
        }
        else if (segM1 == true)
        {
            other.transform.parent.gameObject.SetActive(false);
            gameObject.SetActive(false);
            segMaior2.SetActive(true);
            segMaior2.GetComponent<Rigidbody>().isKinematic = false;
            segMaior2.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
