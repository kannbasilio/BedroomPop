using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSequenceGame : MonoBehaviour
{
    public Button[] buttonsInSequence; // An array to store buttons in the correct sequence
    private int currentIndex;

    private void Start()
    {
        currentIndex = 0;

    }

    public void ButtonPressed(Button button)
    {
        // Check if the pressed button is the one in the current sequence position
        if (button == buttonsInSequence[currentIndex])
        {
            currentIndex++;

            // If the entire sequence is pressed correctly
            if (currentIndex == buttonsInSequence.Length)
            {
                
                Debug.Log("It works");
                SceneManager.LoadScene("Bedroom");

            }
        }

        else
        {
            ColorBlock colors = button.colors;
            colors.pressedColor = Color.red;
            button.colors = colors;

            // Reset sequence if the wrong button is pressed
            currentIndex = 0;

        }
    }
}