    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prensa_movimento : MonoBehaviour
{
    [SerializeField] private bool prensa_aberta;
    public GameObject prensa, posInicial, posFinal;
    [SerializeField] private float vel = 15; //vel do movimento da prensa
    
    void FixedUpdate()
    {
        if (prensa_aberta == true) //caso o botão seja pressionado, a prensa irá descer (prensa acionada = true)
        {
            prensa.transform.Translate(Vector3.down * Time.deltaTime * vel);
        }
        if (prensa.transform.position.y < posFinal.transform.position.y) //quando a prensa desce até o ponto y = 2, ela é "desativada", fica em estado false
        {
            prensa_aberta = false;

        }
        if(prensa_aberta == false && prensa.transform.position.y < posInicial.transform.position.y)//enquanto está "desativada", a prensa volta para seu estado inicial
        {
            prensa.transform.Translate(Vector3.up * Time.deltaTime * vel);
        }
    }

    private void OnMouseDown()
    {
        if(prensa.transform.position.y > posInicial.transform.position.y) //só poderá ser pressionado quando a presa estiver na posição inicial (y = 15)
        {
            prensa_aberta = true;
        }
    }
}
