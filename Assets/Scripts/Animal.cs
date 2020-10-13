using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject wolf, deer, penguin, wolfFeedArea, deerFeedArea, penguinFeedArea;
    private Vector3 wolfPos, deerPos, penguinPos;
    private int hunger;
    public Bucket food;
    [SerializeField] private HungerSlider slider;
    public static int animalNr, allFull;

    void Start()
    {
        wolfFeedArea = wolf.gameObject.transform.GetChild(0).gameObject;
        wolfPos = wolfFeedArea.transform.position;

        deerFeedArea = deer.gameObject.transform.GetChild(0).gameObject;
        deerPos = deerFeedArea.transform.position;

        penguinFeedArea = penguin.gameObject.transform.GetChild(0).gameObject;
        penguinPos = penguinFeedArea.transform.position;

        hunger = 2;

        animalNr = 1;
        allFull = 0;
    }

    void Update()
    {
        if (Bucket.instantiated)
        {
            if (DragDrop.mouseUp)
            {
                if (Mathf.Abs(food.instantiatedFood.transform.position.x - wolfPos.x) <= 1f && Mathf.Abs(food.instantiatedFood.transform.position.y - wolfPos.y) <= 1f)
                {
                    Eat();
                    hunger--;
                }
                else if (Mathf.Abs(food.instantiatedFood.transform.position.x - deerPos.x) <= 1f && Mathf.Abs(food.instantiatedFood.transform.position.y - deerPos.y) <= 1f)
                {
                    Eat();
                    hunger--;
                }
                else if (Mathf.Abs(food.instantiatedFood.transform.position.x - penguinPos.x) <= 1f && Mathf.Abs(food.instantiatedFood.transform.position.y - penguinPos.y) <= 1f)
                {
                    Eat();
                    hunger--;
                }
                else
                {
                    DragDrop.mouseUp = false;
                    food.instantiatedFood.transform.position = Vector3.Lerp(food.instantiatedFood.transform.position, food.initialPos, Time.time);
                }
                food.foodCount = food.foodList.Count;
            }

            if(hunger == 0 || hunger < 0)
            {
                animalNr++;
                allFull++;
                hunger = 2;
            }

            if(food.foodCount == 0)
            {
                if (allFull == 3)
                {
                    Debug.Log("Animals didnt eat well!");
                }
                else Debug.Log("All animals ate well!");
            }
        }
    }

    private void Eat()
    {
        slider.IncrementProgress(0.5f);
        Destroy(food.instantiatedFood);
        Bucket.instantiated = false;
        DragDrop.mouseUp = false;
    }
}
