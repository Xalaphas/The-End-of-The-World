using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionToNextScene : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
