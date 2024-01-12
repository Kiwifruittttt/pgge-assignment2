using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    // Start is called before the first frame update
    void Start()
    {
        //Ensures sound plays when switching scenes
        DontDestroyOnLoad(audioSource1);
        DontDestroyOnLoad(audioSource2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSinglePlayer()
    {
        PlaySound();
        //Debug.Log("Loading singleplayer game");
        SceneManager.LoadScene("SinglePlayer");
    }

    public void OnClickMultiPlayer()
    {
        PlaySound();
        //Debug.Log("Loading multiplayer game");
        SceneManager.LoadScene("Multiplayer_Launcher");
    }

    public void PlaySound()
    {
        if (Random.Range(0, 2) == 0)
        {
            audioSource1.Play();
        }
        else
        {
            audioSource2.Play();
        }
    }

}
