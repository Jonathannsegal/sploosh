using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    public string newScene;
    public void ChangeScene()
    {
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);
    }
}
