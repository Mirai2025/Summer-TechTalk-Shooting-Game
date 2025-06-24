using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 0.1f;
    [SerializeField]     private AudioClip _shootSound;
    public GameObject bulletPrefab;
   
    void Update()
    {
        UpdateMove();
;    }

    private void UpdateMove()
    {
        if(Input.GetKey(KeyCode.A))

        {
            transform.position +=-Vector3.right * _speed;

        }

        if(Input.GetKey(KeyCode.D))

        {
            transform.position += Vector3.right * _speed;

        }

        if(Input.GetKey(KeyCode.W))

        {
           
            transform.position += Vector3.up * _speed;

        }

        if(Input.GetKey(KeyCode.S))

        {
           
            transform.position +=-Vector3.up * _speed;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {  

            Instantiate (bulletPrefab,transform.position, Quaternion.identity);
             
        }

    }
}
