using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Delivery : MonoBehaviour
{
    public float layerCarton;
    public AudioSource audio;

    public Compteur compt;

    public bool notDelivered=true;

    
        
            
        
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == layerCarton && notDelivered)
        {
            Destroy(other.gameObject);
            audio.Play(0);
            compt.score += 1;
            notDelivered = false;
        } 
    }
}
