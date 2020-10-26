using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip wolfHowl, deer, penguin;
    [SerializeField] private AudioClip eat;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void WolfHowl()
    {
        audioSource.PlayOneShot(wolfHowl);
    }

    public void Eat()
    {
        audioSource.PlayOneShot(eat);
    }

    public void PenguinSound()
    {
        audioSource.PlayOneShot(penguin);
    }

    public void DeerSound()
    {
        audioSource.PlayOneShot(deer);
    }
}
