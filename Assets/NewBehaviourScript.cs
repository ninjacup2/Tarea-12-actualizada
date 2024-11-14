using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private float horizontal;
    private float vertical;
    public float speedX;
    public float speedY;
    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position = new Vector2(transform.position.x + horizontal * speedX * Time.deltaTime, transform.position.y + vertical * speedY * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        //_componentRigidbody2D.velocity = new Vector2(horizontal * speedX, vertical * speedY);
    }
}