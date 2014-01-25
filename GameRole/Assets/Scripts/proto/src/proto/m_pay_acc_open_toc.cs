namespace proto {
	public class m_pay_acc_open_toc : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int gift_id = 0;
		public int faction_id = 0;
		public object[] list;
		public int sex = 0;
		public int category = 0;
		public int level = 0;
		public m_pay_acc_open_toc() {
		}
		public override string getMethodName() {
			return "pay_acc_open";
		}
		public override string getClassName() {
			return "m_pay_acc_open_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"gift_id", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"list", "array", "p_pay_prop"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"level", "int", "null"}};
		}
	}
}
