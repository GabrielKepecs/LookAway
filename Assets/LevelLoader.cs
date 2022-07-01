using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider slider;
    public void LoadLevel(string LevelName)
    {
        StartCoroutine(LoadAscync(LevelName));
    }

    IEnumerator LoadAscync(string LevelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(LevelName);
        LoadingScreen.SetActive(true);
        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);

            slider.value = progress;

            yield return null;
        }
    }
}
