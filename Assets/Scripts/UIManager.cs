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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showMainCanvas()
    {
        stoneCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void ButtonPressed(Button pressedButton)
    {
        previousButton.image.color = greenColor;
        pressedButton.image.color = Color.white;
        previousButton = pressedButton;
    }
}
