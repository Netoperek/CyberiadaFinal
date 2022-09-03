using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    [SerializeReference] Transform _player;
    [SerializeField] float speed;
    Vector3 _position = Vector3.zero;
    private void Awake()
    {
        _position.z = transform.position.z;
    }
    private void Update()
    {
        _position.y = transform.position.y;
        _position.x = Mathf.Lerp(transform.position.x, _player.position.x, speed * Time.deltaTime);
        transform.position = _position;

    }
}
