using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private int RegistrationIndex = 1;
    private int playSceneIndex = 2;
    private int LoginIndex = 3;

    public void Play ()
    {
        SceneManager.LoadScene(playSceneIndex);
    }

	public void SignIn()
    {
        SceneManager.LoadScene(LoginIndex);
    }
    public void SignOn()
    {
        SceneManager.LoadScene(RegistrationIndex);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
