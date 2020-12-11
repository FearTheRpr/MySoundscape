using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public AudioSource Sound1;
    public AudioSource Sound2;


    void OnTriggerEnter(Collider other)
    {
        Sound1.Play();
        Sound2.Play();
        gameObject.SetActive(false);
    }
}
