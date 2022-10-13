using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] float amplitude = 5f;
    [Range(0f, 10f)]
    [SerializeField] float frequency = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localPos;
        //deltaPos.x = 0f;
        //deltaPos.x = PerlinNoise1D(Time.time * frequency) * amplitude;
        //deltaPos.x = PerlinNoise1D(-Time.time * frequency) * amplitude;

        //deltaPos.x = PerlinNosie2D((Time.time * frequency, 1.0f) * amplitude;

        //localPos.z = -2f;


        //deltaPos.y = Mathf.Sin(Time.time * frequency) / amplitude;                          //-1.0 .. 1.0
        //deltaPos.y = Mathf.PerlinNoise(Time.time * frequency, 0.0f)                        // amplitude; //0.0 .. 1.0
        //deltaPos.y = (Mathf.PerlinNoise(Time.time, 0.0f) * 2.0f) -1.0f;                   // 0.0 ... 1.0 -> -1.0 .. 1.0
        //deltaPos.y = ((Mathf.PerlinNoise(Time.time * frequency, 0.0f) * 2.0f) - 1.0f) * amplitude;

        localPos.x = PerlinNoise2D(Time.time * frequency, 1.0f) * amplitude;
        localPos.y = PerlinNoise2D(Time.time * frequency, 0.0f) * amplitude;
        localPos.z = PerlinNoise2D(Time.time * frequency, 2.0f) * amplitude;

       // gameObject.transform.localPosition = localPos;
        gameObject.transform.localEulerAngles = localPos;
    }

    float PerlinNoise1D(float x)
    {
        float y = 0.0f;
        return((Mathf.PerlinNoise(x, y) * 2.0f) - 1.0f);
    }

    float PerlinNoise2D(float x, float y)
    {
        return ((Mathf.PerlinNoise(x, y) * 2.0f) - 1.0f);
    }
}
