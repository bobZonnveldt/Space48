using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] public float cooldownTime = 3f;
    private float cooldownCounter = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Shot();
    }
    void Shot() { 
        cooldownCounter += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) && cooldownCounter > cooldownTime)
        {
            GameObject laser = Instantiate(laserPrefab);
            laser.transform.position = transform.position;
            laser.transform.rotation = transform.rotation;
            Destroy(laser, 3f);

            cooldownCounter = 0f;

        }

        
    }
}
