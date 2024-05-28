using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class gamesys : MonoBehaviour
{
    public UnityEvent VisibleEvent, InvisibleEvent;
    private void OnBecameVisible()
    {
        VisibleEvent?.Invoke();
    }
    private void OnBecameInvisible()
    {
        InvisibleEvent?.Invoke();
    }

    public void ChangeScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GameQuit() 
    {
        Application.Quit();
    }
   
}
