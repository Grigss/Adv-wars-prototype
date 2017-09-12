using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 pos1, pos2;
    public float speed = 2.0f;
    Turn turn;
    public GameObject player1, player2;

    void Start()
    {
        pos1 = player1.transform.position;
        pos2 = player2.transform.position;
        turn = Turn.Player1;
    }

    void FixedUpdate()
    {
        if(turn == Turn.Player1)
        {
            if (Input.GetKey(KeyCode.A) && player1.transform.position == pos1)
            {        // Left
                pos1 += Vector3.left;
            }
            if (Input.GetKey(KeyCode.D) && player1.transform.position == pos1)
            {        // Right
                pos1 += Vector3.right;
            }
            if (Input.GetKey(KeyCode.W) && player1.transform.position == pos1)
            {        // Up
                pos1 += Vector3.up;
            }
            if (Input.GetKey(KeyCode.S) && player1.transform.position == pos1)
            {        // Down
                pos1 += Vector3.down;
            }
            player1.transform.position = Vector3.MoveTowards(player1.transform.position, pos1, Time.deltaTime * speed);    // Move there
            turn = Turn.Player2;
        }

        else
        {
            if (Input.GetKey(KeyCode.LeftArrow) && player2.transform.position == pos2)
            {        // Left
                pos2 += Vector3.left;
            }
            if (Input.GetKey(KeyCode.RightArrow) && player2.transform.position == pos2)
            {        // Right
                pos2 += Vector3.right;
            }
            if (Input.GetKey(KeyCode.UpArrow) && player2.transform.position == pos2)
            {        // Up
                pos2 += Vector3.up;
            }
            if (Input.GetKey(KeyCode.DownArrow) && player2.transform.position == pos2)
            {        // Down
                pos2 += Vector3.down;
            }
            player2.transform.position = Vector3.MoveTowards(player2.transform.position, pos2, Time.deltaTime * speed);    // Move there
            turn = Turn.Player1;
        }
    }
}

public enum Turn { Player1, Player2 };