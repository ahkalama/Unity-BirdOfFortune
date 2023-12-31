using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class Bomb : MonoBehaviour
{   
    public GameObject exploide;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "amedkaya") // etiketi tagı amedkayaysa laklak'ı çalıştıracak, collision olduğunda rigidbody vermen gerekiyor.
        {
            laklak();
        }
    }
    private void laklak()
    {
        Instantiate(exploide, this.gameObject.transform.position, Quaternion.identity);
        anim.SetTrigger("Explosion");
        StartCoroutine(WaitAndPrint());
    }
    private IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(0.5f); // 0.5f bekletip 2. sahneyi yüklemesi için
        SceneManager.LoadScene(2);
    }

}
