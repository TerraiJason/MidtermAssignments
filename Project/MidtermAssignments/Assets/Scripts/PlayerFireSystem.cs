
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ���a�o�g
    /// </summary>
public class PlayerFireSystem : FireSystemBase
{
        //�������a����J�欰:��L�B�ƹ��B�n��BĲ��
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }

        }
 
}

}

