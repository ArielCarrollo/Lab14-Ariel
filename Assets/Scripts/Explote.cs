using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explote : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource _compAudioSource;
    private Animator _compAnimator;
    public float Speed = 3;
    public int DirectionX = 0;
    public float DirectionY = -1;
    private Rigidbody2D _compRigidBody2D;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            _compAnimator.SetBool("Explota?", true);
        }
    }
    private void Destroy()
    {
        Destroy(this.gameObject);
    }
    private void Bum()
    {
        _compAudioSource.Play();
    }
    void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(DirectionX * Speed, DirectionY * Speed);
    }
    // Update is called once per frame
}
