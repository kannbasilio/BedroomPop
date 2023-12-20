using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void ButtonPressed()
    {
        ScoreManager.scoreValue = 100;
        SceneManager.LoadScene("StartScreen");
    }
}
