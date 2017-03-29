using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ringo
{
    public class PlayerBehaviour : MonoBehaviour
    {

        Rigidbody2D body;

        // Use this for initialization
        void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            body.velocity = new Vector2(h, v);
        }
    }
}