using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lateupdate_fixedupdate : MonoBehaviour
{
    private void LateUpdate()
    {
        Debug.Log("lateupdate" + Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("fixed update" + Time.deltaTime);
    }

}
