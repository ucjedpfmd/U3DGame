namespace proto {
	public class m_role_create_tos : Message
	{
		public string role_name = null;
		public int sex = 0;
		public int hair_type = 0;
		public int faction_id = 1;
		public int hair_color = 0;
		public int category = 0;
		public int tx_param = 1;
		public int auto = 0;
		public m_role_create_tos() {
		}
		public override string getMethodName() {
			return "role_create";
		}
		public override string getClassName() {
			return "m_role_create_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"hair_type", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"hair_color", "int", "null"},new string[] {"category", "int", "null"},new string[] {"tx_param", "int", "null"},new string[] {"auto", "int", "null"}};
		}
	}
}
