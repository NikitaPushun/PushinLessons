using UnityEngine;


public class EnemyTurell : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private Transform _target;
    [SerializeField] private AudioSource _shootSound;
    [SerializeField] private float _bulletTime = 1.0f;
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _maxDistance;

    private Vector3 _positionPlayer;
    private Vector3 _positionTurell;
    private float _distance;
    private float _timer = 0f;

    # endregion

    #region UnityMethods

    private void Start()
    {
        _positionTurell = gameObject.transform.position;        
    }

    private void Update()
    {

        _positionPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
        _distance = (_positionPlayer - _positionTurell).magnitude;
        
        if (_distance < _maxDistance)
        {
            Vector3 direction = (_target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3 (direction.x, 0, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, _speed * Time.deltaTime);

            ShootingProces();

            //Vector3 direction = _target.transform.position - transform.position;
            //Quaternion rotation = Quaternion.LookRotation(direction);
            //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, _speed * Time.deltaTime);

            //transform.LookAt(_target);
        }
    }

    #endregion

    #region Methods

    private void ShootingProces()
    {
        _timer += Time.deltaTime;
        if (_timer > _bulletTime)
        {
            _timer = 0f;
            Shoot();
        }
    }


    private void Shoot()
    {        
        Instantiate(_bullet, _spawnPointBullet.position, _spawnPointBullet.rotation);
        _shootSound.Play();
    }

    #endregion
}
