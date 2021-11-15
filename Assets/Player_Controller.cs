using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy")
        {
            LiveManager.lives_count -= 1;
        }
    }
}
