using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class FallingSprite : MonoBehaviour
{
    public GameObject spritePrefab;
    public AudioClip soundClip;
    public float fallSpeed = 1f;


    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component from the same GameObject or its children
        audioSource = GetComponentInChildren<AudioSource>();
        if (audioSource == null)
        {
            // Create a new AudioSource component if none exists
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void OnButtonClick()
    {

        // Instantiate a new sprite at the top of the screen
        GameObject newSprite = Instantiate(spritePrefab, new Vector3(0f, 10f, 0f), Quaternion.identity);
        Rigidbody rb = newSprite.GetComponent<Rigidbody>();
        audioSource.PlayOneShot(soundClip);
    }

}

