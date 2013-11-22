using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
    bool flagMove;
    RaycastHit hit;
    void Awake()
    {
        GlobalData.camera = gameObject;
        //initScene();
		initConnect();
    }

    private void initScene()
    {
        ModuleFactory.createModules();
        //initView();
       
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void initView()
    {
        GameObject newAnchorObject = new GameObject("Anchor");
        GameObject uiroot = GameObject.Find("UI Root (2D)");
        newAnchorObject.transform.parent = uiroot.transform;
        newAnchorObject.transform.localScale = Vector3.one;
        UIAnchor anchor = newAnchorObject.AddComponent<UIAnchor>();
        anchor.side = UIAnchor.Side.Center;
        NGUIUtility.rootParent = newAnchorObject.transform;
    }

    private void initConnect()
    {
        Connection2.getInstance().handlerSuccess = onConnectedServerSucc;
        Connection2.getInstance().startConnect(true);
    }
	
	private void onConnectedServerSucc(params object[] arg){
		Debug.Log("onConnectedServerSucc");
        m_auth_key_tos vo = new m_auth_key_tos();
        vo.account_name = GameParameters.getInstance().account;
		vo.key = GameParameters.getInstance().key;
		vo.time = GameParameters.getInstance().tstamp;
		vo.fcm = int.Parse(GameParameters.getInstance().fcm);
		vo.server_id=int.Parse(GameParameters.getInstance().serverID);
		vo.agent_id=int.Parse(GameParameters.getInstance().agentID);
        vo.extra_params = GameParameters.getInstance().extraParams;
        Connection2.getInstance().send(vo);
        //Connection2.getInstance().Send(Connection2.getInstance().stateObj.workSocket, "2,*," + "123" + "," + "进来了");
	}
}
