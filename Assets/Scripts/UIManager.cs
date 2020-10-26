using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private RectTransform winText;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void WinEase()
    {
        winText.DOAnchorPos(new Vector2(20, 165), 0.1f).SetEase(Ease.InBounce);
    }
        
}
