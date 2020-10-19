using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    [SerializeField] private Animal animal;
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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("NICE");
        if (other.gameObject.transform.tag == gameObject.transform.tag)
        {
            animal.hunger--;
            animal.slider.IncrementProgress(0.5f);
            Destroy(gameObject);
        }
        else Destroy(gameObject);
    }
}
