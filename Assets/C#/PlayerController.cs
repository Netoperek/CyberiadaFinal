using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [field: SerializeField] Vector3 leftPos;
    [field: SerializeField] Vector3 centerPos;
    [field: SerializeField] Vector3 rightPos;
    [field: SerializeField] float speedMove { get; set; }
    // [SerializeReference] InputActionPlayer inputs;
    [SerializeReference] Rigidbody rb;
    Vector2 startPos;
    private enum Stat { left, center, right }
    private Stat current;
    private void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;
                case TouchPhase.Moved:

                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    if (startPos.x < touch.position.x)
                    {
                        Move(Stat.right);
                    }
                    else
                    {
                        Move(Stat.left);
                    }
                    break;
                case TouchPhase.Canceled:
                    break;
                default:
                    break;
            }
        }

    }
    private void Move(Stat stat)
    {
        switch (current)
        {
            case Stat.left:
                rb.transform.position = centerPos;
                current = Stat.center;
                break;
            case Stat.center:
                if (stat == Stat.right)
                {
                    rb.transform.position = rightPos;
                    current = Stat.right;
                }
                else if (stat == Stat.left)
                {
                    rb.transform.position = leftPos;
                    current = Stat.left;
                }

                break;
            case Stat.right:
                rb.transform.position = centerPos;
                current = Stat.center;
                break;
            default:
                break;
        }

    }
}
