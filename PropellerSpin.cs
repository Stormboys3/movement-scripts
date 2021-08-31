using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Variables
    private float spinSpeed = 100;

    // Update is called once per frame
    void Update()
    {
        //makes an object rotate in the z axis
        transform.Rotate(Vector3.forward * spinSpeed);
    }
}
