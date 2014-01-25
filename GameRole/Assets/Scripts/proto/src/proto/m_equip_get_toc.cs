namespace proto {
	public class m_equip_get_toc : Message
	{
		public int err_code = 0;
		public int type_id = 0;
		public m_equip_get_toc() {
		}
		public override string getMethodName() {
			return "equip_get";
		}
		public override string getClassName() {
			return "m_equip_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type_id", "int", "null"}};
		}
	}
}
