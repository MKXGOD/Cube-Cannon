using UnityEngine;

public class CubeCannon : MonoBehaviour
{
    public CubeAmmo _cubeAmmPrefab;
    private float _speed = 2;
    private float _distance = 5;

    private float _rate = 2;
    private float _canSpawn = 0;

    private void Update()
    {
        if (Time.time > _canSpawn)
        {
            _canSpawn = Time.time + _rate;

            CubeAmmo cube = Instantiate(_cubeAmmPrefab);
            cube.Init(transform, _speed, _distance);
            cube.transform.position = gameObject.transform.position;
        }
    }
    public void SetRate(int value)
    {
        _rate = value;
    }
    public void SetSpeed(int value)
    {
        _speed = value;
    }
    public void SetDistance(int value)
    {
        _distance = value;
    }
}
