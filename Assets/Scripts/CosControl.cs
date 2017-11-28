using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosControl : MonoBehaviour {
    // 
    [System.Serializable]
    public class GraphOffset
    {
        public float p = 45;
        public float q = 105;
        public float r = -30;
        public float s = -120;
        public float t = 60;
    }
    public GraphOffset graphOffset;

    //
    private float angle;
    public float cos;

    //
    private class Graph
    {
        public float readOffset = 0;
        public Transform p;
        public Transform q;
        public Transform r;
        public Transform s;
        public Transform t;
        public Vector3 pInitialScale;
        public Vector3 qInitialScale;
        public Vector3 rInitialScale;
        public Vector3 sInitialScale;
        public Vector3 tInitialScale;
        public Graph() { }
        public void init(Transform father,float _readOffset)
        {
            p = father.GetChild(0);
            q = father.GetChild(1);
            r = father.GetChild(2);
            s = father.GetChild(3);
            t = father.GetChild(4);
            pInitialScale = p.localScale;
            qInitialScale = q.localScale;
            rInitialScale = r.localScale;
            sInitialScale = s.localScale;
            tInitialScale = t.localScale;
            readOffset = _readOffset;
        }
    }
    private Graph[] graphs;

    public Transform[] fatherGraphs = new Transform[12];
    public float[] readOffset = new float[12];

    // Use this for initialization
    void Start () {
        graphs = new Graph[fatherGraphs.Length];
        for (int a = 0; a < fatherGraphs.Length; a++)
        {
            graphs[a] = new Graph();
            graphs[a].init(fatherGraphs[a], readOffset[a]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		for(int a = 0; a < graphs.Length; a++)
        {
            // p
            cos = Mathf.Cos( ((angle + graphOffset.p - graphs[a].readOffset) *Mathf.PI)/180.0F );
            graphs[a].p.localScale = new Vector3(graphs[a].pInitialScale.x, 
                                                           cos * graphs[a].pInitialScale.y,
                                                           graphs[a].pInitialScale.z);
            // q
            cos = Mathf.Cos(((angle + graphOffset.q - graphs[a].readOffset) * Mathf.PI) / 180.0F);
            graphs[a].q.localScale = new Vector3(graphs[a].qInitialScale.x,
                                                           -cos * graphs[a].qInitialScale.y,
                                                           graphs[a].qInitialScale.z);
            // r
            cos = Mathf.Cos(((angle + graphOffset.r - graphs[a].readOffset) * Mathf.PI) / 180.0F);
            graphs[a].r.localScale = new Vector3(graphs[a].rInitialScale.x,
                                                           cos * graphs[a].rInitialScale.y,
                                                           graphs[a].rInitialScale.z);
            // s
            cos = Mathf.Cos(((angle + graphOffset.s - graphs[a].readOffset) * Mathf.PI) / 180.0F);
            graphs[a].s.localScale = new Vector3(graphs[a].sInitialScale.x,
                                                           -cos * graphs[a].sInitialScale.y,
                                                           graphs[a].sInitialScale.z);
            // t
            cos = Mathf.Cos(((angle + graphOffset.t - graphs[a].readOffset) * Mathf.PI) / 180.0F);
            graphs[a].t.localScale = new Vector3(graphs[a].tInitialScale.x,
                                                           cos * graphs[a].tInitialScale.y,
                                                           graphs[a].tInitialScale.z);
        }
	}

    public void Slider(float _angle)
    {
        angle = _angle;
    }
}
