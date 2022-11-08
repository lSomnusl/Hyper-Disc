using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class ScoreScript : MonoBehaviour
{

    public GameObject endGamePanel;

    private void Start()
    {
        endGamePanel.SetActive(false);
    }

    public enum Score
    {
        AiScore, PlayerScore
    }

    public TextMeshProUGUI AiScoreTxt, PlayerScoreTxt;
    private int aiScore, playerScore;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoreTxt.text = (++aiScore).ToString();
        else
            PlayerScoreTxt.text = (++playerScore).ToString();
    }

    private void Update()
    {
        if (aiScore == 1)
        {
            StartCoroutine(PurpleWin());
        }

        if (playerScore == 1)
        {
            StartCoroutine(BlueWin());
        }
    }

    IEnumerator PurpleWin()
    {
       //Insertar Animacion morado ganador

        yield return new WaitForSeconds(2f);

        endGamePanel.SetActive(true);
        Time.timeScale = 0f;


    }

    IEnumerator BlueWin()
    {
        //Insertar Animacion azul ganador

        yield return new WaitForSeconds(2f);

        endGamePanel.SetActive(true);
        Time.timeScale = 0f;


    }

}
