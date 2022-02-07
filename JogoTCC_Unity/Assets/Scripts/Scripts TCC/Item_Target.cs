using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Target : MonoBehaviour
{

    [SerializeField] float raio = 3f; //distancia que o personagem deve estar para interagir com o obj
    private Renderer rend;
    Color cor_orig;
    private void Start() {
        rend = GetComponent<Renderer>();
        cor_orig = rend.material.color;
    }

    private void OnMouseEnter() {
        rend.material.color = Color.red;
    }

    private void OnMouseExit() {
        rend.material.color = cor_orig;
    }

    void OnDrawGizmosSelected() {
        Gizmos.color =  Color.yellow;
        Gizmos.DrawWireSphere(transform.position, raio);
    }
}
