using UnityEngine;

public class Addition : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;

    static Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position = startPos + cube1.transform.position + cube2.transform.position;
    }
}
