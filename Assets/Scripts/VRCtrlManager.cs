using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;
public class VRCtrlManager : MonoBehaviour
{
    ROSConnection ros;
    public string topicName = "crawler_ctrl";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<Int8Msg>(topicName);
        
    }

    public void DisconnectVR()
    {
        Int8Msg int8Message = new Int8Msg(0);
        ros.Publish(topicName, int8Message);
        Debug.Log($"Published: {0}");

       int8Message = new Int8Msg(10);
       ros.Publish(topicName, int8Message);
       Debug.Log($"Published: {1}");

        int8Message = new Int8Msg(50);
        ros.Publish(topicName, int8Message);
        Debug.Log("Disconnect a VR Contoroller");
    }

    public void ConnectVR()
    {
        Int8Msg int8Message = new Int8Msg(51);
        ros.Publish(topicName, int8Message);
        Debug.Log("Connect a VR Contoroller");       
    }

    public void Shutdown()
    {
        Int8Msg int8Message = new Int8Msg(0);
        ros.Publish(topicName, int8Message);
        Debug.Log($"Published: {0}");

       int8Message = new Int8Msg(10);
       ros.Publish(topicName, int8Message);
       Debug.Log($"Published: {1}");

        int8Message = new Int8Msg(20);
        ros.Publish(topicName, int8Message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
