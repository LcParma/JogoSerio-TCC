using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObj : MonoBehaviour
{
    private float mZCoord;
    private bool segurando;
    private int vel_ro = 25;
    public bool segurando_OnOff = true;

    public float isCloseObj = 20f;


    //private void Awake()
    //{
        
    //    posicaoInicialObj.position = this.transform.position;
    //}

    private void Start() {
        segurando = false;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //        Debug.Log(other);
    //    if(other.transform.tag == "intransponivel")
    //    {
    //        this.transform.position = posicaoInicialObj.position;
    //    }
    //}

    private void FixedUpdate() {
        //if(segurando == true){
            if(segurando_OnOff){ //variavel do script que verifica se o script vai funcionar ou nao
                if(segurando){
                    if(Input.GetKey(KeyCode.R)){
                        transform.Rotate(Vector3.forward * Time.deltaTime * vel_ro);
                    }
                    else if(Input.GetKey(KeyCode.T)){
                        transform.Rotate(Vector3.back * Time.deltaTime * vel_ro);
                    }
                    else if(Input.GetKey(KeyCode.F)){
                        // transform.Rotate(Time.deltaTime * vel_ro,Time.deltaTime * vel_ro, 1f);
                        transform.Rotate(Time.deltaTime * vel_ro, 0, 0);
                    }
                    else if(Input.GetKey(KeyCode.G)){
                        // transform.Rotate(Time.deltaTime * vel_ro,Time.deltaTime * vel_ro, 1f);
                        transform.Rotate(Time.deltaTime *-1f* vel_ro, 0, 0);
                    }

                }
            }
        //}
    }

    void OnMouseDown()
    {
        
        if(segurando_OnOff){
            this.GetComponent<Rigidbody>().freezeRotation = true;
            segurando = true;
            // print(segurando);
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        }
    }
    private void OnMouseUp() {
        segurando = false;
        this.GetComponent<Rigidbody>().freezeRotation = false;
        // print(segurando);
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        if (segurando_OnOff)
        {
            transform.position = GetMouseAsWorldPoint() ;
        }
    }

    public static void DesligaSeg_onOff(GameObject obj){
        obj.GetComponent<DragObj>().segurando_OnOff = false;
    }
}