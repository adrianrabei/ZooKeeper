using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject wolf, deer, penguin;
    private Vector3 wolfPos, deerPos, penguinPos;
    private int wolfHunger, deerHunger, penguinHunger;
    public Bucket food;

    void Start()
    {
        wolfPos = wolf.transform.position;
        deerPos = deer.transform.position;
        penguinPos = penguin.transform.position;

        wolfHunger = deerHunger = penguinHunger = 2;
    }

    void Update()
    {
        if (Bucket.instantiated)
        {
            if (DragDrop.mouseUp)
            {
                if (Mathf.Abs(food.instantiatedFood.transform.position.x - wolfPos.x) <= 0.5f && Mathf.Abs(food.instantiatedFood.transform.position.y - wolfPos.y) <= 0.5f)
                {
                    Eat();
                    wolfHunger--;
                }
                else if (Mathf.Abs(food.instantiatedFood.transform.position.x - deerPos.x) <= 0.5f && Mathf.Abs(food.instantiatedFood.transform.position.y - deerPos.y) <= 0.5f)
                {
                    Eat();
                    deerHunger--;
                }
                else if (Mathf.Abs(food.instantiatedFood.transform.position.x - penguinPos.x) <= 0.5f && Mathf.Abs(food.instantiatedFood.transform.position.y - penguinPos.y) <= 0.5f)
                {
                    Eat();
                    penguinHunger--;
                }
                else
                {
                    DragDrop.mouseUp = false;
                    food.instantiatedFood.transform.position = Vector3.Lerp(food.instantiatedFood.transform.position, food.initialPos, Time.time);
                }
                food.foodCount = food.foodList.Count;
            }

            if(food.foodCount == 0)
            {
                if (wolfHunger > 0 || deerHunger > 0 || penguinHunger > 0)
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
