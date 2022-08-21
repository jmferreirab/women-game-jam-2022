using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeechBubbles : MonoBehaviour
{
    [Tooltip("The game object using this behaviour should be a player with a speechBubble sprite as a child.")]
    [SerializeField] GameObject speechBubble;
    [SerializeField] float hideTimeout = 1.5f;
    [SerializeField] float timeToReappear = 5.0f;

    private void Start()
    {
        speechBubble = transform.Find("SpeechBubble").gameObject;
        InvokeRepeating("ShowBubble", timeToReappear, timeToReappear);  //1s delay, repeat every 1s
    }

    // Show the attached speech bubble. If not manually hidden, it will auto hide in SECONDS.
    public void ShowBubble()
    {
        speechBubble.SetActive(true);
        StartCoroutine(HideBubbleCoroutine());
    }

    IEnumerator HideBubbleCoroutine()
    {
        yield return new WaitForSeconds(hideTimeout);
        speechBubble.SetActive(false);
    }

    // Call if immediate deactivation is required.
    public void HideBubble()
    {
        speechBubble.SetActive(false);
    }
}
