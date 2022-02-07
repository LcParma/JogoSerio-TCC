using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoisSensores : MonoBehaviour
{
    public static bool sensorA1_2, sensorB1_2, sensorC1_2, sensorD1_2;
    
    public bool key_sensA1,key_sensA2, key_sensB1,key_sensB2, key_sensC1,key_sensC2, key_sensD1,key_sensD2;

    protected LineRenderer line;
    private Vector3 pos1, pos2, pos3, pos4;

    private void Start() {
        line = GetComponent<LineRenderer>();

    }

    void Update()
    {
        Compara_sensores();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("SensA_lado1")){
            if(this.transform.name == "degrau1"){
                print("SENSOR 1 do lado 1");
                key_sensA1 = true;
            }
        }
        else if(other.CompareTag("SensA_lado2")){
            if(this.transform.name == "degrau1"){
                print("SENSOR 1 do lado 2");
                key_sensA2 = true;
            }
        }
        else if(other.CompareTag("SensB_lado1")){
            if(this.transform.name == "degrau2"){
                print("ligou no sensor 1 do lado 2");
                key_sensB1 = true;
            }
        }
        else if(other.CompareTag("SensB_lado2")){
            if(this.transform.name == "degrau2"){
                print("ligou no sensor 1 do lado 2");
                key_sensB2 = true;
            }
        }
        else if(other.CompareTag("SensC_lado1")){
            if(this.transform.name == "degrau3"){
                print("ligou no sensor 1 do lado 2");
                key_sensC1 = true;
            }
        }
        else if(other.CompareTag("SensC_lado2")){
            if(this.transform.name == "degrau3"){
                print("ligou no sensor 1 do lado 2");
                key_sensC2 = true;
            }
        }
        else if(other.CompareTag("SensD_lado1")){
            if(this.transform.name == "degrau4"){
                print("ligou no sensor 1 do lado 2");
                key_sensD1 = true;
            }
        }
        else if(other.CompareTag("SensD_lado2")){
            if(this.transform.name == "degrau4"){
                print("ligou no sensor 1 do lado 2");
                key_sensD2 = true;
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("SensA_lado1")){
            if(this.transform.name == "degrau1"){
                print("SAIU DO SENSOR 1 do lado 1");
                key_sensA1 = false;
            }
        }
        else if(other.CompareTag("SensA_lado2")){
            if(this.transform.name == "degrau1"){
                print("SAIU DO SENSOR 1 do lado 2");
                key_sensA2 = false;
            }
        }
        else if(other.CompareTag("SensB_lado1")){
            if(this.transform.name == "degrau2"){
                print("SAIU DO SENSOR 2 do lado 1");
                key_sensB1 = false;
            }
        }
        else if(other.CompareTag("SensB_lado2")){
            if(this.transform.name == "degrau2"){
                print("SAIU DO  1 SENSOR 2 do lado 2");
                key_sensB2 = false;
            }
        }
        else if(other.CompareTag("SensC_lado2")){
            if(this.transform.name == "degrau3"){
                print("SAIU DO SENSOR 3 do lado 1");
                key_sensC1 = false;
            }
        }
        else if(other.CompareTag("SensC_lado2")){
            if(this.transform.name == "degrau3"){
                print("SAIU DO SENSOR 3 do lado 2");
                key_sensC2 = false;
            }
        }
        else if(other.CompareTag("SensD_lado2")){
            if(this.transform.name == "degrau4"){
                print("SAIU DO SENSOR 4 do lado 1");
                key_sensD1 = false;
            }
        }
        else if(other.CompareTag("SensD_lado2")){
            if(this.transform.name == "degrau4"){
                print("SAIU DO SENSOR 4 do lado 2");
                key_sensD2 = false;
            }
        }
    }

    public void Compara_sensores(){
        if(key_sensA1 && key_sensA2){
            sensorA1_2 = true;
            print("ambas deram true");
            key_sensA1 = false;
            key_sensA2 = false;
            GetComponent<AudioSource>().Play();
        }
        else if(key_sensB1 && key_sensB2){
            sensorB1_2 = true;
            print("ambas deram true SENSOR B");
            key_sensB1 = false;
            key_sensB2 = false;
            GetComponent<AudioSource>().Play();
        }
        else if(key_sensC1 && key_sensC2){
            sensorC1_2 = true;
            print("ambas deram true SENSOR C");
            key_sensC1 = false;
            key_sensC2 = false;
            GetComponent<AudioSource>().Play();
        }
        else if(key_sensD1 && key_sensD2){
            sensorD1_2 = true;
            print("ambas deram true SENSOR D");
            key_sensD1 = false;
            key_sensD2 = false;
            GetComponent<AudioSource>().Play();
        }
        
    }
}
