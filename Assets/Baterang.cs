using UnityEngine;



public class Baterang : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] int speed;
    [SerializeField] GameObject self;

    bool forwards = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 50; i++)  {
            rigidbody.AddForce(transform.forward * speed*2);
        }
        forwards = false;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(transform.forward * speed * -1);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!forwards)
        {
            Object.Destroy(this.gameObject);
        }
    }
}
