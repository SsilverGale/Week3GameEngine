using UnityEditor;
using UnityEngine;



public class Movement : MonoBehaviour
{

    [SerializeField] Rigidbody rigidbody;
    [SerializeField] int speed;
    [SerializeField] int jumpSpeed;
    [SerializeField] GameObject baterang;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidbody.AddForce(transform.forward * speed * -1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidbody.AddForce(transform.forward * speed * 1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody.AddForce(transform.up * jumpSpeed);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(baterang, new Vector3(rigidbody.position.x, rigidbody.position.y, rigidbody.position.z+1), Quaternion.identity);
        }
    }
    
    
}
