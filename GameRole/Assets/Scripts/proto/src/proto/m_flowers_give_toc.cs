namespace proto {
	public class m_flowers_give_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public string role_name = null;
		public string flower_name = null;
		public bool is_buy = false;
		public m_flowers_give_toc() {
		}
		public override string getMethodName() {
			return "flowers_give";
		}
		public override string getClassName() {
			return "m_flowers_give_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"role_name", "string", "null"},new string[] {"flower_name", "string", "null"},new string[] {"is_buy", "bool", "null"}};
		}
	}
}
