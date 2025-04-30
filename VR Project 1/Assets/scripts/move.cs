using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocity;
    public Transform playerLocation;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        forwards();
        if (playerLocation.position.x > transform.position.x) {
            transform.Rotate(0f,0f,5f, Space.Self);
        }
        else if (playerLocation.position.x < transform.position.x) {
            transform.Rotate(0f,0f,-5f, Space.Self);
        }
        if (playerLocation.position.y > transform.position.y) {
            transform.Rotate(0f,0f,5f, Space.Self);
        }
        else if (playerLocation.position.y < transform.position.y) {
            transform.Rotate(0f,0f,-5f, Space.Self);
        }
    }
    void forwards()
    {
        transform.Translate(new Vector3(0,0,velocity * Time.deltaTime));
    }
}
