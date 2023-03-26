using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌");
        GameObject.Destroy(this.gameObject);
        GameObject.Destroy(other.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(gameObject,3f);
    }
    public float ShotSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += ShotSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
