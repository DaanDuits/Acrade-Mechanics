using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float jumpHeight;

    public Transform player;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += player.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= player.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= player.right * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += player.right * Speed * Time.deltaTime;
        }
    }
}
