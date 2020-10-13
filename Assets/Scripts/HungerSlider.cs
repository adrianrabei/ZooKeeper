using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSlider : MonoBehaviour
{
    public Slider slider;
    public float targetProgress = 0;
    private float fillSpeed = 0.5f;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (CameraMovement.camMoved)
        {
            targetProgress = 0;
            slider.value = 0;
            CameraMovement.camMoved = false;
        }
        else if (slider.value < targetProgress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
    }

    public void IncrementProgress(float addProgress)
    {
        targetProgress = slider.value + addProgress;
    }
}
