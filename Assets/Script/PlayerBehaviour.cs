using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public bool holdingKey;
    public bool wearingCopClothes = false;
    public RuntimeAnimatorController animController;
    float movementHorizontal;
    float movementVertical;
    Vector3 mousePosition;
    Vector3 lookPosition;
    Quaternion rotation;
	void Update()
    {
        ///Fazer o personagem rotacionar e mudar sua visão
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 270f);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (movementHorizontal != 0 || movementVertical != 0)
        {
            this.GetComponent<Animator>().SetBool("IsWalking", true);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("IsWalking", false);
        }
    }
	void FixedUpdate ()
    {
        //Movimenta o personagem nas 8 direcões
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(movementHorizontal * speed, movementVertical * speed); 
    }
    public void copClothes()
    {
        this.GetComponent<Animator>().runtimeAnimatorController = animController;
        wearingCopClothes = true;
    }
}
