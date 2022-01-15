using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocarSom : MonoBehaviour
{
    private AudioSource MeuAudio;

    // Start is called before the first frame update
    void Start()
    {
        MeuAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FalaAi()
    {
        MeuAudio.Play();
    }
}
