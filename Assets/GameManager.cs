using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;

    Coroutine curCoroutine;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("��ŸƮ �Լ� ����");

        StartCoroutine(nameof(CubeFalse), 2);
        curCoroutine = StartCoroutine(CubeFalse(2, 3));

        Debug.Log("��ŸƮ �Լ� ����");
    }


    IEnumerator CubeFalse(float delay1, float delay2)
    {
        Debug.Log("�ڷ�ƾ ����");

        yield return new WaitForSeconds(delay1);

        cube1.SetActive(false);

        yield return new WaitForSeconds(delay2);

        cube2.SetActive(false);
    }

    IEnumerator CubeTure()
    {
        Debug.Log("�ڷ�ƾ ����");

        yield return new WaitForSeconds(2);

        cube1.SetActive(true);

        yield return new WaitForSeconds(3);

        cube2.SetActive(true);
    }

    public void Stop()
    {
        StopCoroutine(curCoroutine);

        StopAllCoroutines();
    }
}
