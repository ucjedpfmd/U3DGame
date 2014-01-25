namespace proto {
	public class m_pet_weal_open_toc : Message
	{
		public int err_code = 0;
		public int id = 0;
		public int type = 0;
		public int gold = 0;
		public int sliver = 0;
		public int goods_id = 0;
		public int skill_exp = 0;
		public int map_id = 0;
		public m_pet_weal_open_toc() {
		}
		public override string getMethodName() {
			return "pet_weal_open";
		}
		public override string getClassName() {
			return "m_pet_weal_open_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"id", "int", "null"},new string[] {"type", "int", "null"},new string[] {"gold", "int", "null"},new string[] {"sliver", "int", "null"},new string[] {"goods_id", "int", "null"},new string[] {"skill_exp", "int", "null"},new string[] {"map_id", "int", "null"}};
		}
	}
}
