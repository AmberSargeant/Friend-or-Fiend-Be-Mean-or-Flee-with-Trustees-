﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadePomScript : MonoBehaviour
{
    public float FadeRate;
    private Image image;
    private float targetAlpha;
    private int speed = 10;
    // Use this for initialization
    void Start()
    {
        this.image = this.GetComponent<Image>();
        if (this.image == null)
        {
            Debug.LogError("Error: No image on " + this.name);
        }
        Material instantiatedMaterial = Instantiate<Material>(this.image.material);
        this.image.material = instantiatedMaterial;
        this.targetAlpha = this.image.material.color.a;
    }

    // Update is called once per frame
    void Update()
    {

        Color curColor = this.image.material.color;
        float alphaDiff = Mathf.Abs(curColor.a - this.targetAlpha);
        if (alphaDiff > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, this.FadeRate * Time.deltaTime);
            this.image.material.color = curColor;
        }
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        FadeOut();
    }

    public void FadeOut()
    {
        this.targetAlpha = 0.0f;
    }

    public void FadeIn()
    {
        this.targetAlpha = 1.0f;
    }
}
