using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        x = Random.Range(-3.0f, 3.0f);
        y = Random.Range(-3.0f, 3.0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(new Vector3(x, y) * 10f);
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
