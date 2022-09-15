using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float HorizontalSpeed = 2.0f;
    public float VerticalSpeed = 2.0f;

    public Vector2 startPosition = new Vector2(0.0f, -4.5f);

    public Boundry bounds;

    private void Start()
    {
        transform.position = startPosition;
    }
    void Update()
    {

        Move();
        clampInBounds();

    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * HorizontalSpeed;
        float y = Input.GetAxisRaw("Vertical") * VerticalSpeed;

        transform.position += new Vector3(x, y, 0) * Time.deltaTime;
    }

    private void clampInBounds()
    {
        float clampedX = Mathf.Clamp(transform.position.x, bounds.XMin, bounds.XMax);
        float clampedY = Mathf.Clamp(transform.position.y, bounds.YMin, bounds.YMax);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
