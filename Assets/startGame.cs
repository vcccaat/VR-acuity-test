using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public GameObject canvas;
    public void HideCanvas()
    {
        canvas.SetActive(false);   
    }
}
