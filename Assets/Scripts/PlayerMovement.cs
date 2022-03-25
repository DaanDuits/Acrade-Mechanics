using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float jumpHeight = 10;
    public bool canjump = false;

    public Transform point;

    public Animator animator;

    public bool pickUp = false;

    public LayerMask layer;

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
        canjump = Physics.CheckSphere(point.position, 0.4f, layer);
        animator.SetFloat("Speed", 0);
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += player.forward * Speed * Time.deltaTime;
            animator.SetFloat("Speed", Speed * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= player.forward * Speed * Time.deltaTime;
            animator.SetFloat("Speed", Speed * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= player.right * Speed * Time.deltaTime;
            animator.SetFloat("Speed", Speed * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += player.right * Speed * Time.deltaTime;
            animator.SetFloat("Speed", Speed * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.Space)&& canjump == true && pickUp == true) 
        {
            rb.velocity = new Vector3(0, jumpHeight, 0);
        }
    }
}
