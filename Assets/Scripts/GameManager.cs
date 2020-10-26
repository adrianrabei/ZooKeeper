using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject win, main, fail;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Win()
    {
        win.SetActive(true);
        main.SetActive(false);
    }  
    
    public void Fail()
    {
        fail.SetActive(true);
        main.SetActive(false);
    }
}
