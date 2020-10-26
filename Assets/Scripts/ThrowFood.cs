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
            if(Animal.animalNr == 1)
            {
                animal.animal1Animator.SetTrigger("isAttacking");
                animal.soundManager.Eat();
            }
            else if (Animal.animalNr == 2)
            {
                animal.animal2Animator.SetTrigger("isEating");
                animal.soundManager.Eat();
            }
            else if (Animal.animalNr == 3)
            {
                animal.animal3Animator.SetTrigger("isShacking");
                animal.soundManager.Eat();
            }
            animal.hunger--;
            animal.slider.IncrementProgress(0.5f);
            Destroy(gameObject);
            
        }
        else
        {
            if (Animal.animalNr == 1)
            {
                animal.animal1Animator.SetTrigger("isHowling");
                animal.soundManager.WolfHowl();
            }
            else if (Animal.animalNr == 2)
            {
                animal.soundManager.DeerSound();
            }
            else if (Animal.animalNr == 3)
            {
                animal.soundManager.PenguinSound();
            }
            Destroy(gameObject);
        }
    }
}
