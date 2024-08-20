using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyDoom : MonoBehaviour
{
    [Header("Set Me")]
    public int degrees = 20;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, degrees) * Time.deltaTime);
    }
}
