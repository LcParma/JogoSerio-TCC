using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima_empurrador : MonoBehaviour
{
    public GameObject empurrador;
    public AnimationClip clipe;
    public static bool chave = false;
    //Collider colisor;
    public void Animacao()
    {
        
            GetComponentInParent<Animation>().Play(clipe.name);
        

        //if(e)
    }
   /* private void FixedUpdate()
    {
        if (chave)
            Animacao();
    }*/
}
