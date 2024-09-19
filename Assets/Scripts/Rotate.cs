using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        float rotationSpeed = 10.0f;
        transform.Rotate (new Vector3 (15, 30, 45) * rotationSpeed * Time.deltaTime);

    }
}
