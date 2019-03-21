//Attach this script to a GameObject
//Create an Image GameObject by going to Create>UI>Image. Attach this Image to the Image field in your GameObject’s Inspector window.
//This script creates a toggle that fades an Image in and out.
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeScriptBlack : MonoBehaviour
{
    //Attach an Image you want to fade in the GameObject's Inspector
    public Image m_Image;
    //Use this to tell if the toggle returns true or false
    private IEnumerator coroutine;

    private void Start()
    {
        m_Image.CrossFadeAlpha(0, 0f, true);
        coroutine = fade(5.0f);
        StartCoroutine(coroutine);
    }
    void Update()
    {
        //If the toggle returns true, fade in the Image
        /*if (m_Fading == true)
        {
            //Fully fade in Image (1) with the duration of 2
            m_Image.CrossFadeAlpha(1, 2.0f, false);

        }
        //If the toggle is false, fade out to nothing (0) the Image with a duration of 2
        if (m_Fading == false)
        {
            m_Image.CrossFadeAlpha(0, 2.0f, false);
        }*/


    }
    private IEnumerator fade(float waitTime)
    {
        m_Image.CrossFadeAlpha(1, 2.0f, false);
        yield return new WaitForSeconds(waitTime);
      
    }

}