using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPuse : MonoBehaviour
{
    [SerializeReference] Score score;
    [SerializeReference] PlayerController player;
    public void OnClickButton()
    {
        player.enabled = false;
        Time.timeScale = 0;
        score.StopCount();
    }
}
