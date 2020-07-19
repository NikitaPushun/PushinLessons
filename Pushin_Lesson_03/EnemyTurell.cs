using UnityEngine;


public class EnemyTurell : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private Transform _target;
    [SerializeField] private AudioSource _shootSound;
    [SerializeField] private float _bulletTime = 1.0f;
    
    private Vector3 _positionPlayer;
    private Vector3 _positionEnemy;
    private float _distance;

    float timer = 0f;


    void Update()
    {
        _positionEnemy = gameObject.transform.position;
        _positionPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;

        _distance = Mathf.Sqrt((_positionPlayer - _positionEnemy).sqrMagnitude);
        
        if (_distance < 10)
        {
            transform.LookAt(_target);
            ShootingProces();            
        }
    }

    
    private void ShootingProces()
    {
        timer += Time.deltaTime;
        if (timer > _bulletTime)
        {
            timer = 0f;
            Shoot();
        }
    }


    private void Shoot()
    {        
        Instantiate(_bullet, _spawnPointBullet.position, _spawnPointBullet.rotation);
        _shootSound.Play();
    }
}
