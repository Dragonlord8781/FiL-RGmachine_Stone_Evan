using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip Grass;
    [SerializeField] AudioClip Stone;
    [SerializeField] AudioClip Wood;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Grass")
        {
            audio.PlayOneShot(Grass);
        }
        if (collision.gameObject.tag == "Wood")
        {
            audio.PlayOneShot(Wood);
        }
        if (collision.gameObject.tag == "Stone")
        {
            audio.PlayOneShot(Stone);
        }
    }
}