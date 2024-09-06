using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    public UnityEngine.UI.Slider slider;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.2f, 1, 0.5f) * slider.value * Time.deltaTime);
    }
}
