using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMenager : MonoBehaviour
{

    [field: SerializeReference] public static PlatformMenager curent { get; private set; }
    [SerializeReference] private GameObject LastGameObject;
    [field: SerializeField] public float speed { get; private set; }


    [field: SerializeReference] public Vector3 Offset { get; private set; }
    [field: SerializeReference] List<GameObject> Platforms_01 { get; set; }
    private void MoveOnEnd()
    {
        for (int i = 0; i < Platforms_01.Count; i++)
        {
            if (Platforms_01[i].activeSelf == false)
            {

                Platforms_01[i].transform.position = LastGameObject.transform.position + Offset;
                LastGameObject = Platforms_01[i];
                Platforms_01[i].SetActive(true);
                Platforms_01[i].GetComponent<MovePlatform>().StartMove();
            }
        }
    }
    public void InvokeOnaNextPlatform()
    {
        OnaNextPlatform?.Invoke();
    }

    public void ChangeSpeed(int switch_on)
    {
        switch (switch_on)
        {
            case 20:
                speed = 1f;
                break;
            case 40:
                speed = 1.25f;
                break;
            case 60:
                speed = 1.25f;
                break;
            case 100:
                speed = 2.25f;
                break;
            case 200:
                speed = 3f;
                break;
            default:
                break;
        }
    }

    public delegate void Platform();
    public static Platform OnaNextPlatform;
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

        OnaNextPlatform += MoveOnEnd;
    }
    private void OnDisable()
    {
        OnaNextPlatform -= MoveOnEnd;
    }

}
