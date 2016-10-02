using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{
	public void ChangeScene(int i)
	{
		Application.LoadLevel (i);
	}
}
