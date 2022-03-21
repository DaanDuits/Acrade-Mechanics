using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_pick_up : MonoBehaviour
{
    public GameObject des;

    
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(des, 0.2f);

    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }
}
