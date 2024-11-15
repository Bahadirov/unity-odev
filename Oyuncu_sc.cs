// Suhrab BAHADIROV Odev-1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu_sc : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0, 2, 0); // Küpün başlangıç konumunu değiştirin
    }

    public float speed = 5.0f;

    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime);
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
