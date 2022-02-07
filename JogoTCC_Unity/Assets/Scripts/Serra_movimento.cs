using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Serra_movimento : MonoBehaviour
{

    private float vel = 1;
    private bool serra_btm;
    public GameObject serra;
    //public GameObject empurrador;
    public AnimationClip clipe;
    private Animator control_movimento;
    // Update is called once per frame
    void start()
    {
        control_movimento = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (serra_btm == true)
        {
            serra.transform.Rotate(vel * Time.deltaTime * 60f, 0f, 0f);

        }
    }
    private void OnMouseDown()
    {
        serra_btm = true;
        control_movimento.SetInteger("estado_movimento", 1);
        //GetComponentInParent<Animation>().Play();
    }
}
