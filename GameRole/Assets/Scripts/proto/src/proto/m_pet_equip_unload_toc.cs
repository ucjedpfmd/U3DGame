namespace proto {
	public class m_pet_equip_unload_toc : Message
	{
		public int err_code = 0;
		public p_goods equip = null;
		public double pet_id = 0;
		public m_pet_equip_unload_toc() {
		}
		public override string getMethodName() {
			return "pet_equip_unload";
		}
		public override string getClassName() {
			return "m_pet_equip_unload_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"equip", "p_goods", "null"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
