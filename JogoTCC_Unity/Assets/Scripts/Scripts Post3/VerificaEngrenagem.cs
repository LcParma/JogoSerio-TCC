using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaEngrenagem : MonoBehaviour
{
    public bool key_motor = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(key_motor)
        {
            Debug.Log("terminou");
            key_motor = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "disco_d4")
        {
            key_motor = true;
        }
        else
        {
            Debug.Log("não está correto");
        }
    }
}
