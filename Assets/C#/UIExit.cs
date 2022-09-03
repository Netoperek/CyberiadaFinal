using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIExit : MonoBehaviour
{
    public void OnClickButton()
    {
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Application.Quit();
    }
}
