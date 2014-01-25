namespace proto {
	public class m_pet_tower_enter_toc : Message
	{
		public int op_type = 0;
		public int err_code = 0;
		public m_pet_tower_enter_toc() {
		}
		public override string getMethodName() {
			return "pet_tower_enter";
		}
		public override string getClassName() {
			return "m_pet_tower_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"err_code", "int", "null"}};
		}
	}
}
