using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajustar_Corte : MonoBehaviour
{
    Transform pos_ajusteCorte;
    public GameObject aumentar_corte, diminuir_corte;


    // Start is called before the first frame update
    void Start()
    {
        pos_ajusteCorte = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AumentarBtm()
    {
        if (pos_ajusteCorte.position.z < 0.4f)
        {
            pos_ajusteCorte.position = new Vector3(pos_ajusteCorte.position.x, pos_ajusteCorte.position.y,
                                                    pos_ajusteCorte.position.z + 0.2f);
        }
    }

    void DiminuirBtm()
    {
        if (pos_ajusteCorte.position.z > -0.4f)
        {
            pos_ajusteCorte.position = new Vector3(pos_ajusteCorte.position.x, pos_ajusteCorte.position.y,
                                                                pos_ajusteCorte.position.z - 0.2f);
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == aumentar_corte.transform.name)
        {
            AumentarBtm();
        }
        else if (other.transform.name == diminuir_corte.transform.name)
        {
            DiminuirBtm();
        }
    }
}
