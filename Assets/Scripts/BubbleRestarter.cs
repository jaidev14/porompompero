using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleRestarter : MonoBehaviour
{
    private Bubble[] bubbles;
    public AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bubbles = FindObjectsOfType<Bubble>();        
    }

    void OnMouseDown()
    {
        Restart();
    }


    private void Restart() {
        foreach (Bubble bubble in bubbles) {
            bubble.Restart();
        }
        audioSource.Play();
    }
}
