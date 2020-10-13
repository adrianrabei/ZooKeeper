using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject camPos1;
    [SerializeField] private GameObject camPos2;
    [SerializeField] private GameObject camPos3;
    [SerializeField] private HungerSlider slider;
    [SerializeField] private Bucket bucket;
    [SerializeField] private GameObject bucketPos1;
    [SerializeField] private GameObject bucketPos2;
    [SerializeField] private GameObject bucketPos3;
    public static bool camMoved;
    void Start()
    {
        
    }

    
    void Update()
    {
        MoveCamera(Animal.animalNr);
    }

    private void MoveCamera(int animalNr)
    {
        if(slider.slider.value == 1)
        {
            if (animalNr == 2)
            {
                transform.DOMove(camPos2.transform.position, 1f);
                bucket.transform.DOMove(bucketPos2.transform.position, 2f);
                Bucket.instantiated = false;
                camMoved = true;
            }
            else if (animalNr == 3)
            {
                transform.DOMove(camPos3.transform.position, 1f);
                bucket.transform.DOMove(bucketPos3.transform.position, 2f);
                Bucket.instantiated = false;
                camMoved = true;
            }
        }
    }
}
