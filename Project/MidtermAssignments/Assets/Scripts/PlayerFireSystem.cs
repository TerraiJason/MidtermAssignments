
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ª±®aµo®g
    /// </summary>
public class PlayerFireSystem : FireSystemBase
{
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }

        }
 
}

}

