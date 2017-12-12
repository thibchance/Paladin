using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private int vie = 3;
    private int mana = 3;
    [SerializeField]
    private Text textvieplayer;
    [SerializeField]
    private Text textmanaplayer;

    private const string TEXT_VIE = "Vie = ";
    private const string TEXT_MANA = "Mana = ";
    // Use this for initialization
    void Start ()
    {
        textvieplayer.text = TEXT_VIE + vie;
        textmanaplayer.text = TEXT_MANA + mana;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void PlayerDie()
    {
        vie--;

        if (vie <= 0)
        {
            SceneManager.LoadScene("Gameover");

            //SceneManager.LoadScene("StartMenu");
        }
        else
        {
            textvieplayer.text = TEXT_VIE + vie;
        }

    }
}
