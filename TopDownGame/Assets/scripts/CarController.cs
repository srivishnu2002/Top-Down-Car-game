using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{

    public FixedJoystick joystick;
    Rigidbody2D rb;
    public float moveSpeed;
    Vector2 move;
    public static float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
        Application.targetFrameRate = 100;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0f)
        {
            SceneManager.LoadScene("game over");
        }

        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;

        float hAxis = move.x;
        float vAxis = move.y;
        float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -zAxis);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "enemy bullet")
        {
            health -= 5f;
        }
    }
}
