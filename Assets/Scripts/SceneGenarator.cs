 using UnityEngine;
 using System.Collections;

 public class SceneGenerator : MonoBehaviour
 {
     public GameObject[] maps;
     private int xPos = -50;
     private float zPos = 0.8f;
     public bool createScene = false;
     public int sceneNum;

     void Start()
     {
         StartCoroutine(SceneGen()); // Start generating immediately
     }

     void Update()
     {
         if (!createScene)
         {
             createScene = true;
             StartCoroutine(SceneGen());
         }
     }

     IEnumerator SceneGen()
     {
         sceneNum = Random.Range(0, maps.Length);

         // Instantiate first, then modify positions
         Instantiate(maps[sceneNum], new Vector3(xPos, 0, zPos), maps[sceneNum].transform.rotation);

         // Modify positions after instantiation
         xPos -= 50;
         zPos += 0.8f;

         yield return new WaitForSeconds(3);
         createScene = false;
     }
 }

