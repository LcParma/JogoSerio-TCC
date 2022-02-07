using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sobe_e_desce : MonoBehaviour
{
    public GameObject obj1; //cria a variavel do objeto 1 para referencial
    public GameObject obj2; //cria a variavel do objeto 2 para referencial
    public GameObject prensa; //cria a variavel do objeto 2 para referencial
    public float Speed;     //variavel para controlar a velocidade do movimento
    bool aux = false;
    private void Start()
    {
        prensa = GameObject.Find("prensa");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (aux) {
            var weight = (float)Math.Cos(Time.time * Speed) * 0.5f + 0.5f;
            prensa.transform.position = obj1.transform.position * weight + obj2.transform.position * (1 - weight);
            //prensa.transform.Translate(Vector3.down * Time.deltaTime * 2);
        }
        
    }
    private void OnMouseDown()
    {
        if (aux)
            aux = false;
        else
            aux = true;
    }
}
