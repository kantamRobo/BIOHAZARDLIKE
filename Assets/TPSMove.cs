using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        var horizontal = transform.forward *Input.GetAxis("Vertical");
        var vertical = transform.right * Input.GetAxis("Horizontal");

        rb.AddForce(vertical + horizontal);

    }
}
