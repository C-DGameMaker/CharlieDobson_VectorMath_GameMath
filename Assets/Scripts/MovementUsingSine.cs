using UnityEngine;

public class MovementUsingSine : MonoBehaviour
{
    public float speed = 2f; 
    public float amplitude = 3f;
    private float offset;

    public int choose;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        offset = Mathf.Sin((Time.time * speed) * 2) * amplitude;

        if(choose == 1)
        {
            transform.position = startPosition + new Vector3(offset, 0, 0); 
        }
        else if(choose == 2)
        {
            transform.position = startPosition + new Vector3(0, offset, 0); 
        }
        else
        {
            transform.position = startPosition + new Vector3(0, 0, offset); 
        }

        
    }
}
