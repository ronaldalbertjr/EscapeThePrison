using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{
	private bool soundPaused;
	[SerializeField] private AudioSource[] audio;

	void Start ()
    {
        this.GetComponent<Canvas>().enabled = false;
	}

	void Update ()
    {
	    if(Input.GetKey(KeyCode.Escape))
        {
            this.GetComponent<Canvas>().enabled = true;
        }
	}

    public void OnVoltarAoJogoClick()
    {
        this.GetComponent<Canvas>().enabled = false;
    }

    public void OnVoltarAoMenuClick()
    {
        Application.LoadLevel("Menu");
    }

	public void MuteButton()
	{
        foreach (AudioSource i in audio)
        {
            if (i.mute)
            {
                i.mute = false;
            }
            else if (!i.mute)
            {
                i.mute = true;
            }
        }
    }
}
