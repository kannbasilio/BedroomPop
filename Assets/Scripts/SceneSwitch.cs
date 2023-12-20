using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneToLoad;
    public AudioSource backMusic;
    public AudioSource openSong;
    public static int clicks = 0;

    void OnMouseDown()
    {

        backMusic.Stop();
        openSong.Play(); 

        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneToLoad);
    }

    void Update()
    {
        if (clicks == 5)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}