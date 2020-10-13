using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject animal1, animal2, animal3, animal1FeedArea, animal2FeedArea, animal3FeedArea;
    private Vector3 animal1Pos, animal2Pos, animal3Pos;
    private int hunger;
    public Bucket food;
    [SerializeField] private HungerSlider slider;
    public static int animalNr, allFull;

    void Start()
    {
        animal1FeedArea = animal1.gameObject.transform.GetChild(0).gameObject;
        animal1Pos = animal1FeedArea.transform.position;

        animal2FeedArea = animal2.gameObject.transform.GetChild(0).gameObject;
        animal2Pos = animal2FeedArea.transform.position;

        animal3FeedArea = animal3.gameObject.transform.GetChild(0).gameObject;
        animal3Pos = animal3FeedArea.transform.position;

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
                if (Mathf.Abs(food.instantiatedFood.transform.position.x - animal1Pos.x) <= 1f && Mathf.Abs(food.instantiatedFood.transform.position.y - animal1Pos.y) <= 1f)
                {
                    Eat();
                    if(food.instantiatedFood.transform.tag == animal1.transform.tag)
                    {
                        Debug.Log("NICE");
                        hunger--;
                        slider.IncrementProgress(0.5f);
                    }
                }
                else if (Mathf.Abs(food.instantiatedFood.transform.position.x - animal2Pos.x) <= 1f && Mathf.Abs(food.instantiatedFood.transform.position.y - animal2Pos.y) <= 1f)
                {
                    Eat();
                    if (food.instantiatedFood.transform.tag == animal2.transform.tag)
                    {
                        Debug.Log("NICE");
                        hunger--;
                        slider.IncrementProgress(0.5f);
                    }
                }
                else if (Mathf.Abs(food.instantiatedFood.transform.position.x - animal3Pos.x) <= 1f && Mathf.Abs(food.instantiatedFood.transform.position.y - animal3Pos.y) <= 1f)
                {
                    Eat();
                    if (food.instantiatedFood.transform.tag == animal3.transform.tag)
                    {
                        Debug.Log("NICE");
                        hunger--;
                        slider.IncrementProgress(0.5f);
                    }
                }
                else
                {
                    DragDrop.mouseUp = false;
                    food.instantiatedFood.transform.position = Vector3.Lerp(food.instantiatedFood.transform.position, food.initialPos, Time.time);
                }
                food.foodCount = food.foodList.Count;
            }

            if(hunger == 0)
            {
                animalNr++;
                allFull++;
                hunger = 2;
            }

            if(food.foodCount == 0)
            {
                Debug.Log("BUCKET IS EPMTY");

                if (allFull != 3)
                {
                    Debug.Log("Animals didnt eat well!");
                }
                else Debug.Log("All animals ate well!");
            }
        }
    }

    private void Eat()
    {
        Destroy(food.instantiatedFood);
        Bucket.instantiated = false;
        DragDrop.mouseUp = false;
    }
}
