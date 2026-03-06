using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticleInput;
    public float speed = 15.0f;
    public float range = 20.0f;

    public GameObject food;
    public GameObject superattack;

    void Start()
    {
        
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticleInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticleInput * Time.deltaTime * speed);
            
        if (transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnFood();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            {
                SpawnSuper();
            }
        }
    }

    void SpawnFood()
    {
        Instantiate(food, transform.position, food.transform.rotation);
    }
    void SpawnSuper()
    {
        Instantiate(superattack, transform.position, superattack.transform.rotation);
    }
}