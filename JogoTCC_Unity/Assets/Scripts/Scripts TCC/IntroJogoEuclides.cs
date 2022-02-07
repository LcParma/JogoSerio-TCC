using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroJogoEuclides : MonoBehaviour
{
    public GameObject uiAssistant, textWriter;
    public GameObject painel_inventario, personagem, cam_inicial;
    // Start is called before the first frame update
    void Start()
    {
        painel_inventario.SetActive(false);
        personagem.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EncerrarIntro()
    {
        uiAssistant.SetActive(false);
        textWriter.SetActive(false);
        painel_inventario.SetActive(true);
        personagem.SetActive(true );
        cam_inicial.SetActive(false);
        Iniciar_jogo.iniciar_game = true;
    }
}
