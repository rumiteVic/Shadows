using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAudio : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision){
        audio.Play();
    }

}
