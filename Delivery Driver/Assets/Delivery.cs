using UnityEngine;

public class Delivery : MonoBehaviour {

    string packageTag = "Package";
    string customerTag = "Customer";
    bool hasPackage;
    Color32 noPackageColor = new Color32(255, 255, 255, 255);
    Color32 hasPackageColor = new Color32(127, 69, 212, 255);

    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == packageTag && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject);
        }
        
        if (other.tag == customerTag && hasPackage){
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
