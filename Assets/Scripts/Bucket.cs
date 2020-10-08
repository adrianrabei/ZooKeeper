﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public GameObject capsuleFoodPrefab;
    public GameObject sphereFoodPrefab;
    public GameObject cubeFoodPrefab;
    private Vector3 position;
    public GameObject instantiatedFood;
    public Vector3 initialPos;
    public static bool instantiated;
    public int foodCount;
    private string randomFood;
    public List<string> foodList = new List<string>();

    void Start()
    {
        position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f, gameObject.transform.position.z);

        foodList.Add("meat");
        foodList.Add("meat");
        foodList.Add("vegetable");
        foodList.Add("vegetable");
        foodList.Add("fish");
        foodList.Add("fish");

        foodCount = foodList.Count;
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(instantiated == false)
        {
            if (foodList.Count > 0)
            {
                int index = Random.Range(0, foodList.Count);
                randomFood = foodList[index];

                if (randomFood == "meat")
                {
                    instantiatedFood = Instantiate(cubeFoodPrefab, position, Quaternion.identity);
                }
                else if (randomFood == "vegetable")
                {
                    instantiatedFood = Instantiate(capsuleFoodPrefab, position, Quaternion.identity);
                }
                else if (randomFood == "fish")
                {
                    instantiatedFood = Instantiate(sphereFoodPrefab, position, Quaternion.identity);
                }

                instantiated = true;
                initialPos = new Vector3(instantiatedFood.transform.position.x, instantiatedFood.transform.position.y, instantiatedFood.transform.position.z);
                foodList.Remove(randomFood);
            }
        }
    }
}
