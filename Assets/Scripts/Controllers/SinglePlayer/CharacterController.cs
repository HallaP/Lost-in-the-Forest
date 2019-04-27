using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed;
    public float runSpeed;

    public KeyCode runKey = KeyCode.LeftShift;

    private bool isRunning = false;

    void Update()
    {
        if (Input.GetKeyDown(runKey))
        {
            isRunning = true;
        }

        if (Input.GetKeyUp(runKey))
        {
            isRunning = false;
        }


        //Movement Input
        MovePlayer();
    }


    private void MovePlayer()
    {
        var inputHorizontal = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        var inputVertical = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        if (isRunning)
        {
            inputHorizontal = Input.GetAxisRaw("Horizontal") * runSpeed * Time.deltaTime;
            inputVertical = Input.GetAxisRaw("Vertical") * runSpeed * Time.deltaTime;
        }


        transform.Translate(new Vector3(inputHorizontal, 0, 0));
        transform.Translate(new Vector3(0, inputVertical, 0));
    }
}
