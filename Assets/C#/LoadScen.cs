using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen : MonoBehaviour
{
    [SerializeField] string nameScen;
    public void OnClickButton()
    {
        StartCoroutine(Waiter());
      
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(nameScen);
        Time.timeScale = 1;
    }
}
