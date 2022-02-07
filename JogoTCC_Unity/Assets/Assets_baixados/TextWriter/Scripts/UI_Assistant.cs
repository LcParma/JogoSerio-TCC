/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class UI_Assistant : MonoBehaviour {

    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;
    private AudioSource talkingAudioSource;
    private int indexTexto = 0;

    private void Awake() {
        indexTexto = 0;
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();
        talkingAudioSource = transform.Find("talkingSound").GetComponent<AudioSource>();

        transform.Find("message").GetComponent<Button_UI>().ClickFunc = () => {
            if (textWriterSingle != null && textWriterSingle.IsActive()) {
                // Currently active TextWriter
                textWriterSingle.WriteAllAndDestroy();
            } else {
                string[] messageArray = new string[] {
                    "Aliás, perdoe meus maus modos.", 
                    "Eu me chamo Euclides. Como você se... não temos tempo para apresentações...", 
                    "Você tem pouco tempo para sair daqui, então se apresse.",
                    "Tentarei ajudá-lo sair daqui. Então fique atento a o que irei dizer...",
                    "Você deve lembrar das minhas instruções quando for solucionar os desafios.",
                    "Existem três desafios principais que deve resolver",                  
                    "Use seu conhecimento e os conceitos que eu o ensinei para resolver os desafios... antes que seja tarde demais...",
                    "Pressione o botão quando estiver pronto para começar",
                    //"Check out Battle Royale Tycoon on Steam!",
                };

                //string message = messageArray[Random.Range(0, messageArray.Length)];
                string message = messageArray[indexTexto++];
                if (indexTexto > (messageArray.Length - 1)) {
                    indexTexto = 0;
                }
                StartTalkingSound();
                textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .02f, true, true, StopTalkingSound);
            }
        };
    }

    private void StartTalkingSound() {
        talkingAudioSource.Play();
    }

    private void StopTalkingSound() {
        talkingAudioSource.Stop();
    }

    private void Start() {
        //TextWriter.AddWriter_Static(messageText, "This is the assistant speaking, hello and goodbye, see you next time!", .1f, true);
    }

}
