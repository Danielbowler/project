using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{    
    public float turnspeed = 5;
    public float horizontalInput;
    public float verticalInput;
    
    
     // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the object
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnspeed * Time.deltaTime);

        

    }
}
