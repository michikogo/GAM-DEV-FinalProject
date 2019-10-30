using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumballController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f; // speed in meters per second
    [SerializeField] private Transform portalTransform; // portal to get the gameobject
    private float smooth = 5.0f;
    private int score = 0;
    private bool left = false;
    private bool right = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.right = true;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            this.right = false;
        }
        if (this.right)
        {
            Vector3 pos2 = this.transform.localPosition;
            pos2.x += (Time.deltaTime * this.speed);
            this.transform.localPosition = pos2;
            // Debug.Log("Right");
        }

        // Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.left = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            this.left = false;
        }   
        if (this.left)
        {
            Vector3 pos3 = this.transform.localPosition;
            pos3.x -= (Time.deltaTime * this.speed);
            this.transform.localPosition = pos3;
            // Debug.Log("Left");
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            Debug.Log("Xollision Detexted");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Safe")
        {
            score += 5;
            Debug.Log(score);
        }
    }
}
