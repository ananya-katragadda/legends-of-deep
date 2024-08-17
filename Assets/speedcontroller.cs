using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedcontroller : MonoBehaviour
{
    public float Speed = 0.0f;
    private Animator _animator = null;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Speed", Speed);
    }
}
