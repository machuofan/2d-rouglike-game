using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public float scale = 120f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        if (scale > 0.05f)
        {
            scale -= 0.05f;
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
