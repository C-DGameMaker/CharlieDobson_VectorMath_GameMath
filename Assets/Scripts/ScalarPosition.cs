using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
  

    public float step;
    static float scalar = 1f;

    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            scalar += step;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            scalar -= step;
        }

        transform.position = startPos * scalar;
    }
}
