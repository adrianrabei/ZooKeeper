using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject animal1, animal2, animal3;
    public int hunger;
    public HungerSlider slider;
    public static int animalNr, allFull;

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
