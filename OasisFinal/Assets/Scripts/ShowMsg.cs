using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMsg : MonoBehaviour
{
    public float distanceToShow;
    public Renderer msgRender;

    void Update()
    {
        msgRender.enabled = Vector3.Distance(Camera.main.transform.position, transform.position) < distanceToShow;
    }
}
