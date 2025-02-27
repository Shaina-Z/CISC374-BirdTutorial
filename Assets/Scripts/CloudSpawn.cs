using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject CloudPrefab;
    
    private float timer = 0;
    public float spawnTime=2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Instantiate(CloudPrefab,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
         if(timer<spawnTime){
            timer+=Time.deltaTime;
        }else{
            timer =0.0f;
            Instantiate(CloudPrefab,transform.position,transform.rotation);
        }
    }
}
