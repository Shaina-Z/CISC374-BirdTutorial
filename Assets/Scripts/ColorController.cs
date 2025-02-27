using UnityEngine;

public class ColorController : MonoBehaviour
{
    private SpriteRenderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     rend=GetComponent<SpriteRenderer>();
     rend.color=new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
