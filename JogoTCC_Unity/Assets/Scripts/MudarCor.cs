using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCor : MonoBehaviour
{
    public Color cor_obj;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void MudaCorObj(GameObject obj)
    {
        obj.GetComponent<Renderer>().material.color = cor_obj;
    }
}
