using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public GameObject capsuleFoodPrefab;
    public GameObject sphereFoodPrefab;
    public GameObject cubeFoodPrefab;
    private Vector3 position;
    public GameObject instantiatedFood;
    public static bool instantiated;
    public static bool canInstantiate;
    private int x;
    public Vector3 initialPos;
    
    void Start()
    {
        position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f, gameObject.transform.position.z);
        canInstantiate = true;
        x = Random.Range(1, 4);
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(x == 1)
        {
            if (canInstantiate)
            {
                instantiatedFood = Instantiate(capsuleFoodPrefab, position, Quaternion.identity);
                instantiated = true;
                canInstantiate = false;
                x = Random.Range(1, 4);
            }
        }
        else if(x == 2)
        {
            if (canInstantiate)
            {
                instantiatedFood = Instantiate(sphereFoodPrefab, position, Quaternion.identity);
                instantiated = true;
                canInstantiate = false;
                x = Random.Range(1, 4);
            }
        }
        else if(x == 3)
        {
            if (canInstantiate)
            {
                instantiatedFood = Instantiate(cubeFoodPrefab, position, Quaternion.identity);
                instantiated = true;
                canInstantiate = false;
                x = Random.Range(1, 4);
            }
        }
        initialPos = new Vector3(instantiatedFood.transform.position.x, instantiatedFood.transform.position.y, instantiatedFood.transform.position.z);
    }
}
