namespace proto {
	public class m_pet_equip_extra_toc : Message
	{
		public int err_code = 0;
		public double pet_id = 0;
		public int equip_id = 0;
		public int op_type = 0;
		public p_goods equip_goods = null;
		public m_pet_equip_extra_toc() {
		}
		public override string getMethodName() {
			return "pet_equip_extra";
		}
		public override string getClassName() {
			return "m_pet_equip_extra_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"equip_id", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"equip_goods", "p_goods", "null"}};
		}
	}
}
