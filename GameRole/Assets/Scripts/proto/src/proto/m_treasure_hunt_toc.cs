namespace proto {
	public class m_treasure_hunt_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int op_type = 0;
		public object[] item;
		public bool use_letter = false;
		public m_treasure_hunt_toc() {
		}
		public override string getMethodName() {
			return "treasure_hunt";
		}
		public override string getClassName() {
			return "m_treasure_hunt_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"item", "array", "p_key_value"},new string[] {"use_letter", "bool", "null"}};
		}
	}
}
