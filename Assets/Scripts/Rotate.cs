using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Rotate target;
    public float rotationSpeed;


    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        // Spin the object around the target at 20 degrees/second
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);    
        }
}
