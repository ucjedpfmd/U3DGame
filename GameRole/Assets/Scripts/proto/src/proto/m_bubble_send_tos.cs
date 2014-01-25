namespace proto {
	public class m_bubble_send_tos : Message
	{
		public int action_type = 0;
		public string msg = null;
		public double to_role_id = 0;
		public m_bubble_send_tos() {
		}
		public override string getMethodName() {
			return "bubble_send";
		}
		public override string getClassName() {
			return "m_bubble_send_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action_type", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"to_role_id", "double", "null"}};
		}
	}
}
