namespace proto {
	public class m_equip_load_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_goods equip1 = null;
		public p_goods equip2 = null;
		public p_skin skin = null;
		public m_equip_load_toc() {
		}
		public override string getMethodName() {
			return "equip_load";
		}
		public override string getClassName() {
			return "m_equip_load_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"equip1", "p_goods", "null"},new string[] {"equip2", "p_goods", "null"},new string[] {"skin", "p_skin", "null"}};
		}
	}
}
