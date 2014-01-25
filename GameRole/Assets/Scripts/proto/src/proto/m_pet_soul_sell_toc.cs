namespace proto {
	public class m_pet_soul_sell_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int index = 0;
		public object[] delete_souls;
		public int add_spirit = 0;
		public m_pet_soul_sell_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_sell";
		}
		public override string getClassName() {
			return "m_pet_soul_sell_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"index", "int", "null"},new string[] {"delete_souls", "array", "p_pet_soul"},new string[] {"add_spirit", "int", "null"}};
		}
	}
}
