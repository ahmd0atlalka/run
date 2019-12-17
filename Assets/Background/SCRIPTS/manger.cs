using UnityEngine;
using System.Collections;

public class manger : MonoBehaviour
{
    Animator animator;
    public float movementSpeed = 100.0f;
    public bool Movement = true;
    public int Direction = 0;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Movement == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate((Vector2.up) * movementSpeed * Time.deltaTime);
                animator.SetInteger("States", 2);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate((-Vector2.right) * movementSpeed * Time.deltaTime);
                animator.SetInteger("States", 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate((-Vector2.up) * movementSpeed * Time.deltaTime);
                animator.SetInteger("States", 3);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate((Vector2.right) * movementSpeed * Time.deltaTime);
                animator.SetInteger("States", 1);
            }
            else
            {
                animator.SetInteger("States", 0);
            }
        }

    }
}