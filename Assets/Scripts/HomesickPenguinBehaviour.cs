using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomesickPenguinBehaviour : MonoBehaviour
{
    PlayerSpeechBubbles bubbles;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CallHome", 300f, 300f);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void CallHome()
    {
        bubbles.ShowBubble();   
    }

}
