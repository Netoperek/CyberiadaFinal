using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMenager : MonoBehaviour
{
    [field: SerializeReference] public static PlatformMenager curent { get; private set; }
    private Transform LastGameObject;
    [field: SerializeField] public float speed { get; private set; }
    private void Awake()
    {
        if (curent != null && curent != this)
        {
            Destroy(this);
        }
        else
        {
            curent = this;
        }
        LastGameObject = Platforms_01[0].GetComponent<Transform>();
    }

    [field: SerializeReference] public Vector3 Offset { get; private set; }
    [field: SerializeReference] List<GameObject> Platforms_01 { get; set; }
    [field: SerializeReference] List<GameObject> Platforms_02 { get; set; }
    [field: SerializeReference] List<GameObject> Platforms_03 { get; set; }
    [field: SerializeReference] List<GameObject> Platforms_04 { get; set; }
    private void FixedUpdate()
    {

    }
}
