using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xyzDravner : MonoBehaviour
{
    [SerializeField] bool scrypt_enable = true;
    [SerializeField] float x_axis_lenght = 1f;
    [SerializeField] float y_axis_lenght = 1f;
    [SerializeField] float z_axis_lenght = 1f;

    [SerializeField] bool LineEnd_simbol = true;



    void OnDrawGizmos()
    {

        if (scrypt_enable == true)
        {


            Vector3 Center_point = transform.position;  //Az obijektum poziciója amin a scrypt él majd.

            //X
            Vector3 right = x_axis_lenght * transform.right;
            Gizmos.color = Color.red;
            Gizmos.DrawLine(Center_point - right, Center_point + right);
            //Y
            Vector3 up = y_axis_lenght * transform.up;
            Gizmos.color = Color.green;
            Gizmos.DrawLine(Center_point - up, Center_point + up);
            //Z
            Vector3 Forward = z_axis_lenght * transform.forward;
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(Center_point - Forward, Center_point + Forward);

            if (LineEnd_simbol == true)
            {

                Vector3 cube = new Vector3(0.3f, 0.3f, 0.3f); //kocka mérete

                Gizmos.color = Color.red;
                Gizmos.DrawCube(Center_point + right, cube * x_axis_lenght);

                Gizmos.color = Color.green;
                Gizmos.DrawCube(Center_point + up, cube * y_axis_lenght);

                Gizmos.color = Color.blue;
                Gizmos.DrawCube(Center_point + Forward, cube * z_axis_lenght);

            }

        }


    }





}
