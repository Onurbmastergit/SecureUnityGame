using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SpawnSelection : MonoBehaviour
{
    public static SpawnSelection instacia;

    void Awake()
    {
        instacia = this;
    }
   public static int spawn;
   public bool enableRandom;
   public string spawnDirecao;
   public List<GameObject> spawns;
    void Update()
    {
        if(LevelManager.instance.currentHour == 20)
        {
            RandomizarNumero();
        }
        if(LevelManager.instance.currentHour == 6)
        {
            spawnDirecao = null;
            enableRandom = true;
            for(int i = 0; i < spawns.Count; i++)
            {
                spawns[i].SetActive(false);
                spawns[i].GetComponent<SpawnSystem>().enableSpawn = false;
            }           
        }
    }
  void SelectionSpawn()
  {
    for(int i = 0; i < spawns.Count; i++)
    {    
        if(i == spawn )
        {
         spawns[i].SetActive(true);
         spawnDirecao = spawns[i].GetComponent<SpawnSystem>().direcaoSpawn;
         spawns[i].GetComponent<SpawnSystem>().enableSpawn = true;
        }
        else
        {    
        spawns[i].SetActive(false);
        spawns[i].GetComponent<SpawnSystem>().enableSpawn = false;                                                                                                                                                                     
        }
    }
    enableRandom = false;    

  }
  public void RandomizarNumero()
  {
    if(enableRandom == true)
    {
        spawn = Random.Range(0,4);
    }
    
    SelectionSpawn();
  }
}
