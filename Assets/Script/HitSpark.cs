using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSpark : MonoBehaviour
{
   [SerializeField] private ParticleSystem spark;

   private void OnCollisionEnter(Collision other){
    spark.Play();
   }
}
