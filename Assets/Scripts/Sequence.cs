using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSequenceGame : MonoBehaviour
{
    public ScoreManager scoreManager;
    public AudioSource recordScratch;
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
                
                SceneManager.LoadScene("Bedroom");

            }
        }

        else
        {
            ScoreManager.scoreValue -= 1;
            recordScratch.Play();
            currentIndex = 0;

        }
    }
}