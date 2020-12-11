using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RoomTransitionScripts : MonoBehaviour
{
    public AudioMixerSnapshot InRoom;
    public AudioMixerSnapshot OutOfRoom;
  



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "InRoom")
        {
            InRoom.TransitionTo(0.5f);
        }
        if (other.gameObject.tag == "OutOfRoom")
        {
            OutOfRoom.TransitionTo(0.5f);
        }
    }
}
