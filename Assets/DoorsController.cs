using System.Collections;
using UnityEngine;

public class DoorsController : MonoBehaviour
{
    public float interactDistance = 2f;
    private Animator animator;
    private GameObject player;
    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Button passed");
            float distance = Vector3.Distance(transform.position, player.transform.position);

            if (distance <= interactDistance)
            {
                if (!isOpen)
                {
                    OpenDoor();
                }
                else 
                {
                    CloseDoor();
                }
            }
        }
    }

    void OpenDoor()
    {
        isOpen = true;
        animator.SetBool("isOpen", true);
    }

    void CloseDoor()
    {
        isOpen = false;
        animator.SetBool("isOpen", false);
    }
}
