using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float HorizontalSpeed = 2.0f;
    public float VerticalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * HorizontalSpeed; ;
        float y = Input.GetAxisRaw("Vertical") * VerticalSpeed;

        transform.position += new Vector3(x, y, 0) * Time.deltaTime; 
        //The reason transform.positon += new Vector2(x, y);
        //doesn't work is cause it doesn't like you adding a vector2 to a vector3
        //2d engine is just the 3d engine

    }
}
