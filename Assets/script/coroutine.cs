using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine : MonoBehaviour
{
    [SerializeField] private GameObject kup;

    IEnumerator gorunurlukkapat()
    {
        yield return new WaitForSeconds(3f);

        kup.SetActive(false);

        yield return new WaitForSeconds(2f);

        kup.SetActive(true);

    }

    private void Start()
    {
        StartCoroutine(gorunurlukkapat());
    }



}
