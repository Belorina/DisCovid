using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler: MonoBehaviour
{
    [System.Serializable]
    public class Pooling
    {
        public string tag; 
        public GameObject prefab;
        public int size;
    }


    #region Singleton 
    public static ObjectPooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public List<Pooling> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;


    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        // adding to dict
        foreach (Pooling pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i ++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            // adding pool to dict
            poolDictionary.Add(pool.tag, objectPool);
        }

    }

    // spawning ( set active ) // return type = GameObject 
    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        // if we gave a tag and doesnt have a pool 
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag" + tag + " doesn't exist.");
            return null;
        }

        GameObject objectToSpawn =  poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        IPooledObject pooledObj = objectToSpawn.GetComponent<IPooledObject>();

        if (pooledObj != null)
        {
            pooledObj.OnObjectSpawn();
        }

        // add back to queue
        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }

}
