using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : BaseSpawner
{
    public virtual Transform Spawn(string prefabName, Vector3 spawnPos, Quaternion rotation)
    {
        Transform prefab = this.GetPrefabByName(prefabName);
        if (prefab == null)
        {
            Debug.LogWarning("Prefab not found:" + prefabName);
            return null;
        }

        return this.Spawn(prefab, spawnPos, rotation);
    }
    public virtual Transform Spawn(Transform prefab, Vector3 spawnPos, Quaternion rotation)
    {
        Transform newPrefab = this.GetObjectFromPoll(prefab);
        newPrefab.SetPositionAndRotation(spawnPos, rotation);

        newPrefab.parent = this.holder;
        //this.spawnedCount++;
        return newPrefab;
    }
    protected virtual Transform GetObjectFromPoll(Transform prefab)
    {
        for (int i = this.poolObjs.Count - 1; i >= 0; i--)
        {
            Transform poolObj = this.poolObjs[i];
            if (poolObj.name == prefab.name)
            {
                this.poolObjs.RemoveAt(i);
                return poolObj;
            }
        }

        Transform newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;
    }
    public virtual void Despawn(Transform obj)
    {
        this.poolObjs.Add(obj);
        obj.gameObject.SetActive(false);
        //this.spawnedCount--;
    }
    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach (Transform prefab in this.prefabs)
        {
            if (prefab.name == prefabName) return prefab;
        }

        return null;
    }
    public virtual Transform RandomPrefab()
    {
        int rand = Random.Range(0, this.prefabs.Count);
        return this.prefabs[rand];
    }
}
