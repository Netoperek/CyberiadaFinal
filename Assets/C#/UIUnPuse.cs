using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUnPuse : MonoBehaviour
{
    [SerializeReference] Score score;
    public void OnClickButton()
    {
        Time.timeScale = 1;
        score.StartCount();
    }
}
