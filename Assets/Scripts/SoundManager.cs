using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip Hit;
    [SerializeField] AudioClip Miss;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void hitSound()
    {
        audioSource.clip = Hit;
        audioSource.PlayOneShot(Hit, 1f);
    }

    public void missSound()
    {
        audioSource.clip = Miss;
        audioSource.PlayOneShot(Miss, 1f);
    }
}
