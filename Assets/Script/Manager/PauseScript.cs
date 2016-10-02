using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{
	void Start ()
    {
        this.GetComponent<Canvas>().enabled = false;
	}
	void Update ()
    {
	    if(Input.GetKey(KeyCode.Escape))
        {
            this.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }
	}
    public void OnVoltarAoJogoClick()
    {
        this.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void OnVoltarAoMenuClick()
    {
        Application.LoadLevel("Menu");
    }
}
