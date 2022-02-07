using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translacao : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 1f * Time.deltaTime, 0f);
    }
}
