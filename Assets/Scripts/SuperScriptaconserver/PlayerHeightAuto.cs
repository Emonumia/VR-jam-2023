using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerHeightAuto : MonoBehaviour
{
    public Transform playerObject; // Reference to the player's GameObject
    public float minScale = 0.5f; // Minimum scale value
    public float maxScale = 1.5f; // Maximum scale value

    private float initialPlayerHeight; // Initial height of the player

    private void Start()
    {
        // Get the initial height of the player
        initialPlayerHeight = playerObject.localPosition.y;

        // Subscribe to the XR rig tracking space updated event
        XRDevice.deviceLoaded += OnXRDeviceLoaded;
        // Update the player's scale continuously (in case the player not moves up or down)
        UpdatePlayerScale();

    }

    private void OnXRDeviceLoaded(string deviceName)
    {
        // Update the player's scale when the XR device is loaded or reloaded
        UpdatePlayerScale();
    }

    private void Update()
    {
        // Update the player's scale continuously (in case the player moves up or down)
        //UpdatePlayerScale();
    }

    private void UpdatePlayerScale()
    {
        // Calculate the player's height relative to the initial height
        float playerHeight = playerObject.localPosition.y - initialPlayerHeight;

        // Calculate the t value based on the player's height
        float t = Mathf.InverseLerp(0f, maxScale - minScale, playerHeight);

        // Calculate the desired scale based on the t value
        float scale = Mathf.Lerp(minScale, maxScale, t);

        // Apply the scale to the player object
        playerObject.localScale = new Vector3(scale, scale, scale);
    }
}

