using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int num = 0;
    private Renderer rend;
    private float alpha = 0f;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Ensure the alpha is greater than 0 before reducing it
        if (rend.material.color.a > 0)
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alpha);
        }

        //これはテストです。

        // Check for input based on num value
        switch (num)
        {
            case 1:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    ColorChange();
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.F))
                {
                    ColorChange();
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.J))
                {
                    ColorChange();
                }
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.K))
                {
                    ColorChange();
                }
                break;
        }

        // Reduce alpha over time
        alpha -= speed * Time.deltaTime;
        alpha = Mathf.Clamp(alpha, 0f, 1f); // Clamps alpha between 0 and 1
    }

    void ColorChange()
    {
        alpha = 0.3f; // Set alpha to 0.3 when a key is pressed
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alpha);
    }
}
