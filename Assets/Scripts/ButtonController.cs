using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void btnClick()
    {
        SceneManager.LoadScene("GameLevel");

    }
    public void btnExit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
