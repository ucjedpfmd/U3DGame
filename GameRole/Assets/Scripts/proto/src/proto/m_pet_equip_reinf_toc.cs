namespace proto {
	public class m_pet_equip_reinf_toc : Message
	{
		public int err_code = 0;
		public double pet_id = 0;
		public int times = 0;
		public p_goods equip_goods = null;
		public m_pet_equip_reinf_toc() {
		}
		public override string getMethodName() {
			return "pet_equip_reinf";
		}
		public override string getClassName() {
			return "m_pet_equip_reinf_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"times", "int", "null"},new string[] {"equip_goods", "p_goods", "null"}};
		}
	}
}
