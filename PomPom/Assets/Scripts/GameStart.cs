using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject Help;
    private IEnumerator coroutine;
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void doExitGame()
    {
        Application.Quit();
    }
    public void showPhoto()
    {
        coroutine = Begin(5.0f);
        StartCoroutine(coroutine);
    }
    private IEnumerator Begin(float waitTime)
    {
        Help.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        Help.SetActive(false);
    }
}