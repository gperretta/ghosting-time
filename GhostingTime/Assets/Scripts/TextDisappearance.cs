using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// - Attached to StartText object
/// - timer: increased by adding delta time
/// - max time: when timer will be expired
/// - timer -> when expired, the text will be destroyed
/// </summary>
public class TextDisappearance : MonoBehaviour
{
    public float timer = 0;
    public float maxTime = 2;

    // Update is called once per frame
    void Update()
    {
        if (timer < maxTime)
        {
            timer += Time.deltaTime;
        } else
        {
            Destroy(gameObject);
        }
    }
}
