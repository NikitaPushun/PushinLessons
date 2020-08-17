using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameObject[] _enemies;
    [SerializeField] private Transform[] _positinsSpawnPlace;
    [SerializeField] private float _spawnDelay = 4.0f;
    [SerializeField] private float _currentTime = 4.0f;
    [SerializeField] private UnityEvent _onSpawned;

    private GameObject _currentEnemy;

    #endregion Fields

    #region UnityMethods

    public void Start()
    {
        if (_onSpawned == null)
        {
            _onSpawned = new UnityEvent();
        }
        
        _currentTime = _spawnDelay;
    }

    private void Update()
    {
        if (_currentEnemy == null)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime <= 0)
            {
                _currentTime = _spawnDelay;
                Spawn();
            }
        }
    }

    #endregion UnityMethods

    #region Methods

    private void Spawn()
    {
        var EnemyNumber = Random.Range(0, _enemies.Length);
        var SpawnerNumbers = Random.Range(0, _positinsSpawnPlace.Length);

        var enemy = _enemies[EnemyNumber];
        var spawner = _positinsSpawnPlace[SpawnerNumbers];

        _currentEnemy = Instantiate(enemy, spawner.position, spawner.rotation);

        _onSpawned.Invoke();
    }

    #endregion Methods
}
