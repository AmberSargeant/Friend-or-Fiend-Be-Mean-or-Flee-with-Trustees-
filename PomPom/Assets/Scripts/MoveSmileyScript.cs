using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSmileyScript : MonoBehaviour
{
    private int speed = 40;

    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }
}
