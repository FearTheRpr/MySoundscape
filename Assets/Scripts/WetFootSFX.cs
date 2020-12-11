using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetFootSFX : MonoBehaviour
{
    public AudioSource puddle;

    void OnTriggerEnter(Collider other)
    {
        puddle.Play();

    }
}
