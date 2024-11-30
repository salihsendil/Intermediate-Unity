using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    private const int POOL_SIZE = 20;

    public static ObjectPoolingManager Instance { get; private set; }

    [SerializeField] private GameObject _ballPrefab;
    private Queue<GameObject> _ballPool;

    private float _delay = 5;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    void Start()
    {
        _ballPool = new Queue<GameObject>();

        for (int i = 0; i < POOL_SIZE; i++)
        {
            GameObject _ball = Instantiate(_ballPrefab, Vector3.zero, Quaternion.identity);
            _ball.SetActive(false);
            _ballPool.Enqueue(_ball);
        }
    }

    void Update()
    {
        Debug.Log("Current Ball Count In Queue: " + _ballPool.Count);
    }

    public GameObject GetBallFromPool()
    {
        if (_ballPool.Count > 0)
        {
            GameObject _createdBall = _ballPool.Dequeue();
            _createdBall.SetActive(true);
            StartCoroutine(BallDelayForGoBackToPool(_createdBall, _delay));
            return _createdBall;
        }
        return null;
    }

    private void ReturnBallToPool(GameObject ball)
    {
        _ballPool.Enqueue(ball);
        ball.SetActive(false);
    }

    private IEnumerator BallDelayForGoBackToPool(GameObject ball, float delay)
    {
        yield return new WaitForSeconds(delay);
        ReturnBallToPool(ball);
    }


}
