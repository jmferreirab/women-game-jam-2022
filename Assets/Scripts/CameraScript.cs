using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Penguin;

    void Update()
    {
        if (Penguin != null)
        {
            Vector3 position = transform.position;
            position.x = Penguin.transform.position.x;
            position.y = Penguin.transform.position.y;
            transform.position = position;
        }
    }
}
