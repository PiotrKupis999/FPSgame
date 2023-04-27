using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction;

        if ((direction = Input.GetAxis("Horizontal")) != 0)
        {
            transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
        }

        if ((direction = Input.GetAxis("Vertical")) != 0)
        {
            transform.position += new Vector3(0, 0, direction * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

    }
}
