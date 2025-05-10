using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    [SerializeField] private Image uiimage;
    [SerializeField] private Image uiimage2;
    [SerializeField] private Image uiimage3;

    [SerializeField] private Image uiimage4;
    [SerializeField] private Image uiimage5;


    [SerializeField] private Color color;
    [SerializeField] private float duration;

    void Start()
    {
        //color
        StartCoroutine(ChangeColor(uiimage, Color.red, 2));
        StartCoroutine(ChangeColor(uiimage2, Color.blue,  2));
        StartCoroutine(ChangeColor(uiimage3, Color.green, 2));
        //fade
        StartCoroutine(Fade(uiimage4, 0, 2));
        StartCoroutine(Fade(uiimage5, 1, 2));

    }
    IEnumerator ChangeColor(Image img, Color changeColor, float duration)
    {
        float startTime = 0;
        Color startColor = img.color;

        while (startTime < duration)
        {
            //t
            startTime += Time.deltaTime;
            float t = startTime / duration;
            
            //lerp
            img.color = Color.Lerp(startColor, changeColor, t);
            yield return null;
        }
    }

    IEnumerator Fade(Image img, float fade, float duration)
    {
        float startTime = 0;
        Color startColor = img.color;
        Color fadeColor = img.color;
        fadeColor.a = fade;

        while (startTime < duration)
        {
            //t
            startTime += Time.deltaTime;
            float t = startTime / duration;

            //lerp
            img.color = Color.Lerp(startColor, fadeColor, t);
            yield return null;
        }
    }
}
