using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{

    public GameObject childOfCube;
    private Vector3 startPos;
    static int movement = 0;

    public GameObject enemyObject;
    private Vector3 enemyDir;

    public float playerDotEnemyDir;
    void Start()
    {
        startPos = transform.position;
        childOfCube.transform.position = startPos + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            movement++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            movement--;
        }

        transform.position = startPos + new Vector3(0, 0, movement);

        enemyDir = (enemyObject.transform.position - transform.position).normalized;

        playerDotEnemyDir = Vector3.Dot(transform.forward, enemyDir);
    }
}
