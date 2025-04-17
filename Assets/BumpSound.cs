using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip grass;
    [SerializeField] AudioClip stone;
    [SerializeField] AudioClip wood;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Grass")
        {
            audio.PlayOneShot(grass);
        }
        if (collision.gameObject.tag == "Wood")
        {
            audio.PlayOneShot(wood);
        }
        if (collision.gameObject.tag == "stone")
        {
            audio.PlayOneShot(stone);
        }
    }
}