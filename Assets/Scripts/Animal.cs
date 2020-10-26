using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animal : MonoBehaviour
{
    public Animator animal1Animator, animal2Animator, animal3Animator;
    [SerializeField] private GameObject animal1, animal2, animal3;
    public int hunger;
    public HungerSlider slider;
    public static int animalNr, allFull;
    public SoundManager soundManager;

    void Start()
    {
        hunger = 2;

        animalNr = 1;
        allFull = 0;
    }

    void Update()
    {
        if(hunger == 0)
        {
            animalNr++;
            allFull++;
            hunger = 2;
        }
    }
}
