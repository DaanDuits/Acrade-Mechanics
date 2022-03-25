using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up : MonoBehaviour
{
    public GameObject des;

    
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>().pickUp = true;
            Destroy(des, 0.2f);
        }

    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        
    }
}
