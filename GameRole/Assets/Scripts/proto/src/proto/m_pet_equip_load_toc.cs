namespace proto {
	public class m_pet_equip_load_toc : Message
	{
		public int err_code = 0;
		public p_goods equip1 = null;
		public p_goods equip2 = null;
		public double pet_id = 0;
		public m_pet_equip_load_toc() {
		}
		public override string getMethodName() {
			return "pet_equip_load";
		}
		public override string getClassName() {
			return "m_pet_equip_load_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"equip1", "p_goods", "null"},new string[] {"equip2", "p_goods", "null"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
