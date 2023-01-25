using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapstrength;
    public GameObject Ghost;
    public GameObject Score;
    public GameObject YouLose;

    public float XOffset;
    public float YOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.velocity = Vector2.up * flapstrength;
        }

        if(transform.position.y < -10)
        {
           Instantiate(YouLose, new Vector3(0,0,-1),Quaternion.identity);
            Time.timeScale = 0.01f;
            
        }

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene");
        }

    }
}
