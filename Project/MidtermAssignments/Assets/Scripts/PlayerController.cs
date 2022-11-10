
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ��������
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizental = 4f;


        private void Update()
        {

            float v = Input.GetAxis("Vertical");


            float h = Input.GetAxis("Horizontal");

                
            transform.Translate(
                speedHorizental * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v, 
                0);
        }
        
    }

}

