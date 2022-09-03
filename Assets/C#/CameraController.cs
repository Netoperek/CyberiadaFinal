using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CameraController : MonoBehaviour
{
    [field: SerializeField] float speedScore { get; set; }
    private float score = 0f;
    [SerializeReference] TextMeshPro text;
    private void Awake()
    {
        StartCoroutine(Score());
    }
    IEnumerator Score()
    {
        while (true)
        {
            score++;
            text.text = score.ToString();

            yield return new WaitForSecondsRealtime(speedScore);
        }
    }
}
