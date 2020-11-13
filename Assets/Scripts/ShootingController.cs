using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ShootingController : MonoBehaviour
{
    public Transform skillShotPoint;
    public GameObject skillShotPrefab;

    public void Shoot(Vector2 skillShotDestination)
    {

        Vector3 shootDir = ((Vector3)skillShotDestination - transform.position).normalized;
        //Debug.DrawRay(playerScript.skillShotPointScript.transform.position, shootDir * 5f, Color.red);
        float angle = Mathf.Atan2(shootDir.y, shootDir.x) * Mathf.Rad2Deg;
        skillShotPoint.eulerAngles = new Vector3(0, 0, angle);

        GameObject mySkillShot = Instantiate(skillShotPrefab, skillShotPoint.position, skillShotPoint.rotation);
        Physics2D.IgnoreCollision(mySkillShot.GetComponent<BoxCollider2D>(), GetComponent<CapsuleCollider2D>());
        mySkillShot.GetComponent<SkillShot>().Setup(shootDir);
    }
}
