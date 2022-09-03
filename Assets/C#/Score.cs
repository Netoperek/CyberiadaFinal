using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score curent;
    private void OnEnable()
    {
        if (curent != null && curent != this)
        {
            Destroy(this);
        }
        else
        {
            curent = this;
        }
    }
    [field: SerializeField] float speedScore { get; set; }
    private int score = 0;
    public int GetScore()
    {
        return score;
    }
    [SerializeReference] TMP_Text text;
    private void Start()
    {
        StartCoroutine(ScoreCounter());
    }

    IEnumerator ScoreCounter()
    {
        while (true)
        {
            score++;
            text.text = score.ToString();
            PlatformMenager.curent.ChangeSpeed(score);
            yield return new WaitForSecondsRealtime(speedScore);
        }
    }

    public void StartCount()
    {
        StartCoroutine(ScoreCounter());
    }
    public void StopCount()
    {
        StopAllCoroutines();
    }

}
