using UnityEngine;

public class CubeAmmo : MonoBehaviour
{
    private Vector3 _spawnPosition;

    private float _speed;
    private float _distance;

    public void Init(Transform spawnPosition, float speed, float distance)
    {
        _spawnPosition = spawnPosition.position;
        _speed = speed;
        _distance = distance;
    }
    private void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, _speed * Time.deltaTime);
        DestroyCube();
    }
    private void DestroyCube()
    {
        float currentDistance = Vector3.Distance(_spawnPosition, transform.position);
        if (currentDistance >= _distance) 
           Destroy(gameObject);
    }
}
