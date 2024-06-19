using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public int totalScore;
    public int totalApplesInLevel; // N�mero total de ma��s na fase

    public Text scoreText;
    public TextMeshProUGUI completedText;

    public static gameController instance;

    void Start()
    {
        instance = this;
        totalScore = 0; // Inicializa a pontua��o
        UpdateScoreText(); // Atualiza a UI na inicializa��o
    }

    public void AddApple(int score)
    {
        totalScore += score;
        UpdateScoreText();
        CheckIfLevelCompleted();
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore + "/" + totalApplesInLevel;
    }

    void CheckIfLevelCompleted()
    {
        if (totalScore >= totalApplesInLevel)
        {
            completedText.gameObject.SetActive(true);
            StartCoroutine(CompleteLevel());
        }
    }

    IEnumerator CompleteLevel()
    {
        yield return new WaitForSeconds(6);
         SceneManager.LoadScene("Menu");
    }
}
