using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyControl : MonoBehaviour {

    public float lowPosition;
    public float highPosition;
    private float distance;
    private float frequency = .5f;
    
    public Transform[] graphsFrequency = new Transform[6];
    private float[] initialPosition;

    // Use this for initialization
    void Start () {
        distance = (highPosition - lowPosition);
        initialPosition = new float[graphsFrequency.Length];
        for(int a = 0; a < initialPosition.Length; a++)
        {
            initialPosition[a] = graphsFrequency[a].localPosition.x;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int a = 0; a < graphsFrequency.Length; a++)
            graphsFrequency[a].localPosition = new Vector3(initialPosition[a] - frequency * distance,
                                                           graphsFrequency[a].localPosition.y, 
                                                           graphsFrequency[a].localPosition.z);
    }


    public void Slider(float _frequency)
    {
        frequency = _frequency/100.0f;
    }
}
