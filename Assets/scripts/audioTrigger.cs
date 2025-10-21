using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public string tagDoObjetoQueAtiva = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagDoObjetoQueAtiva))
        {
            if (audioSource != null)
            {
                audioSource.Play();
                Debug.Log(" Áudio tocando por trigger.");
            }
        }
    }
}