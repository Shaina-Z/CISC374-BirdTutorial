using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject PipePrefab;
    
    private float timer = 0;
    public float spawnTime=2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(PipePrefab,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnTime){
            timer+=Time.deltaTime;
        }else{
            timer =0.0f;
            Instantiate(PipePrefab,transform.position,transform.rotation);
        }
        
    }
}
