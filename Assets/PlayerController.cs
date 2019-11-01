using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Text countText;
    [SerializeField] private float speed = 5.0f; // speed in meters per second
    private float time = 1.0f;
    private static int score = 0;
    private bool left = false;
    private bool right = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        LevelManager.Initialize();
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
        }
        else
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

        // Exiting the Application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
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
            score += 1;
            Debug.Log(score);
            SetCountText();
        }
        if(collision.gameObject.tag == "End")
        {
            Debug.Log("I am inside the portal");
            speed += 1;
            LevelManager.Instance.loadLevel();
        }
    }

    public void SetCountText()
    {
        countText.text = score.ToString();
    }

}