using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private Transform cube;

    [SerializeField] private float moveSpeed = 4;
    [SerializeField] private float rotateSpeed = 4;
    [SerializeField] private float scaleSpeed = 4;

    private Image img;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(img.ChangeColor(Color.green, 3));


        StartCoroutine(nameof(CubeMove));
        StartCoroutine(nameof(CubeRotate));
        StartCoroutine(nameof(CubeScale));

    }

    [SerializeField] float startTime;
    [SerializeField] float duration = 5;
    [SerializeField] float goalPosX = 5;

    float xPos = 0.5f;
    IEnumerator CubeMove()
    {


        while (true)
        {
            startTime += Time.deltaTime;
            float t = startTime / duration;

            cube.position = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(goalPosX, 0, 0), t);


            cube.position = new Vector3(xPos, 0, 0);
            xPos += 0.1f * moveSpeed;

            yield return null;


            if (t >= 1)
                break;
        }

        cube.position = new Vector3(xPos, 0, 0);
    }



    IEnumerator CubeRotate()
    {
        float yRot = 0;

        while (true)
        {
            cube.eulerAngles = new Vector3(0, yRot, 0);
            yRot += 0.2f * rotateSpeed;

            yield return null;


            if (yRot > 100)
                break;
        }
    }

    IEnumerator CubeScale()
    {
        float Scale = 1;

        while (true)
        {
            cube.localScale = new Vector3(Scale, Scale, Scale);
            Scale += 0.1f * scaleSpeed;

            yield return null;


            if (Scale > 2.2f)
                break;
        }

        while (true)
        {
            cube.localScale = new Vector3(Scale, Scale, Scale);
            Scale -= 0.1f * scaleSpeed;

            yield return null;


            if (Scale < 2)
                break;
        }
    }
}