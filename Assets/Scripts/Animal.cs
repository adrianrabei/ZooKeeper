using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float animal_positionX, animal_positionY;
    public Bucket food;

    void Start()
    {
        animal_positionX = gameObject.transform.position.x;
        animal_positionY = gameObject.transform.position.y;
    }

    void Update()
    {
        if (Bucket.instantiated)
        {
            if(DragDrop.canCheck)
            {
                if (Mathf.Abs(food.instantiatedFood.transform.position.x - animal_positionX) <= 0.5f && Mathf.Abs(food.instantiatedFood.transform.position.y - animal_positionY) <= 0.5f)
                {
                    Debug.Log("EAT");
                    Destroy(food.instantiatedFood);
                    Bucket.instantiated = false;
                    DragDrop.canCheck = false;
                    Bucket.canInstantiate = true;
                }
                else
                {
                    DragDrop.canCheck = false;
                    food.instantiatedFood.transform.position = Vector3.Lerp(food.instantiatedFood.transform.position, food.initialPos, Time.time);
                }
            }
        }
    }
}
