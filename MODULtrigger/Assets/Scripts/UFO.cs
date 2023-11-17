using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("PickUp"))
        {
            source.PlayOneShot(clip);
            Destroy(obj.gameObject);
        }
        
    }
    
}
