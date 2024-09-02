using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
  private AudioSource hitSound;
  private void Awake(){
    hitSound = GetComponent<AudioSource>();

  }

  private void OnCollisionEnter(Collision other){
    hitSound.Play();
  }
}
