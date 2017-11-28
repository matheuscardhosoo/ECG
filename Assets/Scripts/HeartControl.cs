using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartControl : MonoBehaviour
{
    public GameObject heart;
    private Vector3 initialAngles;
    private float rotate;

    void Start () {
        initialAngles = heart.transform.localEulerAngles;

    }

	void Update ()
    {
        heart.transform.localEulerAngles = new Vector3(initialAngles.x, initialAngles.y, rotate);
    }

    public void Slider(float _rotate)
    {
        rotate = _rotate;
    }
}
