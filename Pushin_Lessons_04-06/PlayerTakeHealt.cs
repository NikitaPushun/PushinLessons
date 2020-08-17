using UnityEngine;

public class PlayerTakeHealt : MonoBehaviour
{
    [SerializeField] private int _health;
    
   
    #region

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {       
            var player = collision.gameObject.GetComponent<TakeHealthBonus>();
            player.Health(_health);           
            Destroy(gameObject);
        }
    }

    #endregion
}