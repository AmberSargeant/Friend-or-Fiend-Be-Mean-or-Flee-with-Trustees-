using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public int speed;
    public MainScript script;

    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        if (script.StopScreen)
        {
            speed = 0;
        }
    }
}