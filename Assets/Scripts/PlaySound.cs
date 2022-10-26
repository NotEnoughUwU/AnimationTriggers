using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource targetAudio;
    public GameObject self;

    void OnTriggerEnter(Collider other)
    {
        targetAudio.Play();
        self.SetActive(false);
    }
}
