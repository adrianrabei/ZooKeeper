using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    private Rigidbody food;
    private Vector3 direction;
    [SerializeField] private float speed = 500f;
    [SerializeField] private GameObject animal1;
    [SerializeField] private GameObject animal2;
    [SerializeField] private GameObject animal3;

    void Start()
    {
        food = GetComponent<Rigidbody>();
        direction = animal1.transform.position - transform.position;
    }

    void Update()
    {
        
    }

    private void Throw()
    {
        food.GetComponent<Rigidbody>().isKinematic = false;
        food.AddForce(direction.normalized * speed);
    }

    private void OnMouseDown()
    {
        Throw();
    }
}
