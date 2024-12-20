using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{

private Transform _transform;

public float velocidade = 10f;


    void Start()
    {
        _transform = gameObject.transform;
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position += new Vector3(velocidade*Time.deltaTime,0,0);

            Debug.Log("LeftArrow");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow");
        }
    }
}
