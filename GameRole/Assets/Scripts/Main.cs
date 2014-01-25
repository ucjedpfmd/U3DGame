using UnityEngine;
using System.Collections;
using proto;
using com.net;
using com.net.manager;
using com.globals;
using com.encrypt;

public class Main : MonoBehaviour
{
    bool flagMove;
    RaycastHit hit;
    void Awake()
    {
        GlobalData.initCamera(gameObject);        
        initScene();
		initConnect();
        ModuleFactory.createModules();
    }

    private void initScene()
    {
        SceneModule.getInstance().init();
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
        //EncryptCSharp.startEncrypt();
        Connection2.getInstance().handlerSuccess = onConnectedServerSucc;
        Connection2.getInstance().startConnect(true);
		ConnMgr.addSocketListener<m_auth_key_toc>(SocketCommand.AUTH_KEY, onAuthKey);
		ConnMgr.addSocketListener<m_role_detail_toc>(SocketCommand.ROLE_DETAIL, onRoleDetail);
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
        Connection2.getInstance().sendMessage(vo);
        //Connection2.getInstance().Send(Connection2.getInstance().stateObj.workSocket, "2,*," + "123" + "," + "进来了");
	}

    private void onAuthKey(m_auth_key_toc vo)
    {
		Debug.Log("onAuthKey");
        if (vo.succ)
        {
            m_role_detail_tos vo1 = new m_role_detail_tos();
            Connection2.getInstance().sendMessage(vo1);
        }
    }

    private void onRoleDetail(m_role_detail_toc vo)
    {
        Debug.Log("有角色信息");
        GlobalData.getInstance().user = vo.role_details;
        Dispatcher.dispatch(ModuleCommand.START_UP_SCENE);
    }
}
