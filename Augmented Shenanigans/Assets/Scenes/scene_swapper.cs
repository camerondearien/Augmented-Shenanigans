using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_swapper : MonoBehaviour
{
    // string for inputting what scene you want to go to through unity's interface
    public string sceneName;

    // wait for the button to be clicked/touched
    public void OnMouseDown() {
        Debug.Log("changing scenes");
        SceneManager.LoadScene(sceneName);
    }
}
