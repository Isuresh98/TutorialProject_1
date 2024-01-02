using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
     public Color hitColor = Color.red; 
    private Renderer objectRenderer; 

    public ScenesManager scenesManager;
    public HealthSystem healthSystem;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
           objectRenderer = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Box"))
        {
          //  Debug.Log("Collision with object tagged as 'Box'");
            ChangeObjectColor(hitColor);


            healthSystem.TakeDamage(10);
        }
         if (collision.gameObject.CompareTag("Win"))
        {


            gameManager.GameWin();

       

        }

        
      


    }

      void ChangeObjectColor(Color newColor)
    {
  
        if (objectRenderer != null)
        {
  
            objectRenderer.material.color = newColor;
        }
    }




}
