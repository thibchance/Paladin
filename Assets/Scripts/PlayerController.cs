using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    [Header("Physics")]
    [SerializeField]
    float force = 10;

    private Rigidbody2D rigidbody;
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        float Horizontal_Input = Input.GetAxis("Horizontal");
        Vector2 forcedirection = new Vector2(Horizontal_Input, 0);
        forcedirection *= force;
        rigidbody.AddForce(forcedirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "touch")
        {

            SceneManager.LoadScene("WinMenu");
            
        }
    }

}
