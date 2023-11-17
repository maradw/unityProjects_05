using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRend;
    public float speed;
    public int directionX;
    public int directionY;

    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRend = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed * directionX * Time.deltaTime, _compTransform.position.y + speed * directionY * Time.deltaTime);
        if (_compTransform.position.x > 5.96f)
        {
            directionX = -1;
            _compSpriteRend.flipX = true;
        }
        if (_compTransform.position.x < -5.96f)
        {
            directionX = 1;
            _compSpriteRend.flipX = false;
        }
        if (_compTransform.position.y> 3.51f)
        {
            directionY = -1;
            _compSpriteRend.flipY = true;
        }
        if (_compTransform.position.y < -3.51f)
        {
            directionY = 1;
            _compSpriteRend.flipY = false;
        }
    }
}
