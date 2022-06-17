using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float posX;
    private float posY;
    private float posZ;
    private float scale;

    private float rotX;
    private float rotY;
    private float rotZ;

    private float rgba_r;
    private float rgba_g;
    private float rgba_b;
    private float rgba_a;



    void Start()
    {
        posX = Random.Range(-10f, 10f);
        posY = Random.Range(-10f, 10f);
        posZ = Random.Range(-10f, 10f);
        scale = Random.Range(1f, 10f);

        rotX = Random.Range(1f, 20f);
        rotY = Random.Range(1f, 20f);
        rotZ = Random.Range(1f, 20f);

        


        transform.position = new Vector3(posX, posY, posZ);
        transform.localScale = Vector3.one * scale;

        InvokeRepeating("ColorChange", 0.2f, 0.2f);
    }
    
    void Update()
    {
        

        transform.Rotate(rotX * Time.deltaTime, rotY * Time.deltaTime, rotZ * Time.deltaTime);
    }

    private void ColorChange()
    {
        rgba_r = Random.Range(0f, 1f);
        rgba_g = Random.Range(0f, 1f);
        rgba_b = Random.Range(0f, 1f);
        
        if (Input.GetKey(KeyCode.X))
        {
            rgba_a = 0f;
            Debug.Log("x basılıyor");
        }
        else
        {
            rgba_a = Random.Range(0f, 1f);
        }

        Material material = Renderer.material;

        material.color = new Color(rgba_r, rgba_g, rgba_b, rgba_a);
    }
}
