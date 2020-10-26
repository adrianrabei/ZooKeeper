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
    [SerializeField] private GameManager manager;
    [SerializeField] private UIManager uiManager;
    private GameObject[] hamCount, appleCount, fishCount;
    private int allFood;

    void Start()
    {
        hunger = 2;

        animalNr = 1;
        allFull = 0;
    }

    void Update()
    {
        hamCount = GameObject.FindGameObjectsWithTag("Carnivore");
        appleCount = GameObject.FindGameObjectsWithTag("Herbivore");
        fishCount = GameObject.FindGameObjectsWithTag("Fish");

        allFood = hamCount.Length + appleCount.Length + fishCount.Length;

        if (hunger == 0)
        {
            animalNr++;
            allFull++;
            hunger = 2;
        }
        if(allFull == 3 && hunger == 2)
        {
            manager.Win();
            uiManager.WinEase();
        }
    
        if(allFood == 3 && allFull != 3)
        {
            manager.Fail();
        }
    }
}
