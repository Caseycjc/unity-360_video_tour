using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneChanger : MonoBehaviour
{
    public void ChangeSceneTest(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
