using UnityEngine;
using System.Collections;

public class ManagerScript : MonoBehaviour
{
	void Update ()
    {
	    if(Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel("MainScene");
        }
	}
}
