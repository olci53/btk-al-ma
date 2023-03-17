using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf_Clamp_sinirkoyma : MonoBehaviour
{
    [SerializeField] private float min;
    [SerializeField] private float max;
    [SerializeField] private float time;

    private void Update()
    {
        float xDegeri = Mathf.Sin(time*5.0f);

        float xPos = Mathf.Clamp(xDegeri, min, max);

        transform.position = new Vector3(xPos, 0, 0);

        time += Time.deltaTime;

    }

}
