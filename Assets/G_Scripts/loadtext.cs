using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadtext : MonoBehaviour
{

    public Text textload;   

    void Start()
    {
        StartCoroutine(LoadingGame());      
    }

    IEnumerator LoadingGame()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("MainScene");      
        async.allowSceneActivation = false;                                   
        while (!async.isDone)                                                 
        {
            if (async.progress >= 0.9f)                                       
            {
                textload.text = "Loading 100%\nPRESS TO CONTINUE";                    
                if (Input.anyKey)                                             
                    async.allowSceneActivation = true;                        
            }                                                                         
            else
                textload.text = "Loading " + async.progress / 0.9f * 100 + "%";   
            yield return null;
        }
    }
}