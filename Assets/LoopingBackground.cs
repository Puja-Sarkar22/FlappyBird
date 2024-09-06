using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    { //renderer= want to see a image it is rendered in the background to show to the user
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
    }
}