using UnityEngine;

public class GerakPindah : MonoBehaviour
{
    float speed = 3f;
    public Sprite[] sprites;

    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;

    void Start()
    {
        // Set random object to spawn
        int index = Random.Range(0, sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        // Move object
        float move = (speed * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector3(move, transform.position.y);
    }

    // If object is clicked
    void OnMouseDown()
    {
        firstY = transform.position.y;
        screenPoint =
        Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
        Input.mousePosition.y, screenPoint.z));
    }

    // If object is held and drag
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
        screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    // If object is released
    private void OnMouseUp()
    {
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
    }
}