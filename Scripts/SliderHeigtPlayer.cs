using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderHeigtPlayer : MonoBehaviour
{
    public Scrollbar scrollbar; // Reference to the Scrollbar component
    public float minScale = 0.5f; // Minimum scale value
    public float maxScale = 1.5f; // Maximum scale value

    private void Start()
    {
        // Add a listener to the scrollbar's value changed event
        scrollbar.onValueChanged.AddListener(ChangeScale);
    }

    public void ChangeScale(float value)
    {
        // Calculate the desired scale based on the scrollbar's value
        float scale = Mathf.Lerp(minScale, maxScale, value);

        // Apply the scale to the object
        transform.localScale = new Vector3(scale, scale, scale);
    }
}

