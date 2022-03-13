using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePlacement : MonoBehaviour
{
    void Start()
    {
        int willSpawn = Random.Range(0, 4);
        if (willSpawn == 2)
        {
            Destroy(this.gameObject);
        }
        Vector3 rotation = new Vector3(0, Random.Range(0, 360f), 0);
        Vector3 offset = new Vector3(Random.Range(-7.5f, 7.5f), 0, Random.Range(-7.5f, 7.5f));
        transform.eulerAngles = rotation;
        transform.position += offset;
        RayCast();
    }

    public void RayCast()
    {
        Vector3 pos = this.transform.position;
        Ray ray = new Ray(pos, -transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            transform.position = hit.point;
        }

    }
}
