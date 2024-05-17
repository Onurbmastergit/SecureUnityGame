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
   public bool enableRandom ;
   public List<GameObject> spawns;
   public GameObject spawnGeral;


    void Update()
    {
        if(LevelManager.instance.nightStart)
        {
            RandomizarNumero();
            spawnGeral.SetActive(true);
        }
        if(LevelManager.instance.dayStart)
        {
            enableRandom = true;
            spawnGeral.SetActive(false);
        }
    }
  void SelectionSpawn()
  {
    for(int i = 0; i < spawns.Count; i++)
    {    
        if(i == spawn )
        {
         spawns[i].SetActive(true);
        }
        else
        {
            spawns[i].SetActive(false);                                                                                                                                                                     
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
