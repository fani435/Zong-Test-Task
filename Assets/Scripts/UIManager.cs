using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject stoneCanvas;
    public GameObject mainCanvas;
    public Button previousButton;
    public Color greenColor;

    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void ShowMainCanvas()
    {
        stoneCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void HideMainCanvas()
    {
        mainCanvas.SetActive(false);
        stoneCanvas.SetActive(true);
    }

    public void ButtonPressed(Button pressedButton)
    {
        previousButton.image.color = greenColor;
        pressedButton.image.color = Color.white;
        previousButton = pressedButton;
    }
}
