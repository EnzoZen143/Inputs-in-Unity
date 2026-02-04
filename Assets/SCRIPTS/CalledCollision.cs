using UnityEngine;

public class CalledCollision : MonoBehaviour
{
    //collision properties
    [SerializeField] private Material obstacleMaterial;
    [SerializeField] private Color matColor;
    #region OnCollision Function
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collided");
        //Debug.Log("collision.gameObject.name");
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            obstacleMaterial = rend.material;
            matColor = obstacleMaterial.color;

            obstacleMaterial.color = Color.white;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Cube stay colliding");
/*        if (collision.gameObject.CompareTag("Obstacle"))
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);*/
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Cube Falls");
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            rend.material.color = matColor;
        }
    }
    #endregion

    #region OnTrigger Function
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Colliding on trigger obj");
        ObstacleContain obstacle = other.GetComponent<ObstacleContain>();
        GameObject newGameObject = obstacle.obstacle;
        contain.obstacleRenderer.material.color = newGameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay on trigger obj");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit on trigger obj");
    }

    #endregion
}