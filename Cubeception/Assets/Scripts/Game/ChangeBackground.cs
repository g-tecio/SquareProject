using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour {

    private Camera cameraColor;
    private float cycleSeconds = 10f;
    void Awake()
    {
        cameraColor = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraColor.backgroundColor = Color.HSVToRGB(
            Mathf.Repeat(Time.time / cycleSeconds, 1f),
            0.3f, 0.7f
        );
    }

    void Changecolor()
    {
        // camera.backgroundColor = Color.HSVToRGB(
        //     Mathf.Repeat(Time.time / cycleSeconds, 1f),
        //     0.3f, 0.7f
        // );
    }
}
