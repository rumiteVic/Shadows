using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPasos : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip pasos;
    public AudioClip jump;

    public AudioSource audioAttack;
    public AudioClip attack;
    public AudioClip launch;

    public float minPitch;
    public float maxPitch;

    public float volumeMin;
    public float volumeMax;
    
    public Movimiento mov;

    void PlayPasos(){
        if(mov.suelo)audio.pitch = 1.0f + Random.Range(minPitch, maxPitch);
        if(mov.suelo)audio.volume = 1.0f + Random.Range(volumeMin, volumeMax);    
        audio.clip= pasos;
        audio.Play();
    }

    void PlayJump(){
        audio.pitch = 1.0f + Random.Range(minPitch, maxPitch);
        audio.volume = 1.0f + Random.Range(volumeMin, volumeMax);  
        audio.clip= jump;
        audio.Play();
    }

    void PlayAttack(){
        audio.pitch = 1.0f + Random.Range(minPitch, maxPitch);
        audio.volume = 1.0f + Random.Range(volumeMin, volumeMax);  
        audioAttack.clip = attack;
        audioAttack.Play();
    }

    void PlayLaunch(){
        audio.pitch = 1.0f + Random.Range(minPitch, maxPitch);
        audio.volume = 1.0f + Random.Range(volumeMin, volumeMax);  
        audioAttack.clip = launch;
        audioAttack.Play();
    }
}
