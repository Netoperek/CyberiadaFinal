using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenpopupDead : MonoBehaviour
{
    [SerializeReference] GameObject popup;
    [SerializeReference] Score score;
    [SerializeReference] TMP_Text text;
    [SerializeReference] PlayerController player;
    public void Open()
    {
        popup.SetActive(true);
        OnClickButton();
        text.text = score.GetScore().ToString();


    }
    public void OnClickButton()
    {
        player.enabled = false;
        Time.timeScale = 0;
        score.StopCount();
    }
}
