using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public UnityEngine.Vector2 turn;
    public float sensitivity = 0.5f;
    public UnityEngine.Vector3 deltaMove;
    public float speed = 1;
    public GameObject mover;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        mover.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);

        deltaMove = new UnityEngine.Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        mover.transform.Translate(deltaMove);
    }
}