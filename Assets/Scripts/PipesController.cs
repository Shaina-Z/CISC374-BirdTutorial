using UnityEngine;

public class PipesController : MonoBehaviour
{
    public int deadSpace = -45;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = transform.position + (Vector3.left*10)*Time.deltaTime;
        if(gameObject.transform.position.x<deadSpace){
            Destroy(gameObject);
        }
    }
    
}
