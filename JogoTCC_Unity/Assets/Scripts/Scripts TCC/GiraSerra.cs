using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraSerra : MonoBehaviour
{

    [SerializeField] private GameObject serra;
    public float velocidade = 10;

    void Update()
    {
        serra.transform.Rotate(0f, 0f, velocidade * Time.deltaTime);
    }
}
