using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class ScoreScript : MonoBehaviour
{
    private Animator animator;
    public GameObject endGamePanel;

    private void Start()
    {
        endGamePanel.SetActive(false);
        animator = GetComponent<Animator>();
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
        if (aiScore == 7)
        {
            StartCoroutine(PurpleWin());
        }

        if (playerScore == 7)
        {
            StartCoroutine(BlueWin());
        }
    }

    IEnumerator PurpleWin()
    {

        animator.SetTrigger("GanaMorado");
        yield return new WaitForSeconds(3f);
        animator.ResetTrigger("GanaMorado");
        endGamePanel.SetActive(true);
        Time.timeScale = 0f;


    }

    IEnumerator BlueWin()
    {
        animator.SetTrigger("GanaCeleste");

        yield return new WaitForSeconds(3f);
        animator.ResetTrigger("GanaCeleste");
        endGamePanel.SetActive(true);
        Time.timeScale = 0f;


    }

}
