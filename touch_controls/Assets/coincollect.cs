using UnityEngine;
using System.Collections;

public class coincollect : MonoBehaviour
{

    public float fallSpeed = 20.0f;
    public float spinSpeed = 50.0f;

    void Update()
    {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

    }
}
