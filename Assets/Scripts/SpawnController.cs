using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject PipePrefab;
    
    private float timer = 0;
    public float spawnTime=2;
    public float heightOffset =10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(PipePrefab,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        float lowestPoint =transform.position.y - heightOffset;
        float highestPoint =transform.position.y + heightOffset;
        if(timer<spawnTime){
            timer+=Time.deltaTime;
        }else{
            timer =0.0f;
            Instantiate(PipePrefab,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),
            0),transform.rotation);
        }
        
    }
}
