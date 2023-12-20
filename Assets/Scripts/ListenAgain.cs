using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListenAgain : MonoBehaviour
{
    public AudioSource againSong;

    public void ButtonPressed()
    {
        againSong.Play();
        ScoreManager.scoreValue -= 3;

    }
}
