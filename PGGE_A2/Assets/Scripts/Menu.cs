using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Ensures sound plays when switching scenes
        DontDestroyOnLoad(audioSource);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSinglePlayer()
    {
        audioSource.Play();
        //Debug.Log("Loading singleplayer game");
        SceneManager.LoadScene("SinglePlayer");
    }

    public void OnClickMultiPlayer()
    {
        audioSource.Play();
        //Debug.Log("Loading multiplayer game");
        SceneManager.LoadScene("Multiplayer_Launcher");
    }

}
