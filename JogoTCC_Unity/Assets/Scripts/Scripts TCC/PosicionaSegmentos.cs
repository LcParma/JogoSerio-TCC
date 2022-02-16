using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionaSegmentos : MonoBehaviour
{
    public GameObject localSeg_pos;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Segmento")
        {

            //other.gameObject.GetComponent<DragObj>().segurando_OnOff = false;
            if(other.transform.name == "seg_maior2A")
            {
                other.transform.position = localSeg_pos.transform.GetChild(0).position;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
            else if (other.transform.name == "seg_maior2B")
            {
                other.transform.position = localSeg_pos.transform.GetChild(1).position;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
            else if (other.transform.name == "seg_maior2C")
            {
                other.transform.position = localSeg_pos.transform.GetChild(2).position;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
            else if (other.transform.name == "seg_maior2D")
            {
                other.transform.position = localSeg_pos.transform.GetChild(3).position;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
            else if (other.transform.name == "seg_maior2")
            {
                other.transform.position = localSeg_pos.transform.GetChild(4).position;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
            else if (other.transform.name == "plugue_tomada")
            {
                other.transform.position = localSeg_pos.transform.GetChild(5).position;
                other.transform.GetComponent<Rigidbody>().isKinematic = true;
            }

        }
    }

}
