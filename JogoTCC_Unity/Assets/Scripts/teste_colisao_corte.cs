using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste_colisao_corte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        teste_corte.Cut(collision.transform, transform.position);
    }
}
