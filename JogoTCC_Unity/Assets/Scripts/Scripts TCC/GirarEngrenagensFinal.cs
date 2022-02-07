using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarEngrenagensFinal : MonoBehaviour
{
    public Animation anim_EngrEnferrujadas;
    public GameObject EngrNova;
    public float vel = 4f;

    // Start is called before the first frame update
    private void Awake()
    {
        anim_EngrEnferrujadas.Play();
    }

    private void FixedUpdate()
    {
        EngrNova.transform.Rotate(0, 0, 100 * Time.deltaTime * vel);
    }

}
