

using UnityEngine;

public class Mover : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Mover script has started.");
       
    }

    void move_up(float speed)
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        Debug.Log("Moving up with speed: " + speed);
    }

    void move_forward(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        Debug.Log("Moving forward with speed: " + speed);
    }
    void move_right(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        Debug.Log("Moving right with speed: " + speed);
    }
    void move_left(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
        Debug.Log("Moving left with speed: " + speed);
    }
    void move_backward(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.back * speed);
        Debug.Log("Moving backward with speed: " + speed);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            move_up(5f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            move_forward(5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            move_right(5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            move_left(5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            move_backward(5f);
        }
    }
}